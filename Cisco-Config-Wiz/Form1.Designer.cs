namespace Cisco_Config_Wiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainCFG = new System.Windows.Forms.TabPage();
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
            this.interCFG = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboInterfaces = new System.Windows.Forms.ComboBox();
            this.routingCFG = new System.Windows.Forms.TabPage();
            this.output = new System.Windows.Forms.TabPage();
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
            this.err_Empty = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.mainCFG.SuspendLayout();
            this.grpCon.SuspendLayout();
            this.boxVTY.SuspendLayout();
            this.boxPassword.SuspendLayout();
            this.boxGeneral.SuspendLayout();
            this.interCFG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.output.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Empty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.mainCFG);
            this.tabControl1.Controls.Add(this.interCFG);
            this.tabControl1.Controls.Add(this.routingCFG);
            this.tabControl1.Controls.Add(this.output);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // mainCFG
            // 
            this.mainCFG.Controls.Add(this.grpCon);
            this.mainCFG.Controls.Add(this.boxVTY);
            this.mainCFG.Controls.Add(this.boxPassword);
            this.mainCFG.Controls.Add(this.boxGeneral);
            this.mainCFG.Location = new System.Drawing.Point(4, 22);
            this.mainCFG.Name = "mainCFG";
            this.mainCFG.Padding = new System.Windows.Forms.Padding(3);
            this.mainCFG.Size = new System.Drawing.Size(599, 350);
            this.mainCFG.TabIndex = 0;
            this.mainCFG.Text = "General Configuration";
            this.mainCFG.UseVisualStyleBackColor = true;
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
            this.txtMotdBanner.TextChanged += new System.EventHandler(this.txtMotdBanner_TextChanged);
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
            this.txtLogBanner.TextChanged += new System.EventHandler(this.txtLogBanner_TextChanged);
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
            this.txtHostname.TextChanged += new System.EventHandler(this.txtHostname_TextChanged);
            this.txtHostname.Enter += new System.EventHandler(this.txtHostname_Enter);
            this.txtHostname.Leave += new System.EventHandler(this.txtHostname_Leave);
            // 
            // interCFG
            // 
            this.interCFG.Controls.Add(this.groupBox1);
            this.interCFG.Location = new System.Drawing.Point(4, 22);
            this.interCFG.Name = "interCFG";
            this.interCFG.Padding = new System.Windows.Forms.Padding(3);
            this.interCFG.Size = new System.Drawing.Size(599, 350);
            this.interCFG.TabIndex = 1;
            this.interCFG.Text = "Interfaces";
            this.interCFG.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboInterfaces);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface";
            // 
            // cboInterfaces
            // 
            this.cboInterfaces.FormattingEnabled = true;
            this.cboInterfaces.Items.AddRange(new object[] {
            "Fa0/0",
            "Fa0/1",
            "S0/0/0",
            "S0/0/0"});
            this.cboInterfaces.Location = new System.Drawing.Point(401, 0);
            this.cboInterfaces.Name = "cboInterfaces";
            this.cboInterfaces.Size = new System.Drawing.Size(178, 21);
            this.cboInterfaces.TabIndex = 0;
            this.cboInterfaces.SelectedIndexChanged += new System.EventHandler(this.cboInterfaces_SelectedIndexChanged);
            // 
            // routingCFG
            // 
            this.routingCFG.Location = new System.Drawing.Point(4, 22);
            this.routingCFG.Name = "routingCFG";
            this.routingCFG.Size = new System.Drawing.Size(599, 350);
            this.routingCFG.TabIndex = 3;
            this.routingCFG.Text = "Routing";
            this.routingCFG.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Controls.Add(this.txtOutput);
            this.output.Controls.Add(this.lblOutput);
            this.output.Location = new System.Drawing.Point(4, 22);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(599, 350);
            this.output.TabIndex = 2;
            this.output.Text = "Output Configuration";
            this.output.UseVisualStyleBackColor = true;
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
            // err_Empty
            // 
            this.err_Empty.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Cisco IOS Configuration Wizard";
            this.tabControl1.ResumeLayout(false);
            this.mainCFG.ResumeLayout(false);
            this.grpCon.ResumeLayout(false);
            this.grpCon.PerformLayout();
            this.boxVTY.ResumeLayout(false);
            this.boxVTY.PerformLayout();
            this.boxPassword.ResumeLayout(false);
            this.boxPassword.PerformLayout();
            this.boxGeneral.ResumeLayout(false);
            this.boxGeneral.PerformLayout();
            this.interCFG.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Empty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainCFG;
        private System.Windows.Forms.TabPage interCFG;
        private System.Windows.Forms.TabPage routingCFG;
        private System.Windows.Forms.TabPage output;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboInterfaces;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ErrorProvider err_Empty;
    }
}

