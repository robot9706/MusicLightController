namespace MusicLightController
{
    partial class RGBSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCalibTip = new MetroFramework.Controls.MetroLabel();
            this.btnCalibration = new MetroFramework.Controls.MetroButton();
            this.calibBlue = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.calibGreen = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.calibRed = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTopLeft = new System.Windows.Forms.PictureBox();
            this.cbTopRight = new System.Windows.Forms.PictureBox();
            this.cbBottomRight = new System.Windows.Forms.PictureBox();
            this.cbBottomLeft = new System.Windows.Forms.PictureBox();
            this.pbBilinearGrid = new System.Windows.Forms.Panel();
            this.panelUVPointer = new System.Windows.Forms.Panel();
            this.bilinearUVTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBottomLeft)).BeginInit();
            this.pbBilinearGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblCalibTip);
            this.groupBox4.Controls.Add(this.btnCalibration);
            this.groupBox4.Controls.Add(this.calibBlue);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.calibGreen);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.calibRed);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.ForeColor = System.Drawing.Color.Silver;
            this.groupBox4.Location = new System.Drawing.Point(23, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 158);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "White calibration";
            // 
            // lblCalibTip
            // 
            this.lblCalibTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalibTip.CustomBackground = false;
            this.lblCalibTip.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblCalibTip.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCalibTip.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCalibTip.Location = new System.Drawing.Point(150, 124);
            this.lblCalibTip.Name = "lblCalibTip";
            this.lblCalibTip.Size = new System.Drawing.Size(325, 19);
            this.lblCalibTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCalibTip.StyleManager = this.metroStyleManager;
            this.lblCalibTip.TabIndex = 7;
            this.lblCalibTip.Text = "-";
            this.lblCalibTip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCalibTip.UseStyleColors = false;
            // 
            // btnCalibration
            // 
            this.btnCalibration.Highlight = false;
            this.btnCalibration.Location = new System.Drawing.Point(12, 120);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(132, 26);
            this.btnCalibration.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCalibration.StyleManager = this.metroStyleManager;
            this.btnCalibration.TabIndex = 6;
            this.btnCalibration.Text = "Begin calibration";
            this.btnCalibration.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // calibBlue
            // 
            this.calibBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibBlue.BackColor = System.Drawing.Color.Transparent;
            this.calibBlue.CustomBackground = false;
            this.calibBlue.LargeChange = ((uint)(5u));
            this.calibBlue.Location = new System.Drawing.Point(65, 81);
            this.calibBlue.Maximum = 255;
            this.calibBlue.Minimum = 0;
            this.calibBlue.MouseWheelBarPartitions = 10;
            this.calibBlue.Name = "calibBlue";
            this.calibBlue.Size = new System.Drawing.Size(410, 23);
            this.calibBlue.SmallChange = ((uint)(1u));
            this.calibBlue.Style = MetroFramework.MetroColorStyle.Blue;
            this.calibBlue.StyleManager = this.metroStyleManager;
            this.calibBlue.TabIndex = 5;
            this.calibBlue.Text = "metroTrackBar3";
            this.calibBlue.Theme = MetroFramework.MetroThemeStyle.Light;
            this.calibBlue.Value = 0;
            this.calibBlue.ValueChanged += new System.EventHandler(this.calibRed_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(22, 83);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = this.metroStyleManager;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Blue:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // calibGreen
            // 
            this.calibGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibGreen.BackColor = System.Drawing.Color.Transparent;
            this.calibGreen.CustomBackground = false;
            this.calibGreen.LargeChange = ((uint)(5u));
            this.calibGreen.Location = new System.Drawing.Point(65, 52);
            this.calibGreen.Maximum = 255;
            this.calibGreen.Minimum = 0;
            this.calibGreen.MouseWheelBarPartitions = 10;
            this.calibGreen.Name = "calibGreen";
            this.calibGreen.Size = new System.Drawing.Size(410, 23);
            this.calibGreen.SmallChange = ((uint)(1u));
            this.calibGreen.Style = MetroFramework.MetroColorStyle.Blue;
            this.calibGreen.StyleManager = this.metroStyleManager;
            this.calibGreen.TabIndex = 3;
            this.calibGreen.Text = "metroTrackBar2";
            this.calibGreen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.calibGreen.Value = 0;
            this.calibGreen.ValueChanged += new System.EventHandler(this.calibRed_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(12, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = this.metroStyleManager;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Green:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // calibRed
            // 
            this.calibRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibRed.BackColor = System.Drawing.Color.Transparent;
            this.calibRed.CustomBackground = false;
            this.calibRed.LargeChange = ((uint)(5u));
            this.calibRed.Location = new System.Drawing.Point(65, 23);
            this.calibRed.Maximum = 255;
            this.calibRed.Minimum = 0;
            this.calibRed.MouseWheelBarPartitions = 10;
            this.calibRed.Name = "calibRed";
            this.calibRed.Size = new System.Drawing.Size(410, 23);
            this.calibRed.SmallChange = ((uint)(1u));
            this.calibRed.Style = MetroFramework.MetroColorStyle.Blue;
            this.calibRed.StyleManager = this.metroStyleManager;
            this.calibRed.TabIndex = 1;
            this.calibRed.Text = "metroTrackBar1";
            this.calibRed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.calibRed.Value = 0;
            this.calibRed.ValueChanged += new System.EventHandler(this.calibRed_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(24, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = this.metroStyleManager;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Red:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbBilinearGrid);
            this.groupBox1.Controls.Add(this.cbBottomLeft);
            this.groupBox1.Controls.Add(this.cbBottomRight);
            this.groupBox1.Controls.Add(this.cbTopRight);
            this.groupBox1.Controls.Add(this.cbTopLeft);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(23, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 296);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2D color setup";
            // 
            // cbTopLeft
            // 
            this.cbTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbTopLeft.Location = new System.Drawing.Point(121, 23);
            this.cbTopLeft.Name = "cbTopLeft";
            this.cbTopLeft.Size = new System.Drawing.Size(30, 30);
            this.cbTopLeft.TabIndex = 1;
            this.cbTopLeft.TabStop = false;
            this.cbTopLeft.BackColorChanged += new System.EventHandler(this.cbTopLeft_BackColorChanged);
            this.cbTopLeft.DoubleClick += new System.EventHandler(this.cbTopRight_DoubleClick);
            // 
            // cbTopRight
            // 
            this.cbTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbTopRight.Location = new System.Drawing.Point(349, 23);
            this.cbTopRight.Name = "cbTopRight";
            this.cbTopRight.Size = new System.Drawing.Size(30, 30);
            this.cbTopRight.TabIndex = 2;
            this.cbTopRight.TabStop = false;
            this.cbTopRight.BackColorChanged += new System.EventHandler(this.cbTopLeft_BackColorChanged);
            this.cbTopRight.DoubleClick += new System.EventHandler(this.cbTopRight_DoubleClick);
            // 
            // cbBottomRight
            // 
            this.cbBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbBottomRight.Location = new System.Drawing.Point(349, 251);
            this.cbBottomRight.Name = "cbBottomRight";
            this.cbBottomRight.Size = new System.Drawing.Size(30, 30);
            this.cbBottomRight.TabIndex = 3;
            this.cbBottomRight.TabStop = false;
            this.cbBottomRight.BackColorChanged += new System.EventHandler(this.cbTopLeft_BackColorChanged);
            this.cbBottomRight.DoubleClick += new System.EventHandler(this.cbTopRight_DoubleClick);
            // 
            // cbBottomLeft
            // 
            this.cbBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbBottomLeft.Location = new System.Drawing.Point(121, 251);
            this.cbBottomLeft.Name = "cbBottomLeft";
            this.cbBottomLeft.Size = new System.Drawing.Size(30, 30);
            this.cbBottomLeft.TabIndex = 4;
            this.cbBottomLeft.TabStop = false;
            this.cbBottomLeft.BackColorChanged += new System.EventHandler(this.cbTopLeft_BackColorChanged);
            this.cbBottomLeft.DoubleClick += new System.EventHandler(this.cbTopRight_DoubleClick);
            // 
            // pbBilinearGrid
            // 
            this.pbBilinearGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBilinearGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBilinearGrid.Controls.Add(this.panelUVPointer);
            this.pbBilinearGrid.Location = new System.Drawing.Point(150, 52);
            this.pbBilinearGrid.Name = "pbBilinearGrid";
            this.pbBilinearGrid.Size = new System.Drawing.Size(200, 200);
            this.pbBilinearGrid.TabIndex = 5;
            // 
            // panelUVPointer
            // 
            this.panelUVPointer.BackColor = System.Drawing.Color.White;
            this.panelUVPointer.Location = new System.Drawing.Point(64, 106);
            this.panelUVPointer.Name = "panelUVPointer";
            this.panelUVPointer.Size = new System.Drawing.Size(3, 3);
            this.panelUVPointer.TabIndex = 0;
            // 
            // bilinearUVTimer
            // 
            this.bilinearUVTimer.Interval = 16;
            this.bilinearUVTimer.Tick += new System.EventHandler(this.bilinearUVTimer_Tick);
            // 
            // RGBSetupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RGBSetupForm";
            this.StyleManager = this.metroStyleManager;
            this.Text = "RGB LED driver setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RGBSetupForm_FormClosing);
            this.Load += new System.EventHandler(this.RGBSetupForm_Load);
            this.ResizeEnd += new System.EventHandler(this.RGBSetupForm_ResizeEnd);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBottomLeft)).EndInit();
            this.pbBilinearGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTrackBar calibBlue;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar calibGreen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTrackBar calibRed;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblCalibTip;
        private MetroFramework.Controls.MetroButton btnCalibration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox cbBottomLeft;
        private System.Windows.Forms.PictureBox cbBottomRight;
        private System.Windows.Forms.PictureBox cbTopRight;
        private System.Windows.Forms.PictureBox cbTopLeft;
        private System.Windows.Forms.Panel pbBilinearGrid;
        private System.Windows.Forms.Panel panelUVPointer;
        private System.Windows.Forms.Timer bilinearUVTimer;
    }
}