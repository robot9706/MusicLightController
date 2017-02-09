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
            this.lblSerialStatus = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            this.lblSerialStatusText = new MetroFramework.Controls.MetroLabel();
            this.btnSaveCOM = new MetroFramework.Controls.MetroButton();
            this.cbBaud = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.btnCOMrefresh = new MetroFramework.Controls.MetroButton();
            this.cbComs = new MetroFramework.Controls.MetroComboBox();
            this.cpr = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMidVol = new MetroFramework.Controls.MetroLabel();
            this.lblBassVol = new MetroFramework.Controls.MetroLabel();
            this.trackMidVol = new MetroFramework.Controls.MetroTrackBar();
            this.trackBassVol = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.trackSamples = new MetroFramework.Controls.MetroTrackBar();
            this.trackMidSlope = new MetroFramework.Controls.MetroTrackBar();
            this.trackBassSlope = new MetroFramework.Controls.MetroTrackBar();
            this.trackBrigtness = new MetroFramework.Controls.MetroTrackBar();
            this.lblSamples = new MetroFramework.Controls.MetroLabel();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.lblMSlope = new MetroFramework.Controls.MetroLabel();
            this.lblBSlope = new MetroFramework.Controls.MetroLabel();
            this.lblBrightness = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbInToOut = new MetroFramework.Controls.MetroToggle();
            this.cbOutputMode = new MetroFramework.Controls.MetroComboBox();
            this.cbOutput = new MetroFramework.Controls.MetroComboBox();
            this.cbInput = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMetroColor = new MetroFramework.Controls.MetroComboBox();
            this.cbMetroStyle = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication settings";
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.CustomBackground = false;
            this.lblSerialStatus.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSerialStatus.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSerialStatus.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSerialStatus.Location = new System.Drawing.Point(100, 144);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(75, 19);
            this.lblSerialStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSerialStatus.StyleManager = this.metroStyleManager;
            this.lblSerialStatus.TabIndex = 7;
            this.lblSerialStatus.Text = "Port closed";
            this.lblSerialStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSerialStatus.UseStyleColors = false;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblSerialStatusText
            // 
            this.lblSerialStatusText.AutoSize = true;
            this.lblSerialStatusText.CustomBackground = false;
            this.lblSerialStatusText.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSerialStatusText.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSerialStatusText.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSerialStatusText.Location = new System.Drawing.Point(40, 144);
            this.lblSerialStatusText.Name = "lblSerialStatusText";
            this.lblSerialStatusText.Size = new System.Drawing.Size(46, 19);
            this.lblSerialStatusText.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSerialStatusText.StyleManager = this.metroStyleManager;
            this.lblSerialStatusText.TabIndex = 6;
            this.lblSerialStatusText.Text = "Status:";
            this.lblSerialStatusText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSerialStatusText.UseStyleColors = false;
            // 
            // btnSaveCOM
            // 
            this.btnSaveCOM.Highlight = false;
            this.btnSaveCOM.Location = new System.Drawing.Point(202, 174);
            this.btnSaveCOM.Name = "btnSaveCOM";
            this.btnSaveCOM.Size = new System.Drawing.Size(139, 30);
            this.btnSaveCOM.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSaveCOM.StyleManager = this.metroStyleManager;
            this.btnSaveCOM.TabIndex = 5;
            this.btnSaveCOM.Text = "Save and apply";
            this.btnSaveCOM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSaveCOM.Click += new System.EventHandler(this.btnSaveCOM_Click);
            // 
            // cbBaud
            // 
            this.cbBaud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbBaud.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.ItemHeight = 23;
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
            this.cbBaud.Size = new System.Drawing.Size(241, 29);
            this.cbBaud.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbBaud.StyleManager = this.metroStyleManager;
            this.cbBaud.TabIndex = 4;
            this.cbBaud.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CustomBackground = false;
            this.label2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.Style = MetroFramework.MetroColorStyle.Blue;
            this.label2.StyleManager = this.metroStyleManager;
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate:";
            this.label2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label2.UseStyleColors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CustomBackground = false;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.Style = MetroFramework.MetroColorStyle.Blue;
            this.label1.StyleManager = this.metroStyleManager;
            this.label1.TabIndex = 2;
            this.label1.Text = "COM port:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label1.UseStyleColors = false;
            // 
            // btnCOMrefresh
            // 
            this.btnCOMrefresh.Highlight = false;
            this.btnCOMrefresh.Location = new System.Drawing.Point(100, 64);
            this.btnCOMrefresh.Name = "btnCOMrefresh";
            this.btnCOMrefresh.Size = new System.Drawing.Size(109, 30);
            this.btnCOMrefresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCOMrefresh.StyleManager = this.metroStyleManager;
            this.btnCOMrefresh.TabIndex = 1;
            this.btnCOMrefresh.Text = "Refresh list";
            this.btnCOMrefresh.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCOMrefresh.Click += new System.EventHandler(this.btnCOMrefresh_Click);
            // 
            // cbComs
            // 
            this.cbComs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbComs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComs.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbComs.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbComs.FormattingEnabled = true;
            this.cbComs.ItemHeight = 23;
            this.cbComs.Location = new System.Drawing.Point(100, 32);
            this.cbComs.Name = "cbComs";
            this.cbComs.Size = new System.Drawing.Size(241, 29);
            this.cbComs.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComs.StyleManager = this.metroStyleManager;
            this.cbComs.TabIndex = 0;
            this.cbComs.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cpr
            // 
            this.cpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpr.AutoSize = true;
            this.cpr.CustomBackground = false;
            this.cpr.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.cpr.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.cpr.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.cpr.Location = new System.Drawing.Point(719, 456);
            this.cpr.Name = "cpr";
            this.cpr.Size = new System.Drawing.Size(117, 19);
            this.cpr.Style = MetroFramework.MetroColorStyle.Blue;
            this.cpr.StyleManager = this.metroStyleManager;
            this.cpr.TabIndex = 1;
            this.cpr.Text = "robot9706 @ 2016";
            this.cpr.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cpr.UseStyleColors = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LED music controller";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMidVol);
            this.groupBox2.Controls.Add(this.lblBassVol);
            this.groupBox2.Controls.Add(this.trackMidVol);
            this.groupBox2.Controls.Add(this.trackBassVol);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.trackSamples);
            this.groupBox2.Controls.Add(this.trackMidSlope);
            this.groupBox2.Controls.Add(this.trackBassSlope);
            this.groupBox2.Controls.Add(this.trackBrigtness);
            this.groupBox2.Controls.Add(this.lblSamples);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblMSlope);
            this.groupBox2.Controls.Add(this.lblBSlope);
            this.groupBox2.Controls.Add(this.lblBrightness);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(397, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED settings";
            // 
            // lblMidVol
            // 
            this.lblMidVol.AutoSize = true;
            this.lblMidVol.CustomBackground = false;
            this.lblMidVol.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblMidVol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblMidVol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblMidVol.Location = new System.Drawing.Point(386, 182);
            this.lblMidVol.Name = "lblMidVol";
            this.lblMidVol.Size = new System.Drawing.Size(24, 19);
            this.lblMidVol.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMidVol.StyleManager = this.metroStyleManager;
            this.lblMidVol.TabIndex = 21;
            this.lblMidVol.Text = "1.0";
            this.lblMidVol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMidVol.UseStyleColors = false;
            // 
            // lblBassVol
            // 
            this.lblBassVol.AutoSize = true;
            this.lblBassVol.CustomBackground = false;
            this.lblBassVol.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBassVol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBassVol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBassVol.Location = new System.Drawing.Point(386, 151);
            this.lblBassVol.Name = "lblBassVol";
            this.lblBassVol.Size = new System.Drawing.Size(24, 19);
            this.lblBassVol.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBassVol.StyleManager = this.metroStyleManager;
            this.lblBassVol.TabIndex = 20;
            this.lblBassVol.Text = "1.0";
            this.lblBassVol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBassVol.UseStyleColors = false;
            // 
            // trackMidVol
            // 
            this.trackMidVol.BackColor = System.Drawing.Color.Transparent;
            this.trackMidVol.CustomBackground = false;
            this.trackMidVol.LargeChange = ((uint)(5u));
            this.trackMidVol.Location = new System.Drawing.Point(129, 180);
            this.trackMidVol.Maximum = 200;
            this.trackMidVol.Minimum = 1;
            this.trackMidVol.MouseWheelBarPartitions = 10;
            this.trackMidVol.Name = "trackMidVol";
            this.trackMidVol.Size = new System.Drawing.Size(251, 23);
            this.trackMidVol.SmallChange = ((uint)(1u));
            this.trackMidVol.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackMidVol.StyleManager = this.metroStyleManager;
            this.trackMidVol.TabIndex = 19;
            this.trackMidVol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackMidVol.Value = 100;
            this.trackMidVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackMidVol_Scroll);
            // 
            // trackBassVol
            // 
            this.trackBassVol.BackColor = System.Drawing.Color.Transparent;
            this.trackBassVol.CustomBackground = false;
            this.trackBassVol.LargeChange = ((uint)(5u));
            this.trackBassVol.Location = new System.Drawing.Point(129, 149);
            this.trackBassVol.Maximum = 200;
            this.trackBassVol.Minimum = 1;
            this.trackBassVol.MouseWheelBarPartitions = 10;
            this.trackBassVol.Name = "trackBassVol";
            this.trackBassVol.Size = new System.Drawing.Size(251, 23);
            this.trackBassVol.SmallChange = ((uint)(1u));
            this.trackBassVol.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackBassVol.StyleManager = this.metroStyleManager;
            this.trackBassVol.TabIndex = 18;
            this.trackBassVol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackBassVol.Value = 100;
            this.trackBassVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBassVol_Scroll);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(41, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = this.metroStyleManager;
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Mid volume:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(39, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = this.metroStyleManager;
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Bass volume:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // trackSamples
            // 
            this.trackSamples.BackColor = System.Drawing.Color.Transparent;
            this.trackSamples.CustomBackground = false;
            this.trackSamples.LargeChange = ((uint)(5u));
            this.trackSamples.Location = new System.Drawing.Point(129, 118);
            this.trackSamples.Maximum = 100;
            this.trackSamples.Minimum = 0;
            this.trackSamples.MouseWheelBarPartitions = 10;
            this.trackSamples.Name = "trackSamples";
            this.trackSamples.Size = new System.Drawing.Size(251, 23);
            this.trackSamples.SmallChange = ((uint)(1u));
            this.trackSamples.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackSamples.StyleManager = this.metroStyleManager;
            this.trackSamples.TabIndex = 15;
            this.trackSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackSamples.Value = 30;
            this.trackSamples.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackSamples_Scroll);
            // 
            // trackMidSlope
            // 
            this.trackMidSlope.BackColor = System.Drawing.Color.Transparent;
            this.trackMidSlope.CustomBackground = false;
            this.trackMidSlope.LargeChange = ((uint)(5u));
            this.trackMidSlope.Location = new System.Drawing.Point(129, 87);
            this.trackMidSlope.Maximum = 1000;
            this.trackMidSlope.Minimum = 0;
            this.trackMidSlope.MouseWheelBarPartitions = 10;
            this.trackMidSlope.Name = "trackMidSlope";
            this.trackMidSlope.Size = new System.Drawing.Size(251, 23);
            this.trackMidSlope.SmallChange = ((uint)(1u));
            this.trackMidSlope.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackMidSlope.StyleManager = this.metroStyleManager;
            this.trackMidSlope.TabIndex = 14;
            this.trackMidSlope.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackMidSlope.Value = 50;
            this.trackMidSlope.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackMidSlope_Scroll);
            // 
            // trackBassSlope
            // 
            this.trackBassSlope.BackColor = System.Drawing.Color.Transparent;
            this.trackBassSlope.CustomBackground = false;
            this.trackBassSlope.LargeChange = ((uint)(5u));
            this.trackBassSlope.Location = new System.Drawing.Point(129, 56);
            this.trackBassSlope.Maximum = 1000;
            this.trackBassSlope.Minimum = 0;
            this.trackBassSlope.MouseWheelBarPartitions = 10;
            this.trackBassSlope.Name = "trackBassSlope";
            this.trackBassSlope.Size = new System.Drawing.Size(251, 23);
            this.trackBassSlope.SmallChange = ((uint)(1u));
            this.trackBassSlope.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackBassSlope.StyleManager = this.metroStyleManager;
            this.trackBassSlope.TabIndex = 13;
            this.trackBassSlope.Text = "metroTrackBar2";
            this.trackBassSlope.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackBassSlope.Value = 50;
            this.trackBassSlope.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBassSlope_Scroll);
            // 
            // trackBrigtness
            // 
            this.trackBrigtness.BackColor = System.Drawing.Color.Transparent;
            this.trackBrigtness.CustomBackground = false;
            this.trackBrigtness.LargeChange = ((uint)(5u));
            this.trackBrigtness.Location = new System.Drawing.Point(129, 25);
            this.trackBrigtness.Maximum = 100;
            this.trackBrigtness.Minimum = 0;
            this.trackBrigtness.MouseWheelBarPartitions = 10;
            this.trackBrigtness.Name = "trackBrigtness";
            this.trackBrigtness.Size = new System.Drawing.Size(251, 23);
            this.trackBrigtness.SmallChange = ((uint)(1u));
            this.trackBrigtness.Style = MetroFramework.MetroColorStyle.Blue;
            this.trackBrigtness.StyleManager = this.metroStyleManager;
            this.trackBrigtness.TabIndex = 12;
            this.trackBrigtness.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackBrigtness.Value = 100;
            // 
            // lblSamples
            // 
            this.lblSamples.AutoSize = true;
            this.lblSamples.CustomBackground = false;
            this.lblSamples.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSamples.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSamples.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSamples.Location = new System.Drawing.Point(386, 120);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(23, 19);
            this.lblSamples.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSamples.StyleManager = this.metroStyleManager;
            this.lblSamples.TabIndex = 11;
            this.lblSamples.Text = "30";
            this.lblSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSamples.UseStyleColors = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CustomBackground = false;
            this.label10.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label10.Location = new System.Drawing.Point(40, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.Style = MetroFramework.MetroColorStyle.Blue;
            this.label10.StyleManager = this.metroStyleManager;
            this.label10.TabIndex = 9;
            this.label10.Text = "Samples (/s):";
            this.label10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label10.UseStyleColors = false;
            // 
            // lblMSlope
            // 
            this.lblMSlope.AutoSize = true;
            this.lblMSlope.CustomBackground = false;
            this.lblMSlope.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblMSlope.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblMSlope.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblMSlope.Location = new System.Drawing.Point(386, 89);
            this.lblMSlope.Name = "lblMSlope";
            this.lblMSlope.Size = new System.Drawing.Size(33, 19);
            this.lblMSlope.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMSlope.StyleManager = this.metroStyleManager;
            this.lblMSlope.TabIndex = 8;
            this.lblMSlope.Text = "0.74";
            this.lblMSlope.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMSlope.UseStyleColors = false;
            // 
            // lblBSlope
            // 
            this.lblBSlope.AutoSize = true;
            this.lblBSlope.CustomBackground = false;
            this.lblBSlope.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBSlope.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBSlope.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBSlope.Location = new System.Drawing.Point(386, 58);
            this.lblBSlope.Name = "lblBSlope";
            this.lblBSlope.Size = new System.Drawing.Size(33, 19);
            this.lblBSlope.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBSlope.StyleManager = this.metroStyleManager;
            this.lblBSlope.TabIndex = 7;
            this.lblBSlope.Text = "0.74";
            this.lblBSlope.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBSlope.UseStyleColors = false;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.CustomBackground = false;
            this.lblBrightness.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBrightness.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBrightness.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBrightness.Location = new System.Drawing.Point(386, 27);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(39, 19);
            this.lblBrightness.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBrightness.StyleManager = this.metroStyleManager;
            this.lblBrightness.TabIndex = 6;
            this.lblBrightness.Text = "100%";
            this.lblBrightness.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBrightness.UseStyleColors = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CustomBackground = false;
            this.label5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.Style = MetroFramework.MetroColorStyle.Blue;
            this.label5.StyleManager = this.metroStyleManager;
            this.label5.TabIndex = 2;
            this.label5.Text = "Mid slope value:";
            this.label5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label5.UseStyleColors = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CustomBackground = false;
            this.label4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label4.Location = new System.Drawing.Point(17, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.Style = MetroFramework.MetroColorStyle.Blue;
            this.label4.StyleManager = this.metroStyleManager;
            this.label4.TabIndex = 1;
            this.label4.Text = "Bass slope value:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label4.UseStyleColors = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CustomBackground = false;
            this.label3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.Style = MetroFramework.MetroColorStyle.Blue;
            this.label3.StyleManager = this.metroStyleManager;
            this.label3.TabIndex = 0;
            this.label3.Text = "Brightness:";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label3.UseStyleColors = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.cbInToOut);
            this.groupBox3.Controls.Add(this.cbOutputMode);
            this.groupBox3.Controls.Add(this.cbOutput);
            this.groupBox3.Controls.Add(this.cbInput);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(23, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 174);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound processor";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(207, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = this.metroStyleManager;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Send input to output";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // cbInToOut
            // 
            this.cbInToOut.AutoSize = true;
            this.cbInToOut.CustomBackground = false;
            this.cbInToOut.DisplayStatus = true;
            this.cbInToOut.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cbInToOut.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbInToOut.Location = new System.Drawing.Point(121, 130);
            this.cbInToOut.Name = "cbInToOut";
            this.cbInToOut.Size = new System.Drawing.Size(80, 22);
            this.cbInToOut.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbInToOut.StyleManager = this.metroStyleManager;
            this.cbInToOut.TabIndex = 11;
            this.cbInToOut.Text = "Off";
            this.cbInToOut.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbInToOut.UseStyleColors = false;
            this.cbInToOut.UseVisualStyleBackColor = true;
            this.cbInToOut.CheckedChanged += new System.EventHandler(this.cbInToOut_CheckedChanged);
            // 
            // cbOutputMode
            // 
            this.cbOutputMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOutputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputMode.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbOutputMode.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbOutputMode.FormattingEnabled = true;
            this.cbOutputMode.ItemHeight = 23;
            this.cbOutputMode.Items.AddRange(new object[] {
            "DirectSound",
            "Windows Multimedia WaveOut",
            "ASIO"});
            this.cbOutputMode.Location = new System.Drawing.Point(121, 95);
            this.cbOutputMode.Name = "cbOutputMode";
            this.cbOutputMode.Size = new System.Drawing.Size(241, 29);
            this.cbOutputMode.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbOutputMode.StyleManager = this.metroStyleManager;
            this.cbOutputMode.TabIndex = 10;
            this.cbOutputMode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbOutputMode.SelectedIndexChanged += new System.EventHandler(this.cbOutputMode_SelectedIndexChanged);
            // 
            // cbOutput
            // 
            this.cbOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutput.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbOutput.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.ItemHeight = 23;
            this.cbOutput.Location = new System.Drawing.Point(121, 63);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(241, 29);
            this.cbOutput.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbOutput.StyleManager = this.metroStyleManager;
            this.cbOutput.TabIndex = 9;
            this.cbOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbOutput.SelectedIndexChanged += new System.EventHandler(this.cbOutput_SelectedIndexChanged);
            // 
            // cbInput
            // 
            this.cbInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInput.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbInput.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbInput.FormattingEnabled = true;
            this.cbInput.ItemHeight = 23;
            this.cbInput.Location = new System.Drawing.Point(121, 30);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(241, 29);
            this.cbInput.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbInput.StyleManager = this.metroStyleManager;
            this.cbInput.TabIndex = 8;
            this.cbInput.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CustomBackground = false;
            this.label8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.Style = MetroFramework.MetroColorStyle.Blue;
            this.label8.StyleManager = this.metroStyleManager;
            this.label8.TabIndex = 2;
            this.label8.Text = "Output mode:";
            this.label8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label8.UseStyleColors = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CustomBackground = false;
            this.label7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label7.Location = new System.Drawing.Point(59, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.Style = MetroFramework.MetroColorStyle.Blue;
            this.label7.StyleManager = this.metroStyleManager;
            this.label7.TabIndex = 1;
            this.label7.Text = "Output:";
            this.label7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label7.UseStyleColors = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CustomBackground = false;
            this.label6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label6.Location = new System.Drawing.Point(72, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.Style = MetroFramework.MetroColorStyle.Blue;
            this.label6.StyleManager = this.metroStyleManager;
            this.label6.TabIndex = 0;
            this.label6.Text = "Input:";
            this.label6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.label6.UseStyleColors = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMetroColor);
            this.groupBox4.Controls.Add(this.cbMetroStyle);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.ForeColor = System.Drawing.Color.Silver;
            this.groupBox4.Location = new System.Drawing.Point(397, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 174);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UI";
            // 
            // cbMetroColor
            // 
            this.cbMetroColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMetroColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetroColor.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbMetroColor.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbMetroColor.FormattingEnabled = true;
            this.cbMetroColor.ItemHeight = 23;
            this.cbMetroColor.Location = new System.Drawing.Point(65, 90);
            this.cbMetroColor.Name = "cbMetroColor";
            this.cbMetroColor.Size = new System.Drawing.Size(209, 29);
            this.cbMetroColor.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbMetroColor.StyleManager = this.metroStyleManager;
            this.cbMetroColor.TabIndex = 16;
            this.cbMetroColor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbMetroColor.SelectedIndexChanged += new System.EventHandler(this.cbMetroColor_SelectedIndexChanged_1);
            // 
            // cbMetroStyle
            // 
            this.cbMetroStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMetroStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetroStyle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbMetroStyle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbMetroStyle.FormattingEnabled = true;
            this.cbMetroStyle.ItemHeight = 23;
            this.cbMetroStyle.Location = new System.Drawing.Point(65, 57);
            this.cbMetroStyle.Name = "cbMetroStyle";
            this.cbMetroStyle.Size = new System.Drawing.Size(209, 29);
            this.cbMetroStyle.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbMetroStyle.StyleManager = this.metroStyleManager;
            this.cbMetroStyle.TabIndex = 15;
            this.cbMetroStyle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbMetroStyle.SelectedIndexChanged += new System.EventHandler(this.cbMetroStyle_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(13, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = this.metroStyleManager;
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Color:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(20, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = this.metroStyleManager;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Style:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // SetupScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cpr);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SetupScreen";
            this.StyleManager = this.metroStyleManager;
            this.Text = "Controller setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StupScreen_FormClosing);
            this.Load += new System.EventHandler(this.StupScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnCOMrefresh;
        private MetroFramework.Controls.MetroComboBox cbComs;
        private MetroFramework.Controls.MetroComboBox cbBaud;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel cpr;
        private MetroFramework.Controls.MetroButton btnSaveCOM;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroLabel lblSerialStatus;
        private MetroFramework.Controls.MetroLabel lblSerialStatusText;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel lblMSlope;
        private MetroFramework.Controls.MetroLabel lblBSlope;
        private MetroFramework.Controls.MetroLabel lblBrightness;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroToggle cbInToOut;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel lblSamples;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroComboBox cbOutputMode;
        private MetroFramework.Controls.MetroComboBox cbOutput;
        private MetroFramework.Controls.MetroComboBox cbInput;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox cbMetroColor;
        private MetroFramework.Controls.MetroComboBox cbMetroStyle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar4;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar3;
        private MetroFramework.Controls.MetroTrackBar trackBassSlope;
        private MetroFramework.Controls.MetroTrackBar trackBrigtness;
        private MetroFramework.Controls.MetroTrackBar trackSamples;
        private MetroFramework.Controls.MetroTrackBar trackMidSlope;
        private MetroFramework.Controls.MetroLabel lblMidVol;
        private MetroFramework.Controls.MetroLabel lblBassVol;
        private MetroFramework.Controls.MetroTrackBar trackMidVol;
        private MetroFramework.Controls.MetroTrackBar trackBassVol;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

