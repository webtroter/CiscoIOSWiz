namespace Cisco_Config_Wiz
{
    partial class CiscoIOSWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiscoIOSWiz));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.grpCon = new System.Windows.Forms.GroupBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.chkConLogSync = new System.Windows.Forms.CheckBox();
            this.chkConLogin = new System.Windows.Forms.CheckBox();
            this.boxVTY = new System.Windows.Forms.GroupBox();
            this.txtVTYPass = new System.Windows.Forms.TextBox();
            this.chkVTYLogSync = new System.Windows.Forms.CheckBox();
            this.chkVTYLogin = new System.Windows.Forms.CheckBox();
            this.boxPassword = new System.Windows.Forms.GroupBox();
            this.txtEnPass = new System.Windows.Forms.TextBox();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.chkEnLogin = new System.Windows.Forms.CheckBox();
            this.boxGeneral = new System.Windows.Forms.GroupBox();
            this.txtMotdBanner = new System.Windows.Forms.TextBox();
            this.txtLogBanner = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.tabInterfaces = new System.Windows.Forms.TabPage();
            this.boxInterface = new System.Windows.Forms.GroupBox();
            this.ipInterfaceMask = new IPAddressControlLib.IPAddressControl();
            this.cboInterfaceUseClock = new System.Windows.Forms.ComboBox();
            this.ipInterfaceAddress = new IPAddressControlLib.IPAddressControl();
            this.numInterfaceCIDR = new System.Windows.Forms.NumericUpDown();
            this.numInterfaceClock = new System.Windows.Forms.NumericUpDown();
            this.txtInterfaceTypeNum = new System.Windows.Forms.TextBox();
            this.txtInterfaceName = new System.Windows.Forms.TextBox();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblDTEDCE = new System.Windows.Forms.Label();
            this.lblSerialClock = new System.Windows.Forms.Label();
            this.lblCIDR = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNoInterfaceWarning = new System.Windows.Forms.TextBox();
            this.cboInterfaces = new System.Windows.Forms.ComboBox();
            this.boxNewInterface = new System.Windows.Forms.GroupBox();
            this.btnnewInterfaceAdd = new System.Windows.Forms.Button();
            this.cboNewInterfaceType = new System.Windows.Forms.ComboBox();
            this.txtNewInterfaceName = new System.Windows.Forms.TextBox();
            this.txtNewInterfaceNumber = new System.Windows.Forms.TextBox();
            this.tabRouting = new System.Windows.Forms.TabPage();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errMask = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAddInterface = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.grpCon.SuspendLayout();
            this.boxVTY.SuspendLayout();
            this.boxPassword.SuspendLayout();
            this.boxGeneral.SuspendLayout();
            this.tabInterfaces.SuspendLayout();
            this.boxInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterfaceCIDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterfaceClock)).BeginInit();
            this.boxNewInterface.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAddInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabInterfaces);
            this.tabControl1.Controls.Add(this.tabRouting);
            this.tabControl1.Controls.Add(this.tabOutput);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.grpCon);
            this.tabMain.Controls.Add(this.boxVTY);
            this.tabMain.Controls.Add(this.boxPassword);
            this.tabMain.Controls.Add(this.boxGeneral);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(599, 350);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "General Configuration";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // grpCon
            // 
            this.grpCon.Controls.Add(this.txtConPass);
            this.grpCon.Controls.Add(this.chkConLogSync);
            this.grpCon.Controls.Add(this.chkConLogin);
            this.grpCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCon.Location = new System.Drawing.Point(8, 212);
            this.grpCon.Name = "grpCon";
            this.grpCon.Size = new System.Drawing.Size(192, 97);
            this.grpCon.TabIndex = 1;
            this.grpCon.TabStop = false;
            this.grpCon.Text = "Console";
            // 
            // txtConPass
            // 
            this.txtConPass.Enabled = false;
            this.txtConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.ForeColor = System.Drawing.Color.Gray;
            this.txtConPass.Location = new System.Drawing.Point(6, 71);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(180, 20);
            this.txtConPass.TabIndex = 1;
            this.txtConPass.Text = "Password";
            this.txtConPass.Enter += new System.EventHandler(this.txtConPass_Enter);
            this.txtConPass.Leave += new System.EventHandler(this.txtConPass_Leave);
            // 
            // chkConLogSync
            // 
            this.chkConLogSync.AutoSize = true;
            this.chkConLogSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConLogSync.Location = new System.Drawing.Point(6, 21);
            this.chkConLogSync.Name = "chkConLogSync";
            this.chkConLogSync.Size = new System.Drawing.Size(129, 17);
            this.chkConLogSync.TabIndex = 0;
            this.chkConLogSync.Text = "Logging Synchronous";
            this.chkConLogSync.UseVisualStyleBackColor = true;
            // 
            // chkConLogin
            // 
            this.chkConLogin.AutoSize = true;
            this.chkConLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConLogin.Location = new System.Drawing.Point(6, 47);
            this.chkConLogin.Name = "chkConLogin";
            this.chkConLogin.Size = new System.Drawing.Size(52, 17);
            this.chkConLogin.TabIndex = 0;
            this.chkConLogin.Text = "Login";
            this.chkConLogin.UseVisualStyleBackColor = true;
            this.chkConLogin.CheckedChanged += new System.EventHandler(this.chkConLogin_CheckedChanged);
            // 
            // boxVTY
            // 
            this.boxVTY.Controls.Add(this.txtVTYPass);
            this.boxVTY.Controls.Add(this.chkVTYLogSync);
            this.boxVTY.Controls.Add(this.chkVTYLogin);
            this.boxVTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxVTY.Location = new System.Drawing.Point(8, 109);
            this.boxVTY.Name = "boxVTY";
            this.boxVTY.Size = new System.Drawing.Size(192, 97);
            this.boxVTY.TabIndex = 1;
            this.boxVTY.TabStop = false;
            this.boxVTY.Text = "VTY (SSH & TelNet)";
            // 
            // txtVTYPass
            // 
            this.txtVTYPass.Enabled = false;
            this.txtVTYPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVTYPass.ForeColor = System.Drawing.Color.Gray;
            this.txtVTYPass.Location = new System.Drawing.Point(6, 71);
            this.txtVTYPass.Name = "txtVTYPass";
            this.txtVTYPass.Size = new System.Drawing.Size(180, 20);
            this.txtVTYPass.TabIndex = 1;
            this.txtVTYPass.Text = "Password";
            this.txtVTYPass.Enter += new System.EventHandler(this.txtVTYPass_Enter);
            this.txtVTYPass.Leave += new System.EventHandler(this.txtVTYPass_Leave);
            // 
            // chkVTYLogSync
            // 
            this.chkVTYLogSync.AutoSize = true;
            this.chkVTYLogSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVTYLogSync.Location = new System.Drawing.Point(6, 21);
            this.chkVTYLogSync.Name = "chkVTYLogSync";
            this.chkVTYLogSync.Size = new System.Drawing.Size(129, 17);
            this.chkVTYLogSync.TabIndex = 0;
            this.chkVTYLogSync.Text = "Logging Synchronous";
            this.chkVTYLogSync.UseVisualStyleBackColor = true;
            // 
            // chkVTYLogin
            // 
            this.chkVTYLogin.AutoSize = true;
            this.chkVTYLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVTYLogin.Location = new System.Drawing.Point(6, 47);
            this.chkVTYLogin.Name = "chkVTYLogin";
            this.chkVTYLogin.Size = new System.Drawing.Size(52, 17);
            this.chkVTYLogin.TabIndex = 0;
            this.chkVTYLogin.Text = "Login";
            this.chkVTYLogin.UseVisualStyleBackColor = true;
            this.chkVTYLogin.CheckedChanged += new System.EventHandler(this.chkVTYLogin_CheckedChanged);
            // 
            // boxPassword
            // 
            this.boxPassword.Controls.Add(this.txtEnPass);
            this.boxPassword.Controls.Add(this.chkEncrypt);
            this.boxPassword.Controls.Add(this.chkEnLogin);
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPassword.Location = new System.Drawing.Point(206, 6);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(192, 97);
            this.boxPassword.TabIndex = 0;
            this.boxPassword.TabStop = false;
            this.boxPassword.Text = "Enable Security";
            // 
            // txtEnPass
            // 
            this.txtEnPass.Enabled = false;
            this.txtEnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnPass.ForeColor = System.Drawing.Color.Gray;
            this.txtEnPass.Location = new System.Drawing.Point(6, 71);
            this.txtEnPass.Name = "txtEnPass";
            this.txtEnPass.Size = new System.Drawing.Size(180, 20);
            this.txtEnPass.TabIndex = 2;
            this.txtEnPass.Text = "Password";
            this.txtEnPass.Enter += new System.EventHandler(this.txtEnPass_Enter);
            this.txtEnPass.Leave += new System.EventHandler(this.txtEnPass_Leave);
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.AutoSize = true;
            this.chkEncrypt.Enabled = false;
            this.chkEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEncrypt.Location = new System.Drawing.Point(6, 47);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(111, 17);
            this.chkEncrypt.TabIndex = 0;
            this.chkEncrypt.Text = "Encrypt Password";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // chkEnLogin
            // 
            this.chkEnLogin.AutoSize = true;
            this.chkEnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnLogin.Location = new System.Drawing.Point(6, 21);
            this.chkEnLogin.Name = "chkEnLogin";
            this.chkEnLogin.Size = new System.Drawing.Size(52, 17);
            this.chkEnLogin.TabIndex = 0;
            this.chkEnLogin.Text = "Login";
            this.chkEnLogin.UseVisualStyleBackColor = true;
            this.chkEnLogin.CheckedChanged += new System.EventHandler(this.chkEnLogin_CheckedChanged);
            // 
            // boxGeneral
            // 
            this.boxGeneral.Controls.Add(this.txtMotdBanner);
            this.boxGeneral.Controls.Add(this.txtLogBanner);
            this.boxGeneral.Controls.Add(this.txtHostname);
            this.boxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGeneral.Location = new System.Drawing.Point(8, 6);
            this.boxGeneral.Name = "boxGeneral";
            this.boxGeneral.Size = new System.Drawing.Size(192, 97);
            this.boxGeneral.TabIndex = 0;
            this.boxGeneral.TabStop = false;
            this.boxGeneral.Text = "More General";
            // 
            // txtMotdBanner
            // 
            this.txtMotdBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotdBanner.Location = new System.Drawing.Point(6, 71);
            this.txtMotdBanner.Name = "txtMotdBanner";
            this.txtMotdBanner.Size = new System.Drawing.Size(180, 20);
            this.txtMotdBanner.TabIndex = 2;
            this.txtMotdBanner.Text = "MOTD";
            this.txtMotdBanner.Enter += new System.EventHandler(this.txtMotdBanner_Enter);
            this.txtMotdBanner.Leave += new System.EventHandler(this.txtMotdBanner_Leave);
            // 
            // txtLogBanner
            // 
            this.txtLogBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogBanner.Location = new System.Drawing.Point(6, 45);
            this.txtLogBanner.Name = "txtLogBanner";
            this.txtLogBanner.Size = new System.Drawing.Size(180, 20);
            this.txtLogBanner.TabIndex = 2;
            this.txtLogBanner.Text = "Login Banner";
            this.txtLogBanner.Enter += new System.EventHandler(this.txtLogBanner_Enter);
            this.txtLogBanner.Leave += new System.EventHandler(this.txtLogBanner_Leave);
            // 
            // txtHostname
            // 
            this.txtHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostname.Location = new System.Drawing.Point(6, 19);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(180, 20);
            this.txtHostname.TabIndex = 2;
            this.txtHostname.Text = "Hostname";
            this.txtHostname.Enter += new System.EventHandler(this.txtHostname_Enter);
            this.txtHostname.Leave += new System.EventHandler(this.txtHostname_Leave);
            // 
            // tabInterfaces
            // 
            this.tabInterfaces.Controls.Add(this.boxInterface);
            this.tabInterfaces.Controls.Add(this.boxNewInterface);
            this.tabInterfaces.Location = new System.Drawing.Point(4, 22);
            this.tabInterfaces.Name = "tabInterfaces";
            this.tabInterfaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterfaces.Size = new System.Drawing.Size(599, 350);
            this.tabInterfaces.TabIndex = 1;
            this.tabInterfaces.Text = "Interfaces";
            this.tabInterfaces.UseVisualStyleBackColor = true;
            // 
            // boxInterface
            // 
            this.boxInterface.Controls.Add(this.ipInterfaceMask);
            this.boxInterface.Controls.Add(this.cboInterfaceUseClock);
            this.boxInterface.Controls.Add(this.ipInterfaceAddress);
            this.boxInterface.Controls.Add(this.numInterfaceCIDR);
            this.boxInterface.Controls.Add(this.numInterfaceClock);
            this.boxInterface.Controls.Add(this.txtInterfaceTypeNum);
            this.boxInterface.Controls.Add(this.txtInterfaceName);
            this.boxInterface.Controls.Add(this.lblMask);
            this.boxInterface.Controls.Add(this.lblDTEDCE);
            this.boxInterface.Controls.Add(this.lblSerialClock);
            this.boxInterface.Controls.Add(this.lblCIDR);
            this.boxInterface.Controls.Add(this.lblInterface);
            this.boxInterface.Controls.Add(this.lblIPAddress);
            this.boxInterface.Controls.Add(this.lblName);
            this.boxInterface.Controls.Add(this.txtNoInterfaceWarning);
            this.boxInterface.Controls.Add(this.cboInterfaces);
            this.boxInterface.Enabled = false;
            this.boxInterface.Location = new System.Drawing.Point(6, 65);
            this.boxInterface.Name = "boxInterface";
            this.boxInterface.Size = new System.Drawing.Size(585, 274);
            this.boxInterface.TabIndex = 0;
            this.boxInterface.TabStop = false;
            this.boxInterface.Text = "Interface";
            // 
            // ipInterfaceMask
            // 
            this.ipInterfaceMask.AllowInternalTab = false;
            this.ipInterfaceMask.AutoHeight = true;
            this.ipInterfaceMask.BackColor = System.Drawing.SystemColors.Window;
            this.ipInterfaceMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipInterfaceMask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipInterfaceMask.Location = new System.Drawing.Point(112, 96);
            this.ipInterfaceMask.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipInterfaceMask.Name = "ipInterfaceMask";
            this.ipInterfaceMask.ReadOnly = false;
            this.ipInterfaceMask.Size = new System.Drawing.Size(100, 20);
            this.ipInterfaceMask.TabIndex = 10;
            this.ipInterfaceMask.Text = "...";
            this.ipInterfaceMask.TextChanged += new System.EventHandler(this.ipInterfaceMask_TextChanged);
            // 
            // cboInterfaceUseClock
            // 
            this.cboInterfaceUseClock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterfaceUseClock.FormattingEnabled = true;
            this.cboInterfaceUseClock.Items.AddRange(new object[] {
            "DCE (Master)",
            "DTE (Slave)"});
            this.cboInterfaceUseClock.Location = new System.Drawing.Point(112, 150);
            this.cboInterfaceUseClock.Name = "cboInterfaceUseClock";
            this.cboInterfaceUseClock.Size = new System.Drawing.Size(100, 21);
            this.cboInterfaceUseClock.TabIndex = 2;
            // 
            // ipInterfaceAddress
            // 
            this.ipInterfaceAddress.AllowInternalTab = false;
            this.ipInterfaceAddress.AutoHeight = true;
            this.ipInterfaceAddress.BackColor = System.Drawing.SystemColors.Window;
            this.ipInterfaceAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipInterfaceAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipInterfaceAddress.Location = new System.Drawing.Point(112, 70);
            this.ipInterfaceAddress.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipInterfaceAddress.Name = "ipInterfaceAddress";
            this.ipInterfaceAddress.ReadOnly = false;
            this.ipInterfaceAddress.Size = new System.Drawing.Size(100, 20);
            this.ipInterfaceAddress.TabIndex = 10;
            this.ipInterfaceAddress.Text = "...";
            // 
            // numInterfaceCIDR
            // 
            this.numInterfaceCIDR.Location = new System.Drawing.Point(112, 124);
            this.numInterfaceCIDR.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numInterfaceCIDR.Name = "numInterfaceCIDR";
            this.numInterfaceCIDR.Size = new System.Drawing.Size(100, 20);
            this.numInterfaceCIDR.TabIndex = 9;
            this.numInterfaceCIDR.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numInterfaceCIDR.ValueChanged += new System.EventHandler(this.numInterfaceCIDR_ValueChanged);
            // 
            // numInterfaceClock
            // 
            this.numInterfaceClock.Location = new System.Drawing.Point(112, 182);
            this.numInterfaceClock.Maximum = new decimal(new int[] {
            128000,
            0,
            0,
            0});
            this.numInterfaceClock.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numInterfaceClock.Name = "numInterfaceClock";
            this.numInterfaceClock.Size = new System.Drawing.Size(100, 20);
            this.numInterfaceClock.TabIndex = 9;
            this.numInterfaceClock.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // txtInterfaceTypeNum
            // 
            this.txtInterfaceTypeNum.Location = new System.Drawing.Point(112, 45);
            this.txtInterfaceTypeNum.Name = "txtInterfaceTypeNum";
            this.txtInterfaceTypeNum.ReadOnly = true;
            this.txtInterfaceTypeNum.Size = new System.Drawing.Size(100, 20);
            this.txtInterfaceTypeNum.TabIndex = 8;
            // 
            // txtInterfaceName
            // 
            this.txtInterfaceName.Location = new System.Drawing.Point(112, 17);
            this.txtInterfaceName.Name = "txtInterfaceName";
            this.txtInterfaceName.ReadOnly = true;
            this.txtInterfaceName.Size = new System.Drawing.Size(100, 20);
            this.txtInterfaceName.TabIndex = 8;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(11, 99);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(79, 13);
            this.lblMask.TabIndex = 7;
            this.lblMask.Text = "Subnet Mask : ";
            // 
            // lblDTEDCE
            // 
            this.lblDTEDCE.AutoSize = true;
            this.lblDTEDCE.Location = new System.Drawing.Point(11, 153);
            this.lblDTEDCE.Name = "lblDTEDCE";
            this.lblDTEDCE.Size = new System.Drawing.Size(62, 13);
            this.lblDTEDCE.TabIndex = 6;
            this.lblDTEDCE.Text = "DCE / DTE";
            // 
            // lblSerialClock
            // 
            this.lblSerialClock.AutoSize = true;
            this.lblSerialClock.Location = new System.Drawing.Point(11, 184);
            this.lblSerialClock.Name = "lblSerialClock";
            this.lblSerialClock.Size = new System.Drawing.Size(95, 13);
            this.lblSerialClock.TabIndex = 6;
            this.lblSerialClock.Text = "Serial ClockRate : ";
            // 
            // lblCIDR
            // 
            this.lblCIDR.AutoSize = true;
            this.lblCIDR.Location = new System.Drawing.Point(11, 124);
            this.lblCIDR.Name = "lblCIDR";
            this.lblCIDR.Size = new System.Drawing.Size(42, 13);
            this.lblCIDR.TabIndex = 6;
            this.lblCIDR.Text = "CIDR : ";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(11, 48);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(58, 13);
            this.lblInterface.TabIndex = 5;
            this.lblInterface.Text = "Interface : ";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(11, 73);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(67, 13);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP Address : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Interface Name :";
            // 
            // txtNoInterfaceWarning
            // 
            this.txtNoInterfaceWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoInterfaceWarning.Location = new System.Drawing.Point(69, 237);
            this.txtNoInterfaceWarning.Name = "txtNoInterfaceWarning";
            this.txtNoInterfaceWarning.Size = new System.Drawing.Size(446, 31);
            this.txtNoInterfaceWarning.TabIndex = 2;
            this.txtNoInterfaceWarning.Text = "Add an interface before configuring interfaces";
            // 
            // cboInterfaces
            // 
            this.cboInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterfaces.FormattingEnabled = true;
            this.cboInterfaces.Location = new System.Drawing.Point(401, 0);
            this.cboInterfaces.Name = "cboInterfaces";
            this.cboInterfaces.Size = new System.Drawing.Size(178, 21);
            this.cboInterfaces.TabIndex = 0;
            this.cboInterfaces.SelectedIndexChanged += new System.EventHandler(this.cboInterfaces_SelectedIndexChanged);
            // 
            // boxNewInterface
            // 
            this.boxNewInterface.Controls.Add(this.btnnewInterfaceAdd);
            this.boxNewInterface.Controls.Add(this.cboNewInterfaceType);
            this.boxNewInterface.Controls.Add(this.txtNewInterfaceName);
            this.boxNewInterface.Controls.Add(this.txtNewInterfaceNumber);
            this.boxNewInterface.Location = new System.Drawing.Point(6, 7);
            this.boxNewInterface.Name = "boxNewInterface";
            this.boxNewInterface.Size = new System.Drawing.Size(585, 52);
            this.boxNewInterface.TabIndex = 4;
            this.boxNewInterface.TabStop = false;
            this.boxNewInterface.Text = "New Interface";
            // 
            // btnnewInterfaceAdd
            // 
            this.btnnewInterfaceAdd.Location = new System.Drawing.Point(448, 17);
            this.btnnewInterfaceAdd.Name = "btnnewInterfaceAdd";
            this.btnnewInterfaceAdd.Size = new System.Drawing.Size(126, 23);
            this.btnnewInterfaceAdd.TabIndex = 4;
            this.btnnewInterfaceAdd.Text = "Add Interface";
            this.btnnewInterfaceAdd.UseVisualStyleBackColor = true;
            this.btnnewInterfaceAdd.Click += new System.EventHandler(this.btnnewInterfaceAdd_Click);
            // 
            // cboNewInterfaceType
            // 
            this.cboNewInterfaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewInterfaceType.FormattingEnabled = true;
            this.cboNewInterfaceType.Location = new System.Drawing.Point(157, 19);
            this.cboNewInterfaceType.Name = "cboNewInterfaceType";
            this.cboNewInterfaceType.Size = new System.Drawing.Size(140, 21);
            this.cboNewInterfaceType.TabIndex = 2;
            // 
            // txtNewInterfaceName
            // 
            this.txtNewInterfaceName.Location = new System.Drawing.Point(11, 19);
            this.txtNewInterfaceName.Name = "txtNewInterfaceName";
            this.txtNewInterfaceName.Size = new System.Drawing.Size(140, 20);
            this.txtNewInterfaceName.TabIndex = 1;
            this.txtNewInterfaceName.Enter += new System.EventHandler(this.txtNewInterfaceName_Enter);
            this.txtNewInterfaceName.Leave += new System.EventHandler(this.txtNewInterfaceName_Leave);
            // 
            // txtNewInterfaceNumber
            // 
            this.txtNewInterfaceNumber.Location = new System.Drawing.Point(302, 19);
            this.txtNewInterfaceNumber.Name = "txtNewInterfaceNumber";
            this.txtNewInterfaceNumber.Size = new System.Drawing.Size(140, 20);
            this.txtNewInterfaceNumber.TabIndex = 3;
            this.txtNewInterfaceNumber.Enter += new System.EventHandler(this.txtNewInterfaceNumber_Enter);
            this.txtNewInterfaceNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewInterfaceNumber_KeyUp);
            this.txtNewInterfaceNumber.Leave += new System.EventHandler(this.txtNewInterfaceNumber_Leave);
            // 
            // tabRouting
            // 
            this.tabRouting.Location = new System.Drawing.Point(4, 22);
            this.tabRouting.Name = "tabRouting";
            this.tabRouting.Size = new System.Drawing.Size(599, 350);
            this.tabRouting.TabIndex = 3;
            this.tabRouting.Text = "Routing";
            this.tabRouting.UseVisualStyleBackColor = true;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.txtOutput);
            this.tabOutput.Controls.Add(this.lblOutput);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(599, 350);
            this.tabOutput.TabIndex = 2;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(8, 16);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(583, 327);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(3, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text files (*.txt)|*.txt|XML file (*.xml)|*.xml";
            this.SaveFileDialog.FilterIndex = 0;
            // 
            // errMask
            // 
            this.errMask.BlinkRate = 0;
            this.errMask.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMask.ContainerControl = this;
            // 
            // errAddInterface
            // 
            this.errAddInterface.BlinkRate = 0;
            this.errAddInterface.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddInterface.ContainerControl = this;
            // 
            // CiscoIOSWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CiscoIOSWiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cisco IOS Configuration Wizard";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.grpCon.ResumeLayout(false);
            this.grpCon.PerformLayout();
            this.boxVTY.ResumeLayout(false);
            this.boxVTY.PerformLayout();
            this.boxPassword.ResumeLayout(false);
            this.boxPassword.PerformLayout();
            this.boxGeneral.ResumeLayout(false);
            this.boxGeneral.PerformLayout();
            this.tabInterfaces.ResumeLayout(false);
            this.boxInterface.ResumeLayout(false);
            this.boxInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterfaceCIDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterfaceClock)).EndInit();
            this.boxNewInterface.ResumeLayout(false);
            this.boxNewInterface.PerformLayout();
            this.tabOutput.ResumeLayout(false);
            this.tabOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAddInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabInterfaces;
        private System.Windows.Forms.TabPage tabRouting;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox boxGeneral;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtLogBanner;
        private System.Windows.Forms.TextBox txtMotdBanner;
        private System.Windows.Forms.GroupBox grpCon;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.CheckBox chkConLogSync;
        private System.Windows.Forms.CheckBox chkConLogin;
        private System.Windows.Forms.GroupBox boxVTY;
        private System.Windows.Forms.TextBox txtVTYPass;
        private System.Windows.Forms.CheckBox chkVTYLogSync;
        private System.Windows.Forms.CheckBox chkVTYLogin;
        private System.Windows.Forms.GroupBox boxPassword;
        private System.Windows.Forms.TextBox txtEnPass;
        private System.Windows.Forms.CheckBox chkEncrypt;
        private System.Windows.Forms.CheckBox chkEnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox boxInterface;
        private System.Windows.Forms.ComboBox cboInterfaces;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ComboBox cboNewInterfaceType;
        private System.Windows.Forms.TextBox txtNewInterfaceName;
        private System.Windows.Forms.Button btnnewInterfaceAdd;
        private System.Windows.Forms.GroupBox boxNewInterface;
        private System.Windows.Forms.TextBox txtNoInterfaceWarning;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox txtNewInterfaceNumber;
        private System.Windows.Forms.Label lblCIDR;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblName;
        private IPAddressControlLib.IPAddressControl ipInterfaceMask;
        private System.Windows.Forms.ComboBox cboInterfaceUseClock;
        private IPAddressControlLib.IPAddressControl ipInterfaceAddress;
        private System.Windows.Forms.NumericUpDown numInterfaceCIDR;
        private System.Windows.Forms.NumericUpDown numInterfaceClock;
        private System.Windows.Forms.TextBox txtInterfaceTypeNum;
        private System.Windows.Forms.TextBox txtInterfaceName;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblDTEDCE;
        private System.Windows.Forms.Label lblSerialClock;
        private System.Windows.Forms.ErrorProvider errMask;
        private System.Windows.Forms.ErrorProvider errAddInterface;
    }
}
