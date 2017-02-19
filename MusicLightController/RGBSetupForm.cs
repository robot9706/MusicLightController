using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController
{
    public partial class RGBSetupForm : MetroForm
    {
        private SerialPort _port;
        private ConfigFile _config;

        private SetupScreen _setupForm;

        private bool _isCalibrating = false;
        private bool _enableBilinearGrid = false;

        public RGBSetupForm()
        {
            InitializeComponent();
        }

        private void RGBSetupForm_Load(object sender, EventArgs e)
        {
            if(Owner is SetupScreen)
            {
                _setupForm = (SetupScreen)Owner;

                _setupForm.UpdateSoundDataProps = true;

                _setupForm.ApplyMetroStyle(this, metroStyleManager);
                _port = _setupForm.DriverSerial;
                _config = _setupForm.Config;

                bool hasBilinearGridData = false;

                if(!string.IsNullOrEmpty(_config.LEDDriverConfig))
                {
                    try
                    {
                        if (_config.LEDDriverConfig.StartsWith("cfgRGB"))
                        {
                            string[] data = _config.LEDDriverConfig.Split('|');
                            if (data.Length == 5)
                            {
                                Color topLeft = Utils.ParseRGB(data[1]);
                                Color topRight = Utils.ParseRGB(data[2]);
                                Color bottomLeft = Utils.ParseRGB(data[3]);
                                Color bottomRight = Utils.ParseRGB(data[4]);

                                cbTopLeft.BackColor = topLeft;
                                cbTopRight.BackColor = topRight;
                                cbBottomLeft.BackColor = bottomLeft;
                                cbBottomRight.BackColor = bottomRight;

                                hasBilinearGridData = true;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(this, "Failed to load driver config info! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(!hasBilinearGridData)
                {
                    cbTopLeft.BackColor = Color.Red;
                    cbTopRight.BackColor = Color.Yellow;
                    cbBottomRight.BackColor = Color.Blue;
                    cbBottomLeft.BackColor = Color.Black;
                }
            }

            panelUVPointer.BackColor = Color.White;
            bilinearUVTimer.Enabled = true;

            _enableBilinearGrid = true;
            RenderBilinearGrid();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if(_isCalibrating)
            {
                btnCalibration.Text = "Begin calibration";
                lblCalibTip.Text = "";

                if(MessageBox.Show(this, "Do you want to save the calibration data?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _port.Write(new byte[] { 0x3, (byte)calibRed.Value, (byte)calibGreen.Value, (byte)calibBlue.Value }, 0, 4);
                }

                _isCalibrating = false;
                _setupForm.LEDOuputEnable = true;
            }
            else
            {
                lblCalibTip.Text = "Reading calibration values...";
                Refresh();

                Cursor = Cursors.WaitCursor;
                Task.WaitAny(
                    Task.Delay(1000),
                    Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            if (_port.BytesToRead > 0)
                            {
                                byte[] nothing = new byte[_port.BytesToRead];
                                _port.Read(nothing, 0, nothing.Length);
                            }

                            _port.Write(new byte[] { 0x2 }, 0, 1);

                            while (_port.BytesToRead < 3) { }

                            byte[] calibData = new byte[3];
                            _port.Read(calibData, 0, calibData.Length);

                            calibRed.Value = calibData[0];
                            calibGreen.Value = calibData[1];
                            calibBlue.Value = calibData[2];
                        }
                        catch(Exception)
                        {
                            lblCalibTip.Text = "Failed to get calibration data!";
                        }
                    })
                );

                Cursor = Cursors.Default;

                btnCalibration.Text = "End calibration";
                lblCalibTip.Text = "Move the sliders until you have a clear white color.";

                _isCalibrating = true;
                _setupForm.LEDOuputEnable = false;
            }
        }

        private void RGBSetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _setupForm.LEDOuputEnable = true;
            _setupForm.UpdateSoundDataProps = false;

            SaveRGBConfig();
        }

        private void SaveRGBConfig()
        {
            _config.LEDDriverConfig = "cfgRGB|" + Utils.ColorToString(cbTopLeft.BackColor) + "|" + Utils.ColorToString(cbTopRight.BackColor) + "|"
               + Utils.ColorToString(cbBottomLeft.BackColor) + "|" + Utils.ColorToString(cbBottomRight.BackColor);
        }

        private void calibRed_ValueChanged(object sender, EventArgs e)
        {
            _port.Write(new byte[] { 0x4, (byte)calibRed.Value, (byte)calibGreen.Value, (byte)calibBlue.Value }, 0, 4);
        }

        private void cbTopLeft_BackColorChanged(object sender, EventArgs e)
        {
            RenderBilinearGrid();
        }

        private void RenderBilinearGrid()
        {
            if (!_enableBilinearGrid)
                return;

            if (pbBilinearGrid.BackgroundImage != null)
                pbBilinearGrid.BackgroundImage.Dispose();

            Bitmap newImage = new Bitmap(pbBilinearGrid.Width, pbBilinearGrid.Height);

            Color topLeft = cbTopLeft.BackColor;
            Color topRight = cbTopRight.BackColor;
            Color bottomLeft = cbBottomLeft.BackColor;
            Color bottomRight = cbBottomRight.BackColor;

            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    newImage.SetPixel(x, y, Utils.BilinearInterpolation(topLeft, bottomLeft, topRight, bottomRight, x / (float)newImage.Width, y / (float)newImage.Height));
                }
            }

            pbBilinearGrid.BackgroundImage = newImage;
        }

        private void cbTopRight_DoubleClick(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = ((Control)sender).BackColor;
                if(cd.ShowDialog()  == DialogResult.OK)
                {
                    ((Control)sender).BackColor = cd.Color;

                    SaveRGBConfig();
                    _setupForm.CachedDriverData = null;
                }
            }
        }

        private void bilinearUVTimer_Tick(object sender, EventArgs e)
        {
            panelUVPointer.Left = (int)(pbBilinearGrid.Width * ((float)_setupForm.BassSoundValue) / (float)Byte.MaxValue);
            panelUVPointer.Top = (int)(pbBilinearGrid.Height * (1.0f - ((float)_setupForm.MidSoundValue) / (float)Byte.MaxValue));
        }

        private void RGBSetupForm_ResizeEnd(object sender, EventArgs e)
        {
            if (pbBilinearGrid.BackgroundImage != null)
            {
                if (pbBilinearGrid.Width == pbBilinearGrid.BackgroundImage.Width && pbBilinearGrid.Height == pbBilinearGrid.BackgroundImage.Height)
                    return;
            }

            RenderBilinearGrid();
        }
    }
}
