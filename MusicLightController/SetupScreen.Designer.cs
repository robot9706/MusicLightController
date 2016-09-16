namespace MusicLightController
{
    partial class SetupScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbComs = new System.Windows.Forms.ComboBox();
            this.btnCOMrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cpr = new System.Windows.Forms.Label();
            this.btnSaveCOM = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblSerialStatusText = new System.Windows.Forms.Label();
            this.lblSerialStatus = new System.Windows.Forms.Label();
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBright = new System.Windows.Forms.TrackBar();
            this.trackBSlope = new System.Windows.Forms.TrackBar();
            this.trackMidSlope = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblBSlope = new System.Windows.Forms.Label();
            this.lblMSlope = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.cbOutput = new System.Windows.Forms.ComboBox();
            this.cbOutputMode = new System.Windows.Forms.ComboBox();
            this.cbInToOut = new System.Windows.Forms.CheckBox();
            this.lblSamples = new System.Windows.Forms.Label();
            this.trackSamples = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.pbVis = new System.Windows.Forms.PictureBox();
            this.cbVis = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMidSlope)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSerialStatus);
            this.groupBox1.Controls.Add(this.lblSerialStatusText);
            this.groupBox1.Controls.Add(this.btnSaveCOM);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCOMrefresh);
            this.groupBox1.Controls.Add(this.cbComs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communcation settings";
            // 
            // cbComs
            // 
            this.cbComs.FormattingEnabled = true;
            this.cbComs.Location = new System.Drawing.Point(100, 32);
            this.cbComs.Name = "cbComs";
            this.cbComs.Size = new System.Drawing.Size(241, 26);
            this.cbComs.TabIndex = 0;
            // 
            // btnCOMrefresh
            // 
            this.btnCOMrefresh.Location = new System.Drawing.Point(100, 64);
            this.btnCOMrefresh.Name = "btnCOMrefresh";
            this.btnCOMrefresh.Size = new System.Drawing.Size(109, 30);
            this.btnCOMrefresh.TabIndex = 1;
            this.btnCOMrefresh.Text = "Refresh list";
            this.btnCOMrefresh.UseVisualStyleBackColor = true;
            this.btnCOMrefresh.Click += new System.EventHandler(this.btnCOMrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate:";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.cbBaud.Location = new System.Drawing.Point(100, 109);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(241, 26);
            this.cbBaud.TabIndex = 4;
            // 
            // cpr
            // 
            this.cpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpr.AutoSize = true;
            this.cpr.Location = new System.Drawing.Point(732, 462);
            this.cpr.Name = "cpr";
            this.cpr.Size = new System.Drawing.Size(130, 18);
            this.cpr.TabIndex = 1;
            this.cpr.Text = "robot9706 @ 2016";
            // 
            // btnSaveCOM
            // 
            this.btnSaveCOM.Location = new System.Drawing.Point(202, 174);
            this.btnSaveCOM.Name = "btnSaveCOM";
            this.btnSaveCOM.Size = new System.Drawing.Size(139, 30);
            this.btnSaveCOM.TabIndex = 5;
            this.btnSaveCOM.Text = "Save and apply";
            this.btnSaveCOM.UseVisualStyleBackColor = true;
            this.btnSaveCOM.Click += new System.EventHandler(this.btnSaveCOM_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LED music controller";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // lblSerialStatusText
            // 
            this.lblSerialStatusText.AutoSize = true;
            this.lblSerialStatusText.Location = new System.Drawing.Point(40, 144);
            this.lblSerialStatusText.Name = "lblSerialStatusText";
            this.lblSerialStatusText.Size = new System.Drawing.Size(54, 18);
            this.lblSerialStatusText.TabIndex = 6;
            this.lblSerialStatusText.Text = "Status:";
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.Location = new System.Drawing.Point(100, 144);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(84, 18);
            this.lblSerialStatus.TabIndex = 7;
            this.lblSerialStatus.Text = "Port closed";
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(117, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSamples);
            this.groupBox2.Controls.Add(this.trackSamples);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblMSlope);
            this.groupBox2.Controls.Add(this.lblBSlope);
            this.groupBox2.Controls.Add(this.lblBrightness);
            this.groupBox2.Controls.Add(this.trackMidSlope);
            this.groupBox2.Controls.Add(this.trackBSlope);
            this.groupBox2.Controls.Add(this.trackBright);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brightness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bass slope value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mid slope value:";
            // 
            // trackBright
            // 
            this.trackBright.Location = new System.Drawing.Point(142, 32);
            this.trackBright.Maximum = 1000;
            this.trackBright.Name = "trackBright";
            this.trackBright.Size = new System.Drawing.Size(240, 45);
            this.trackBright.TabIndex = 3;
            this.trackBright.TickFrequency = 50;
            this.trackBright.Scroll += new System.EventHandler(this.trackBright_Scroll);
            // 
            // trackBSlope
            // 
            this.trackBSlope.Location = new System.Drawing.Point(142, 80);
            this.trackBSlope.Maximum = 1000;
            this.trackBSlope.Name = "trackBSlope";
            this.trackBSlope.Size = new System.Drawing.Size(240, 45);
            this.trackBSlope.TabIndex = 4;
            this.trackBSlope.TickFrequency = 50;
            this.trackBSlope.Scroll += new System.EventHandler(this.trackBSlope_Scroll);
            // 
            // trackMidSlope
            // 
            this.trackMidSlope.Location = new System.Drawing.Point(142, 126);
            this.trackMidSlope.Maximum = 1000;
            this.trackMidSlope.Name = "trackMidSlope";
            this.trackMidSlope.Size = new System.Drawing.Size(240, 45);
            this.trackMidSlope.TabIndex = 5;
            this.trackMidSlope.TickFrequency = 50;
            this.trackMidSlope.Scroll += new System.EventHandler(this.trackMidSlope_Scroll);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(388, 35);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(45, 18);
            this.lblBrightness.TabIndex = 6;
            this.lblBrightness.Text = "100%";
            // 
            // lblBSlope
            // 
            this.lblBSlope.AutoSize = true;
            this.lblBSlope.Location = new System.Drawing.Point(388, 80);
            this.lblBSlope.Name = "lblBSlope";
            this.lblBSlope.Size = new System.Drawing.Size(36, 18);
            this.lblBSlope.TabIndex = 7;
            this.lblBSlope.Text = "0.74";
            // 
            // lblMSlope
            // 
            this.lblMSlope.AutoSize = true;
            this.lblMSlope.Location = new System.Drawing.Point(388, 126);
            this.lblMSlope.Name = "lblMSlope";
            this.lblMSlope.Size = new System.Drawing.Size(36, 18);
            this.lblMSlope.TabIndex = 8;
            this.lblMSlope.Text = "0.74";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbVis);
            this.groupBox3.Controls.Add(this.pbVis);
            this.groupBox3.Controls.Add(this.cbInToOut);
            this.groupBox3.Controls.Add(this.cbOutputMode);
            this.groupBox3.Controls.Add(this.cbOutput);
            this.groupBox3.Controls.Add(this.cbInput);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 216);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound processor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Input:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Output:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output mode:";
            // 
            // cbInput
            // 
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Location = new System.Drawing.Point(121, 30);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(241, 26);
            this.cbInput.TabIndex = 8;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            // 
            // cbOutput
            // 
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.Location = new System.Drawing.Point(121, 63);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(241, 26);
            this.cbOutput.TabIndex = 9;
            this.cbOutput.SelectedIndexChanged += new System.EventHandler(this.cbOutput_SelectedIndexChanged);
            // 
            // cbOutputMode
            // 
            this.cbOutputMode.FormattingEnabled = true;
            this.cbOutputMode.Items.AddRange(new object[] {
            "DirectSound",
            "Windows Multimedia WaveOut",
            "ASIO"});
            this.cbOutputMode.Location = new System.Drawing.Point(121, 95);
            this.cbOutputMode.Name = "cbOutputMode";
            this.cbOutputMode.Size = new System.Drawing.Size(241, 26);
            this.cbOutputMode.TabIndex = 10;
            this.cbOutputMode.SelectedIndexChanged += new System.EventHandler(this.cbOutputMode_SelectedIndexChanged);
            // 
            // cbInToOut
            // 
            this.cbInToOut.AutoSize = true;
            this.cbInToOut.Location = new System.Drawing.Point(121, 136);
            this.cbInToOut.Name = "cbInToOut";
            this.cbInToOut.Size = new System.Drawing.Size(164, 22);
            this.cbInToOut.TabIndex = 11;
            this.cbInToOut.Text = "Mirror input to output";
            this.cbInToOut.UseVisualStyleBackColor = true;
            this.cbInToOut.CheckedChanged += new System.EventHandler(this.cbInToOut_CheckedChanged);
            // 
            // lblSamples
            // 
            this.lblSamples.AutoSize = true;
            this.lblSamples.Location = new System.Drawing.Point(388, 169);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(24, 18);
            this.lblSamples.TabIndex = 11;
            this.lblSamples.Text = "30";
            // 
            // trackSamples
            // 
            this.trackSamples.Location = new System.Drawing.Point(142, 169);
            this.trackSamples.Maximum = 100;
            this.trackSamples.Minimum = 1;
            this.trackSamples.Name = "trackSamples";
            this.trackSamples.Size = new System.Drawing.Size(240, 45);
            this.trackSamples.TabIndex = 10;
            this.trackSamples.TickFrequency = 50;
            this.trackSamples.Value = 1;
            this.trackSamples.Scroll += new System.EventHandler(this.trackSamples_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Samples (/s):";
            // 
            // pbVis
            // 
            this.pbVis.BackColor = System.Drawing.Color.White;
            this.pbVis.Location = new System.Drawing.Point(374, 30);
            this.pbVis.Name = "pbVis";
            this.pbVis.Size = new System.Drawing.Size(467, 152);
            this.pbVis.TabIndex = 12;
            this.pbVis.TabStop = false;
            // 
            // cbVis
            // 
            this.cbVis.AutoSize = true;
            this.cbVis.Location = new System.Drawing.Point(374, 188);
            this.cbVis.Name = "cbVis";
            this.cbVis.Size = new System.Drawing.Size(117, 22);
            this.cbVis.TabIndex = 13;
            this.cbVis.Text = "Visualize data";
            this.cbVis.UseVisualStyleBackColor = true;
            this.cbVis.CheckedChanged += new System.EventHandler(this.cbVis_CheckedChanged);
            // 
            // StupScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(868, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cpr);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StupScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controller setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StupScreen_FormClosing);
            this.Load += new System.EventHandler(this.StupScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMidSlope)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCOMrefresh;
        private System.Windows.Forms.ComboBox cbComs;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpr;
        private System.Windows.Forms.Button btnSaveCOM;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblSerialStatus;
        private System.Windows.Forms.Label lblSerialStatusText;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackMidSlope;
        private System.Windows.Forms.TrackBar trackBSlope;
        private System.Windows.Forms.TrackBar trackBright;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMSlope;
        private System.Windows.Forms.Label lblBSlope;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbInToOut;
        private System.Windows.Forms.ComboBox cbOutputMode;
        private System.Windows.Forms.ComboBox cbOutput;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.TrackBar trackSamples;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbVis;
        private System.Windows.Forms.PictureBox pbVis;
    }
}

