using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLightController
{
    public partial class SetupScreen : MetroForm
    {
        #region Vars
        public ConfigFile Config
        {
            get { return _config; }
        }

        public SerialPort DriverSerial
        {
            get { return _serial; }
        }

        private bool _updateSoundDataProps = false;
        public bool UpdateSoundDataProps
        {
            get { return _updateSoundDataProps; }
            set { _updateSoundDataProps = value; }
        }

        private byte _bassSoundValue;
        public byte BassSoundValue
        {
            get { return _bassSoundValue; }
            set { _bassSoundValue = value; }
        }

        private byte _midSoundValue;
        public byte MidSoundValue
        {
            get { return _midSoundValue; }
            set { _midSoundValue = value; }
        }

        private ConfigFile _config;
        private string _configFile;

        private SerialPort _serial;
        private bool _serialValid = false;

        private bool _exiting = false;
        #endregion

        #region FMOD
        private bool _fmodLoading = false;
        private bool _fmodIOSettingsOK = false;

        private FMOD.System system = null;
        private FMOD.Sound sound = null;
        private FMOD.Channel channel = null;

        private bool _inputDeviceValid = false;
        private bool _outputDriverValid = false;
        private bool _outputDeviceValid = false;

        private bool _runSoundProcessor = false;
        private Thread _soundProcThread;

        private const int OUTPUTRATE = 48000;
        private const int SPECTRUMSIZE = 8192;
        #endregion

        #region UI
        public SetupScreen()
        {
            InitializeComponent();
        }

        private void StupScreen_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += Application_ApplicationExit;

            //Load the config
            _configFile = Path.Combine(Application.StartupPath, "Config.bin");
            if (File.Exists(_configFile))
            {
                _config = ConfigFile.ReadFile(_configFile);
            }
            else //Or create a new with basic settings
            {
                _config = new ConfigFile();
                _config.COMPort = "-";
                _config.Baud = 115200;
                _config.Brightness = 1.0f;
                _config.BassSlopeValue = 0.75f;
                _config.MidSlopeValue = 0.75f;
                _config.SamplesPerSecond = 30;
                _config.InputIndex = -1;
                _config.InputName = string.Empty;
                _config.OutputIndex = -1;
                _config.OutputName = string.Empty;
                _config.OutputDriverIndex = -1;
                _config.OutputDriverName = string.Empty;
                _config.MetroTheme = (byte)MetroThemeStyle.Light;
                _config.MetroColor = (byte)MetroColorStyle.Yellow;
                _config.BassVolume = 1.0f;
                _config.MidVolume = 1.0f;

                _config.Write(_configFile);
            }

            //Setup the UI
            {
                //Setup the COM port
                btnCOMrefresh_Click(null, null);

                if (!string.IsNullOrEmpty(_config.COMPort) && _config.COMPort.StartsWith("COM"))
                {
                    //Select the COM port based on the config
                    for (int x = 0; x < cbComs.Items.Count; x++)
                    {
                        if ((string)cbComs.Items[x] == _config.COMPort)
                        {
                            cbComs.SelectedIndex = x;
                            break;
                        }
                    }
                }

                //Setup the baud settings
                for (int x = 0; x < cbBaud.Items.Count; x++)
                {
                    if ((string)cbBaud.Items[x] == _config.Baud.ToString())
                    {
                        cbBaud.SelectedIndex = x;
                        break;
                    }
                }

                //Setup the style settings
                foreach(MetroThemeStyle v in (MetroThemeStyle[])Enum.GetValues(typeof(MetroThemeStyle)))
                {
                    cbMetroStyle.Items.Add(v);
                    if (v == (MetroThemeStyle)_config.MetroTheme)
                        cbMetroStyle.SelectedIndex = cbMetroStyle.Items.Count - 1;
                }

                foreach (MetroColorStyle v in (MetroColorStyle[])Enum.GetValues(typeof(MetroColorStyle)))
                {
                    cbMetroColor.Items.Add(v);
                    if (v == (MetroColorStyle)_config.MetroColor)
                        cbMetroColor.SelectedIndex = cbMetroColor.Items.Count - 1;
                }

                //Revert to the default baud rate if nothing is selected (shouldn't be possible)
                if (cbBaud.SelectedIndex < 0)
                {
                    cbBaud.SelectedIndex = 8; //115200
                }

                //Load trackbar values
                trackBrigtness.Value = (int)Math.Floor(_config.Brightness * (float)trackBrigtness.Maximum);
                trackBassSlope.Value = (int)Math.Round(_config.BassSlopeValue * ((float)trackBassSlope.Maximum / 10.0f), 2);
                trackMidSlope.Value = (int)Math.Round(_config.MidSlopeValue * ((float)trackMidSlope.Maximum / 10.0f), 2);
                trackSamples.Value = _config.SamplesPerSecond;
                trackBassVol.Value = (int)Math.Round(_config.BassVolume * ((float)trackBassVol.Maximum / 2.0f), 2);
                trackMidVol.Value = (int)Math.Round(_config.MidVolume * ((float)trackMidVol.Maximum / 2.0f), 2);

                //Load value label texts
                lblBrightness.Text = ((int)Math.Floor(_config.Brightness * 100.0f)).ToString() + "%";
                lblBSlope.Text = _config.BassSlopeValue.ToString().Replace(',', '.');
                lblMSlope.Text = _config.MidSlopeValue.ToString().Replace(',', '.');
                lblSamples.Text = _config.SamplesPerSecond.ToString();
                lblBassVol.Text = Math.Round(_config.BassVolume, 2).ToString().Replace(',', '.');
                lblMidVol.Text = Math.Round(_config.MidVolume, 2).ToString().Replace(',', '.'); 

                //Load the checkbox
                cbInToOut.Checked = _config.MirrorSound;

                InitDrivers();

                //Setup the FMOD system
                _fmodLoading = true; //Used to prevent I/O comboboxes to update config
                if (InitFMOD())
                {
                    //Check if settings are valid and open port
                    if (!string.IsNullOrEmpty(_config.COMPort) && _config.COMPort != "-")
                        OpenOrUpdateSerialPort();
                }
                _fmodLoading = false;
            }
        }

        private void cbMetroStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager.Theme = (MetroThemeStyle)cbMetroStyle.Items[cbMetroStyle.SelectedIndex];
            Theme = metroStyleManager.Theme;
            metroStyleManager.UpdateOwnerForm();
            Refresh();

            _config.MetroTheme = (byte)metroStyleManager.Theme;

            //Save the config
            _config.Write(_configFile);
        }

        private void cbMetroColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            metroStyleManager.Style = (MetroColorStyle)cbMetroColor.Items[cbMetroColor.SelectedIndex];
            Style = metroStyleManager.Style;
            metroStyleManager.UpdateOwnerForm();
            Refresh();

            _config.MetroColor = (byte)metroStyleManager.Style;

            //Save the config
            _config.Write(_configFile);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            CloseSerial();

            DisposeFMOD();

            //Save the config if it is valid
            if (_config != null)
            {
                _config.Write(_configFile);
            }
        }

        private void btnCOMrefresh_Click(object sender, EventArgs e)
        {
            //Store the currently selected item
            string sel = string.Empty;
            if (cbComs.SelectedIndex > -1)
                sel = (string)cbComs.Items[cbComs.SelectedIndex];

            //Clear and update the list
            cbComs.Items.Clear();
            cbComs.Items.AddRange(SerialPort.GetPortNames());

            //Reselect the original (if possible)
            if(!string.IsNullOrEmpty(sel))
            {
                for (int x = 0; x < cbComs.Items.Count; x++)
                {
                    if ((string)cbComs.Items[x] == sel)
                    {
                        cbComs.SelectedIndex = x;
                        break;
                    }
                }
            }
        }

        private void btnSaveCOM_Click(object sender, EventArgs e)
        {
            //Check and apply COM port setting
            if (cbComs.SelectedIndex < 0)
                _config.COMPort = "-";
            else
                _config.COMPort = (string)cbComs.Items[cbComs.SelectedIndex];

            //Check and apply baud rate setting
            if (cbBaud.SelectedIndex < 0)
                _config.Baud = 115200;
            else
                _config.Baud = Convert.ToUInt32((string)cbBaud.Items[cbBaud.SelectedIndex]);

            //Save the config
            _config.Write(_configFile);

            //Open port
            OpenOrUpdateSerialPort();
        }

        private void UpdateSerialPortStatus(string status)
        {
            if (InvokeRequired) //If not running in the main thread invoke it
                Invoke(new Action(() => UpdateSerialPortStatus(status)));
            else
                lblSerialStatus.Text = status;
        }

        private void StupScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting)
            {
                //Cancel the form close event and hide the form instead
                e.Cancel = true;

                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the window
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tell the close event handler that we want to exit
            _exiting = true;

            Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            settingsToolStripMenuItem_Click(sender, e); //Show the form using the settings context menu button
        }

        private void trackBrigtness_Scroll(object sender, ScrollEventArgs e)
        {
            _config.Brightness = trackBrigtness.Value / (float)trackBrigtness.Maximum;
            lblBrightness.Text = ((int)Math.Floor(_config.Brightness * 100.0f)).ToString() + "%";
        }

        private void trackBassSlope_Scroll(object sender, ScrollEventArgs e)
        {
            _config.BassSlopeValue = trackBassSlope.Value / ((float)trackBassSlope.Maximum / 10.0f);
            lblBSlope.Text = _config.BassSlopeValue.ToString().Replace(',', '.');
        }

        private void trackMidSlope_Scroll(object sender, ScrollEventArgs e)
        {
            _config.MidSlopeValue = trackMidSlope.Value / ((float)trackMidSlope.Maximum / 10.0f);
            lblMSlope.Text = _config.MidSlopeValue.ToString().Replace(',', '.');
        }

        private void trackSamples_Scroll(object sender, ScrollEventArgs e)
        {
            _config.SamplesPerSecond = (ushort)trackSamples.Value;
            lblSamples.Text = _config.SamplesPerSecond.ToString();
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fmodLoading)
            {
                _config.InputIndex = cbInput.SelectedIndex;
                _config.InputName = (string)cbInput.Items[_config.InputIndex];
            }

            _inputDeviceValid = (cbInput.SelectedIndex > -1);

            StartSoundProcessor();
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fmodLoading)
            {
                _config.OutputIndex = cbOutput.SelectedIndex;
                _config.OutputName = (string)cbOutput.Items[_config.OutputIndex];
            }

            _outputDeviceValid = ERRCHECK(system.setDriver(cbOutput.SelectedIndex));

            StartSoundProcessor();
        }

        private void cbOutputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fmodLoading)
            {
                _config.OutputDriverIndex = cbOutputMode.SelectedIndex;
                _config.OutputDriverName = (string)cbOutputMode.Items[_config.OutputDriverIndex];
            }

            FMOD.RESULT result = FMOD.RESULT.OK;
            switch (cbOutputMode.SelectedIndex)
            {
                case 0:
                    result = system.setOutput(FMOD.OUTPUTTYPE.DSOUND);
                    break;
                case 1:
                    result = system.setOutput(FMOD.OUTPUTTYPE.WINMM);
                    break;
                case 2:
                    result = system.setOutput(FMOD.OUTPUTTYPE.ASIO);
                    break;
            }
            _outputDriverValid = ERRCHECK(result);

            StartSoundProcessor();
        }

        private void cbInToOut_CheckedChanged(object sender, EventArgs e)
        {
            _config.MirrorSound = cbInToOut.Checked;

            StartSoundProcessor();
        }

        private void trackBassVol_Scroll(object sender, ScrollEventArgs e)
        {
            _config.BassVolume = (float)trackBassVol.Value / 100.0f;

            lblBassVol.Text = Math.Round(_config.BassVolume, 2).ToString().Replace(',', '.');
        }

        private void trackMidVol_Scroll(object sender, ScrollEventArgs e)
        {
            _config.MidVolume = (float)trackMidVol.Value / 100.0f;

            lblMidVol.Text = Math.Round(_config.MidVolume, 2).ToString().Replace(',', '.');
        }
        #endregion

        #region FMOD
        private bool InitFMOD()
        {
            //Create an FMOD system
            if (!ERRCHECK(FMOD.Factory.System_Create(ref system)))
                return false;

            //Make sure we have the same version in both binaries and wrapper
            uint version = 0; 
            if (!ERRCHECK(system.getVersion(ref version)))
                return false;

            if (version < FMOD.VERSION.number)
            {
                MessageBox.Show(this, "Music LED controller - FMOD error!", "Error!  You are using an old version of FMOD " + version.ToString("X") + ".  This program requires " + FMOD.VERSION.number.ToString("X") + ". Check the \"fmodex.dll\"!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Load all the output drivers
            int driverCount = 0;
            if (!ERRCHECK(system.getNumDrivers(ref driverCount)))
                return false;

            StringBuilder driverName = new StringBuilder(256);
            FMOD.GUID guid = new FMOD.GUID();
            for (int x = 0; x < driverCount; x++)
            {
                if (!ERRCHECK(system.getDriverInfo(x, driverName, driverName.Capacity, ref guid)))
                    return false;

                cbOutput.Items.Add(driverName.ToString());
            }

            //Load all the input drivers
            if (!ERRCHECK(system.getRecordNumDrivers(ref driverCount)))
                return false;

            for (int x = 0; x < driverCount; x++)
            {
                if (!ERRCHECK(system.getRecordDriverInfo(x, driverName, driverName.Capacity, ref guid)))
                    return false;

                cbInput.Items.Add(driverName.ToString());
            }

            //Load the UI to match the config
            if (_config.InputIndex > -1 && !string.IsNullOrEmpty(_config.InputName))
            {
                string at = (_config.InputIndex < cbInput.Items.Count ? (string)cbInput.Items[_config.InputIndex] : string.Empty);
                if (at != _config.InputName) //The name at the index does not match the saved name
                {
                    //Clear input settings
                    _config.InputIndex = -1;
                    _config.InputName = "";

                    //See if we have the input device somewhere else
                    for (int x = 0; x < cbInput.Items.Count; x++)
                    {
                        if ((string)cbInput.Items[x] == _config.InputName)
                        {
                            _config.InputIndex = x;
                            cbInput.SelectedIndex = x;
                            break;
                        }
                    }
                }
                else
                {
                    cbInput.SelectedIndex = _config.InputIndex; //The settings match
                }
            }

            if (_config.OutputIndex > -1 && !string.IsNullOrEmpty(_config.OutputName))
            {
                string at = (_config.OutputIndex < cbOutput.Items.Count ? (string)cbOutput.Items[_config.OutputIndex] : string.Empty);
                if (at != _config.OutputName) //The name at the index does not match the saved name
                {
                    //Clear input settings
                    _config.OutputIndex = -1;
                    _config.OutputName = "";

                    //See if we have the input device somewhere else
                    for (int x = 0; x < cbOutput.Items.Count; x++)
                    {
                        if ((string)cbOutput.Items[x] == _config.OutputName)
                        {
                            _config.OutputIndex = x;
                            cbOutput.SelectedIndex = x;
                            break;
                        }
                    }
                }
                else
                {
                    cbOutput.SelectedIndex = _config.OutputIndex; //The settings match
                }
            }
            
            if (_config.OutputDriverIndex > -1 && !string.IsNullOrEmpty(_config.OutputDriverName))
            {
                string at = (_config.OutputDriverIndex < cbOutputMode.Items.Count ? (string)cbOutputMode.Items[_config.OutputDriverIndex] : string.Empty);
                if (at != _config.OutputDriverName) //The name at the index does not match the saved name
                {
                    //Clear input settings
                    _config.OutputDriverIndex = -1;
                    _config.OutputDriverName = "";

                    //See if we have the input device somewhere else
                    for (int x = 0; x < cbOutputMode.Items.Count; x++)
                    {
                        if ((string)cbOutputMode.Items[x] == _config.OutputDriverName)
                        {
                            _config.OutputDriverIndex = x;
                            cbOutputMode.SelectedIndex = x;
                            break;
                        }
                    }
                }
                else
                {
                    cbOutputMode.SelectedIndex = _config.OutputDriverIndex; //The settings match
                }
            }

            StartSoundProcessor();

            return true;
        }

        private void DisposeFMOD()
        {
            bool playing = false;
            if (channel != null && ERRCHECK(channel.isPlaying(ref playing)) && playing) //Stop the channel if it's playing
            {
                channel.stop();
            }

            if (sound != null) //Release the sound
            {
                ERRCHECK(sound.release());
            }

            if (system != null) //Close and release the system
            {
                ERRCHECK(system.close());
                ERRCHECK(system.release());
            }
        }

        private void StartSoundProcessor()
        {
            if (_inputDeviceValid && _outputDeviceValid && _outputDriverValid) //Check if everything is OK
            {
                if (_soundProcThread != null) //See if processor is running
                {
                    //Stop the processor
                    _runSoundProcessor = false;
                    _soundProcThread.Join();
                }

                if (!_fmodIOSettingsOK)
                {
                    _fmodIOSettingsOK = true;

                    //Setup the FMOD recorder
                    if (!ERRCHECK(system.setSoftwareFormat(OUTPUTRATE, FMOD.SOUND_FORMAT.PCM16, 2, 2, 0))) //Set the I/O format (2 channels in, 2 channels out -> stereo)
                        return;

                    if (!ERRCHECK(system.init(1, FMOD.INITFLAGS.NORMAL, (IntPtr)null))) //Init the FMOD system to 1 stereo channel
                        return;
                }

                bool playing = false;
                if (channel != null && ERRCHECK(channel.isPlaying(ref playing)) && playing)
                {
                    channel.stop();
                }

                if (sound != null)
                {
                    sound.release();
                }

                int temp = 0; //Dump random values into this
                FMOD.SOUND_FORMAT format = FMOD.SOUND_FORMAT.NONE;
                FMOD.DSP_RESAMPLER resampler = FMOD.DSP_RESAMPLER.MAX;
                int outputfreq = 0;
                int numout = 0;
                if (!ERRCHECK(system.getSoftwareFormat(ref outputfreq, ref format, ref numout, ref temp, ref resampler, ref temp)))
                    return;

                FMOD.CREATESOUNDEXINFO exinfo = new FMOD.CREATESOUNDEXINFO();
                exinfo.cbsize = Marshal.SizeOf(exinfo);
                exinfo.numchannels = numout; //2;
                exinfo.format = format; //FMOD.SOUND_FORMAT.PCM16;
                exinfo.defaultfrequency = outputfreq; //OUTPUTRATE;
                exinfo.length = (uint)((exinfo.defaultfrequency * 2 * exinfo.numchannels * 5) * 2.00f); //0.65f

                if (!ERRCHECK(system.createSound((string)null, (FMOD.MODE._2D | FMOD.MODE.SOFTWARE | FMOD.MODE.OPENUSER | FMOD.MODE.LOOP_NORMAL), ref exinfo, ref sound)))
                    return;

                if (!ERRCHECK(system.recordStart(cbInput.SelectedIndex, sound, true))) //Start recording the sound
                    return;

                Thread.Sleep(75); //We need some time before we have enough data to analyse -> this gives some latency

                if (!ERRCHECK(system.playSound(FMOD.CHANNELINDEX.REUSE, sound, false, ref channel))) //Play the sound so we can analyse it
                    return;

                if (!ERRCHECK(channel.setVolume(_config.MirrorSound ? 1.0f : 0.0f))) //Setup the channel volume so we can transfer the input to the output which !!corrects the latency!!
                    return;

                //Tell the thread to run
                _runSoundProcessor = true; 

                //Creat the processor thread
                _soundProcThread = new Thread(DoProcessSound);
                _soundProcThread.Name = "Sound processor";
                _soundProcThread.IsBackground = true;
                _soundProcThread.Start();
            }
            else //Some setting changed stop the processor
            {
                _runSoundProcessor = false;
                if (_soundProcThread != null)
                    _soundProcThread.Join();
            }
        }

        private bool ERRCHECK(FMOD.RESULT result)
        {
            if (result != FMOD.RESULT.OK)
            {
                MessageBox.Show(this, "Music LED controller - FMOD error!", "" + result + " - " + FMOD.Error.String(result), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region COM
        private void OpenOrUpdateSerialPort()
        {
            _serialValid = false;

            try
            {
                UpdateSerialPortStatus("Closing old...");
                if (_serial != null)
                {
                    _serial.Close();
                }

                UpdateSerialPortStatus("Opening...");
                _serial = new SerialPort(_config.COMPort, (int)_config.Baud);
                _serial.Open();

                _serialValid = true;
                UpdateSerialPortStatus("Opened");
            }
            catch (Exception ex)
            {
                UpdateSerialPortStatus("Failed to open.");

                string additional = string.Empty;
                if (ex is UnauthorizedAccessException)
                    additional += "Are you sure the port is not used by another program?";

                MessageBox.Show(this, "An error ocurred while opening the COM port:\n\"" + ex.Message + "\"" + (string.IsNullOrEmpty(additional) ? string.Empty : "\n\n" + additional), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseSerial()
        {
            _serialValid = false;

            if (_serial != null)
            {
                UpdateSerialPortStatus("Closing..");
                try
                {
                    _serial.Close();
                    _serial = null;
                }
                catch (Exception ex)
                {
                    UpdateSerialPortStatus("Failed to close.");

                    MessageBox.Show(this, "An error ocurred while closing the COM port:\n\"" + ex.Message + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateSerialPortStatus("Closed");
            }
        }

        private void SerialWriteError()
        {
            _serialValid = false;

            OpenOrUpdateSerialPort();
        }
        #endregion

        #region Sound processor
        //Processor vars
        float _prevBass = 0.0f;
        float _prevSound = 0.0f;

        float[] spectrumL = new float[SPECTRUMSIZE];
        float[] spectrumR = new float[SPECTRUMSIZE];

        int _lastSentBass = 0;
        int _lastSentMid = 0;

        //Used to make sure the LEDs pulse even when the sound "seems" stable -> gives a nice pulse on the BPM (not 100% accurate but better than nothing)
        private float Mix(float x1, float x2, float y1, float y2, float x)
        {
            return (y1 - y2) / (x1 - x2) * (x - x1) + y1;
        }

        private int Clamp(int value, int max, int min)
        {
            if (value > max)
                return max;
            if (value < min)
                return min;

            return value;
        }

        //Sound processor thread
        private void DoProcessSound()
        {
            //Pre calculate some values
            int midStart = (int)((float)SPECTRUMSIZE * 0.0125f); //0.01f
            int midEnd = (int)(SPECTRUMSIZE * 0.75f); //0.65f

            float left_sum, right_sum, mulpos, bassSum, soundSum;

            //Timer to make sure we run at the desired samples per second
            Stopwatch timer = new Stopwatch();

            //Let's run until we are told to
            while (_runSoundProcessor)
            {
                timer.Restart(); //Restart the time measurement

                if (system != null)
                    system.update(); //Update the FMOD system

                int targetTime = (1000 / (_config.SamplesPerSecond <= 0 ? 30 : _config.SamplesPerSecond)); //Calculate the time for one sample

                try
                {
                    if (!_outputDriverValid || !_outputDeviceValid || !_inputDeviceValid)
                    {
                        Thread.Sleep(500); //I/O settings aren't valid, wait 0.5s
                    }
                    else
                    {
                        if (channel != null && _serial != null && _serialValid) //See if we have a playing channel and a correct serial port then do the math
                        {
                            //Get the left and right specturm
                            channel.getSpectrum(spectrumL, SPECTRUMSIZE, 0, FMOD.DSP_FFT_WINDOW.HAMMING);
                            channel.getSpectrum(spectrumR, SPECTRUMSIZE, 1, FMOD.DSP_FFT_WINDOW.HAMMING);

                            //Zero the bass sum and calculate the lower end of the spectrums
                            bassSum = 0.0f;
                            for (int i = 0; i < midStart; i++)
                            {
                                bassSum += (spectrumL[i] + spectrumR[i]) * ((float)SPECTRUMSIZE / (128.0f));
                            }
                            bassSum /= (((float)SPECTRUMSIZE / midStart) * 4.5f); //Create and average
                            bassSum *= _config.BassVolume;

                            //Zero the sound values and do the mid range calculations
                            left_sum = right_sum = soundSum = 0.0f;
                            for (int i = midStart; i < midEnd; i++)
                            {
                                mulpos = 1.0f - (float)Math.Pow(((float)((i - midStart) + 1.0f) / ((float)(midEnd - midStart) * 1.25f)), 2); //Use a pow function to create a slope which eliminates high freq sounds and lowers the value of the mid end freqs

                                left_sum += spectrumL[i] * mulpos;
                                right_sum += spectrumR[i] * mulpos;
                            }
                            left_sum /= 10f;
                            right_sum /= 10f;
                            soundSum = (left_sum + right_sum) / 2.0f * _config.MidVolume; //Sum the left and right to get the value for the mid range

                            //Apply the pulsing effect by taking the last sample into account
                            _prevBass = Mix(0, 100, bassSum, _prevBass, 0);
                            _prevSound = Mix(0, 100, soundSum, _prevSound, 0);

                            //Apply some scaling (used to make the light follow a "logarithmic curve" to make more sound more bright)
                            bassSum = (float)Math.Pow(_prevBass, _config.BassSlopeValue);
                            soundSum = (float)Math.Pow(_prevSound, _config.MidSlopeValue);

                            if (_serialValid && _serial != null)
                            {
                                //Convert the sound values into byte ranges...
                                int bByte = Clamp((int)(bassSum * 254.0f), 254, 0);
                                int sByte = Clamp((int)(soundSum * 254.0f), 254, 0);

                                if (_lastSentBass != bByte || _lastSentMid != sByte)
                                {
                                    _lastSentBass = bByte;
                                    _lastSentMid = sByte;

                                    DriveLEDs((byte)bByte, (byte)sByte);

                                    //_serial.Write(new byte[] { (byte)(bByte), (byte)(sByte) }, 0, 2); //... and output them to the LED controller
                                }
                            }
                        }

                        int waitTime = (int)(targetTime - timer.ElapsedMilliseconds);
                        if (waitTime > 0)
                            Thread.Sleep(waitTime); //Wait to fill the sample time
                        else
                            Thread.Yield(); //Give time to other threads too
                    }
                }
                catch (Exception ex)
                {
                    //if (_runSoundProcessor)
                    //{
                    //    MessageBox.Show("Music LED controller - FMOD error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
        }
        #endregion

        #region LED drivers
        private bool _ledOutputEnable = true;

        public bool LEDOuputEnable
        {
            get { return _ledOutputEnable; }
            set { _ledOutputEnable = value; }
        }

        struct LEDDriverInfo
        {
            public string Name;
            public Action<SetupScreen, byte, byte> DriverFunction;
            public Type SetupForm;

            public LEDDriverInfo(string name, Action<SetupScreen, byte, byte> driver, Type setup)
            {
                Name = name;
                DriverFunction = driver;
                SetupForm = setup;
            }
        }

        struct RGBCachedData
        {
            public Color TopLeft;
            public Color TopRight;
            public Color BottomLeft;
            public Color BottomRight;
        }

        private static List<LEDDriverInfo> _drivers = new List<LEDDriverInfo>()
        {
            new LEDDriverInfo("2 channel", new Action<SetupScreen, byte, byte>(LEDDriver_2Channel), null),
            new LEDDriverInfo("RGB", new Action<SetupScreen, byte, byte>(LEDDriver_RGB), typeof(RGBSetupForm)),
        };

        public object CachedDriverData = null;

        private void InitDrivers()
        {
            cbLedDriver.Items.Clear();
            foreach(LEDDriverInfo inf in _drivers)
            {
                cbLedDriver.Items.Add(inf.Name);
            }

            if (_config.LEDDriver >= 0 && _config.LEDDriver < cbLedDriver.Items.Count)
            {
                cbLedDriver.SelectedIndex = _config.LEDDriver;
            }
            else
            {
                _config.LEDDriver = 0;
                cbLedDriver.SelectedIndex = 0;
            }
        }

        private static void LEDDriver_2Channel(SetupScreen scr, byte bass, byte mid)
        {
            scr.DriverSerial.Write(new byte[] { (byte)(bass * scr.Config.Brightness), (byte)(mid * scr.Config.Brightness) }, 0, 2);
        }

        private static void LEDDriver_RGB(SetupScreen scr, byte bass, byte mid)
        {
            if (scr.CachedDriverData == null || !(scr.CachedDriverData is RGBCachedData))
            {
                if (!string.IsNullOrEmpty(scr.Config.LEDDriverConfig))
                {
                    if (scr.Config.LEDDriverConfig.StartsWith("cfgRGB"))
                    {
                        string[] data = scr.Config.LEDDriverConfig.Split('|');
                        if (data.Length == 5)
                        {
                            RGBCachedData rb = new RGBCachedData();

                            rb.TopLeft = Utils.ParseRGB(data[1]);
                            rb.TopRight = Utils.ParseRGB(data[2]);
                            rb.BottomLeft = Utils.ParseRGB(data[3]);
                            rb.BottomRight = Utils.ParseRGB(data[4]);

                            scr.CachedDriverData = rb;
                        }
                    }
                }
            }

            if (scr.CachedDriverData != null && scr.CachedDriverData is RGBCachedData)
            {
                RGBCachedData rg = (RGBCachedData)scr.CachedDriverData;

                float x = (float)Math.Pow(bass / (float)byte.MaxValue, 1.5f);
                float y = (float)Math.Pow((byte.MaxValue - mid) / (float)byte.MaxValue, 1.5f);

                Color c = Utils.BilinearInterpolation(rg.TopLeft, rg.BottomLeft, rg.TopRight, rg.BottomRight, x, y);

                scr.DriverSerial.Write(new byte[] { 0x1, (byte)(c.R * scr.Config.Brightness), (byte)(c.G * scr.Config.Brightness), (byte)(c.B * scr.Config.Brightness) }, 0, 4);
            }
        }

        private void cbLedDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            _config.LEDDriver = (byte)cbLedDriver.SelectedIndex;

            btnDriverSetup.Enabled = (_drivers[_config.LEDDriver].SetupForm != null);
        }

        private void DriveLEDs(byte bass, byte mid)
        {
            if (_ledOutputEnable)
            {
                _drivers[_config.LEDDriver].DriverFunction(this, bass, mid);
            }

            if(_updateSoundDataProps)
            {
                _bassSoundValue = bass;
                _midSoundValue = mid;
            }
        }

        private void btnDriverSetup_Click(object sender, EventArgs e)
        {
            using (Form form = (Form)Activator.CreateInstance(_drivers[_config.LEDDriver].SetupForm))
            {
                form.ShowDialog(this);
            }

            CachedDriverData = null;
            _ledOutputEnable = true;
            _updateSoundDataProps = false;
        }

        public void ApplyMetroStyle(MetroForm form, MetroStyleManager mgr)
        {
            form.Theme = mgr.Theme = Theme;
            form.Style = mgr.Style = Style;

            mgr.UpdateOwnerForm();
            form.Refresh();
        }
        #endregion
    }
}
