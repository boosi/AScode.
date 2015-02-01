namespace SalaryManage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWorkers = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.txFind = new System.Windows.Forms.TextBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.lbFind = new System.Windows.Forms.Label();
            this.cmbJobCard = new System.Windows.Forms.ComboBox();
            this.lbProject = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvWorker = new System.Windows.Forms.ListView();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.lvProjects = new System.Windows.Forms.ListView();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.lvCompanys = new System.Windows.Forms.ListView();
            this.tabPageMaintance = new System.Windows.Forms.TabPage();
            this.btnDataBackup = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolAddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolEditBtn = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolListBtn = new System.Windows.Forms.ToolStripButton();
            this.stripHelpBtn = new System.Windows.Forms.ToolStripButton();
            this.lbTimer = new System.Windows.Forms.ToolStripLabel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.skinEgin = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.MainStatus.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageProjects.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            this.tabPageMaintance.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatus
            // 
            this.MainStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel,
            this.MainStatusInfo,
            this.toolStripStatusLabel3,
            this.statusUserLabel,
            this.CurrentLoginUser});
            this.MainStatus.Location = new System.Drawing.Point(0, 522);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(784, 22);
            this.MainStatus.TabIndex = 4;
            this.MainStatus.Text = "statusStrip1";
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.mainStatusLabel.Text = "Status:";
            // 
            // MainStatusInfo
            // 
            this.MainStatusInfo.AutoSize = false;
            this.MainStatusInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)));
            this.MainStatusInfo.Name = "MainStatusInfo";
            this.MainStatusInfo.Size = new System.Drawing.Size(463, 17);
            this.MainStatusInfo.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // statusUserLabel
            // 
            this.statusUserLabel.Name = "statusUserLabel";
            this.statusUserLabel.Size = new System.Drawing.Size(73, 17);
            this.statusUserLabel.Text = "Current User:";
            // 
            // CurrentLoginUser
            // 
            this.CurrentLoginUser.AutoSize = false;
            this.CurrentLoginUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)));
            this.CurrentLoginUser.Name = "CurrentLoginUser";
            this.CurrentLoginUser.Size = new System.Drawing.Size(180, 17);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageWorkers);
            this.tabControlMain.Controls.Add(this.tabPageProjects);
            this.tabControlMain.Controls.Add(this.tabPageCompany);
            this.tabControlMain.Controls.Add(this.tabPageMaintance);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ItemSize = new System.Drawing.Size(40, 20);
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(20, 3);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.ShowToolTips = true;
            this.tabControlMain.Size = new System.Drawing.Size(784, 496);
            this.tabControlMain.TabIndex = 5;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabIndexChange);
            // 
            // tabPageWorkers
            // 
            this.tabPageWorkers.AutoScroll = true;
            this.tabPageWorkers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWorkers.Controls.Add(this.pictureBox1);
            this.tabPageWorkers.Controls.Add(this.panel1);
            this.tabPageWorkers.Controls.Add(this.btnFind);
            this.tabPageWorkers.Controls.Add(this.txFind);
            this.tabPageWorkers.Controls.Add(this.cmbFind);
            this.tabPageWorkers.Controls.Add(this.lbFind);
            this.tabPageWorkers.Controls.Add(this.cmbJobCard);
            this.tabPageWorkers.Controls.Add(this.lbProject);
            this.tabPageWorkers.Controls.Add(this.lbCompany);
            this.tabPageWorkers.Controls.Add(this.cmbCompany);
            this.tabPageWorkers.Controls.Add(this.label3);
            this.tabPageWorkers.Controls.Add(this.lvWorker);
            this.tabPageWorkers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageWorkers.Location = new System.Drawing.Point(4, 4);
            this.tabPageWorkers.Name = "tabPageWorkers";
            this.tabPageWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkers.Size = new System.Drawing.Size(756, 488);
            this.tabPageWorkers.TabIndex = 0;
            this.tabPageWorkers.Text = "Workers";
            this.tabPageWorkers.ToolTipText = "Show workers list";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 158);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(146, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 158);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "label2959599asdsafdghjghkjhlkj999";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "label2959599asdsafdghjghkjhlkj999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2959599asdsafdghjghkjhlkj999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Second Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // btnFind
            // 
            this.btnFind.ImageIndex = 28;
            this.btnFind.ImageList = this.mainImageList;
            this.btnFind.Location = new System.Drawing.Point(729, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 16;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // mainImageList
            // 
            this.mainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImageList.ImageStream")));
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainImageList.Images.SetKeyName(0, "Add.png");
            this.mainImageList.Images.SetKeyName(1, "Backward.png");
            this.mainImageList.Images.SetKeyName(2, "Chat.png");
            this.mainImageList.Images.SetKeyName(3, "Close.png");
            this.mainImageList.Images.SetKeyName(4, "ControlPanel.png");
            this.mainImageList.Images.SetKeyName(5, "Download.png");
            this.mainImageList.Images.SetKeyName(6, "error.png");
            this.mainImageList.Images.SetKeyName(7, "Fav.png");
            this.mainImageList.Images.SetKeyName(8, "Fav-Alt.png");
            this.mainImageList.Images.SetKeyName(9, "Forward.png");
            this.mainImageList.Images.SetKeyName(10, "Halt.png");
            this.mainImageList.Images.SetKeyName(11, "Help.png");
            this.mainImageList.Images.SetKeyName(12, "Home.png");
            this.mainImageList.Images.SetKeyName(13, "Image_JPG.png");
            this.mainImageList.Images.SetKeyName(14, "Image_PNG.png");
            this.mainImageList.Images.SetKeyName(15, "Info.png");
            this.mainImageList.Images.SetKeyName(16, "iPhone.png");
            this.mainImageList.Images.SetKeyName(17, "Key.png");
            this.mainImageList.Images.SetKeyName(18, "Movie.png");
            this.mainImageList.Images.SetKeyName(19, "Music.png");
            this.mainImageList.Images.SetKeyName(20, "Office_DOC.png");
            this.mainImageList.Images.SetKeyName(21, "Office_TXT.png");
            this.mainImageList.Images.SetKeyName(22, "Office_XLS.png");
            this.mainImageList.Images.SetKeyName(23, "Padlock.png");
            this.mainImageList.Images.SetKeyName(24, "printer.png");
            this.mainImageList.Images.SetKeyName(25, "prohibited.png");
            this.mainImageList.Images.SetKeyName(26, "Restart.png");
            this.mainImageList.Images.SetKeyName(27, "RSS.png");
            this.mainImageList.Images.SetKeyName(28, "Search.png");
            this.mainImageList.Images.SetKeyName(29, "Security.png");
            this.mainImageList.Images.SetKeyName(30, "Select.png");
            this.mainImageList.Images.SetKeyName(31, "Settings.png");
            this.mainImageList.Images.SetKeyName(32, "Shutdown.png");
            this.mainImageList.Images.SetKeyName(33, "Smiley.png");
            this.mainImageList.Images.SetKeyName(34, "Spreadsheet2.png");
            this.mainImageList.Images.SetKeyName(35, "Stats.png");
            this.mainImageList.Images.SetKeyName(36, "Steam.png");
            this.mainImageList.Images.SetKeyName(37, "Sys.png");
            this.mainImageList.Images.SetKeyName(38, "System-Binary.png");
            this.mainImageList.Images.SetKeyName(39, "Tips.png");
            this.mainImageList.Images.SetKeyName(40, "Tools.png");
            this.mainImageList.Images.SetKeyName(41, "trash_full.png");
            this.mainImageList.Images.SetKeyName(42, "Upload.png");
            this.mainImageList.Images.SetKeyName(43, "User.png");
            this.mainImageList.Images.SetKeyName(44, "User-Male.png");
            this.mainImageList.Images.SetKeyName(45, "warning.png");
            // 
            // txFind
            // 
            this.txFind.Location = new System.Drawing.Point(575, 3);
            this.txFind.Name = "txFind";
            this.txFind.Size = new System.Drawing.Size(150, 21);
            this.txFind.TabIndex = 15;
            // 
            // cmbFind
            // 
            this.cmbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Items.AddRange(new object[] {
            "",
            "Name",
            "Work Number",
            "Project",
            "Company"});
            this.cmbFind.Location = new System.Drawing.Point(479, 3);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(90, 23);
            this.cmbFind.TabIndex = 14;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Location = new System.Drawing.Point(443, 6);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(34, 15);
            this.lbFind.TabIndex = 13;
            this.lbFind.Text = "Find:";
            // 
            // cmbJobCard
            // 
            this.cmbJobCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobCard.DropDownWidth = 200;
            this.cmbJobCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbJobCard.FormattingEnabled = true;
            this.cmbJobCard.Location = new System.Drawing.Point(278, 3);
            this.cmbJobCard.Name = "cmbJobCard";
            this.cmbJobCard.Size = new System.Drawing.Size(150, 23);
            this.cmbJobCard.TabIndex = 12;
            this.cmbJobCard.SelectedIndexChanged += new System.EventHandler(this.CorpCmbBoxChange);
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Location = new System.Drawing.Point(229, 6);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(48, 15);
            this.lbProject.TabIndex = 11;
            this.lbProject.Text = "Project:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(4, 6);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(62, 15);
            this.lbCompany.TabIndex = 10;
            this.lbCompany.Text = "Company:";
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.DropDownWidth = 300;
            this.cmbCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(64, 3);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(150, 23);
            this.cmbCompany.TabIndex = 9;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.CorpCmbBoxChange);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detail:";
            // 
            // lvWorker
            // 
            this.lvWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWorker.FullRowSelect = true;
            this.lvWorker.GridLines = true;
            this.lvWorker.Location = new System.Drawing.Point(6, 26);
            this.lvWorker.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lvWorker.MultiSelect = false;
            this.lvWorker.Name = "lvWorker";
            this.lvWorker.Size = new System.Drawing.Size(748, 273);
            this.lvWorker.TabIndex = 0;
            this.lvWorker.UseCompatibleStateImageBehavior = false;
            this.lvWorker.View = System.Windows.Forms.View.Details;
            this.lvWorker.SelectedIndexChanged += new System.EventHandler(this.StaffItemChange);
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.lvProjects);
            this.tabPageProjects.Location = new System.Drawing.Point(4, 4);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjects.Size = new System.Drawing.Size(756, 488);
            this.tabPageProjects.TabIndex = 1;
            this.tabPageProjects.Text = "Projects";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // lvProjects
            // 
            this.lvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProjects.FullRowSelect = true;
            this.lvProjects.GridLines = true;
            this.lvProjects.Location = new System.Drawing.Point(6, 6);
            this.lvProjects.MultiSelect = false;
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.Size = new System.Drawing.Size(744, 450);
            this.lvProjects.TabIndex = 1;
            this.lvProjects.UseCompatibleStateImageBehavior = false;
            this.lvProjects.View = System.Windows.Forms.View.Details;
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.lvCompanys);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 4);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Size = new System.Drawing.Size(756, 488);
            this.tabPageCompany.TabIndex = 2;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // lvCompanys
            // 
            this.lvCompanys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCompanys.FullRowSelect = true;
            this.lvCompanys.GridLines = true;
            this.lvCompanys.Location = new System.Drawing.Point(6, 3);
            this.lvCompanys.MultiSelect = false;
            this.lvCompanys.Name = "lvCompanys";
            this.lvCompanys.Size = new System.Drawing.Size(744, 456);
            this.lvCompanys.TabIndex = 1;
            this.lvCompanys.UseCompatibleStateImageBehavior = false;
            this.lvCompanys.View = System.Windows.Forms.View.Details;
            // 
            // tabPageMaintance
            // 
            this.tabPageMaintance.Controls.Add(this.btnDataBackup);
            this.tabPageMaintance.Controls.Add(this.btnOption);
            this.tabPageMaintance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMaintance.Name = "tabPageMaintance";
            this.tabPageMaintance.Size = new System.Drawing.Size(756, 488);
            this.tabPageMaintance.TabIndex = 3;
            this.tabPageMaintance.Text = "Maintance";
            this.tabPageMaintance.UseVisualStyleBackColor = true;
            // 
            // btnDataBackup
            // 
            this.btnDataBackup.ImageIndex = 9;
            this.btnDataBackup.ImageList = this.mainImageList;
            this.btnDataBackup.Location = new System.Drawing.Point(96, 23);
            this.btnDataBackup.Name = "btnDataBackup";
            this.btnDataBackup.Size = new System.Drawing.Size(48, 48);
            this.btnDataBackup.TabIndex = 1;
            this.btnDataBackup.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOption.ImageKey = "ControlPanel.png";
            this.btnOption.ImageList = this.mainImageList;
            this.btnOption.Location = new System.Drawing.Point(22, 23);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(48, 48);
            this.btnOption.TabIndex = 0;
            this.btnOption.UseVisualStyleBackColor = false;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddBtn,
            this.toolEditBtn,
            this.toolDeleteBtn,
            this.toolListBtn,
            this.stripHelpBtn,
            this.lbTimer});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMain.Size = new System.Drawing.Size(784, 25);
            this.toolStripMain.TabIndex = 6;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolAddBtn
            // 
            this.toolAddBtn.AutoSize = false;
            this.toolAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolAddBtn.Image = global::SalaryManage.Properties.Resources.Add;
            this.toolAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolAddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddBtn.Name = "toolAddBtn";
            this.toolAddBtn.Size = new System.Drawing.Size(72, 20);
            this.toolAddBtn.Text = "Append";
            this.toolAddBtn.ToolTipText = "Add a new information";
            this.toolAddBtn.Click += new System.EventHandler(this.toolAddBtn_Click);
            // 
            // toolEditBtn
            // 
            this.toolEditBtn.AutoSize = false;
            this.toolEditBtn.Image = global::SalaryManage.Properties.Resources.Info;
            this.toolEditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditBtn.Name = "toolEditBtn";
            this.toolEditBtn.Size = new System.Drawing.Size(70, 20);
            this.toolEditBtn.Text = "Edit";
            this.toolEditBtn.ToolTipText = "Edit a selected information";
            this.toolEditBtn.Click += new System.EventHandler(this.toolEditBtn_Click);
            // 
            // toolDeleteBtn
            // 
            this.toolDeleteBtn.AutoSize = false;
            this.toolDeleteBtn.Image = global::SalaryManage.Properties.Resources.Close;
            this.toolDeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteBtn.Name = "toolDeleteBtn";
            this.toolDeleteBtn.Size = new System.Drawing.Size(70, 20);
            this.toolDeleteBtn.Text = "Delete";
            this.toolDeleteBtn.ToolTipText = "Delete data";
            this.toolDeleteBtn.Click += new System.EventHandler(this.toolDeleteBtn_Click);
            // 
            // toolListBtn
            // 
            this.toolListBtn.AutoSize = false;
            this.toolListBtn.Image = global::SalaryManage.Properties.Resources.Select;
            this.toolListBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolListBtn.Name = "toolListBtn";
            this.toolListBtn.Size = new System.Drawing.Size(70, 20);
            this.toolListBtn.Text = "List all";
            this.toolListBtn.ToolTipText = "Show all data";
            this.toolListBtn.Click += new System.EventHandler(this.toolListBtn_Click);
            // 
            // stripHelpBtn
            // 
            this.stripHelpBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stripHelpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripHelpBtn.Image = global::SalaryManage.Properties.Resources.Help;
            this.stripHelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripHelpBtn.Name = "stripHelpBtn";
            this.stripHelpBtn.Size = new System.Drawing.Size(23, 22);
            this.stripHelpBtn.Text = "stripHelpBtn";
            this.stripHelpBtn.ToolTipText = "Help";
            // 
            // lbTimer
            // 
            this.lbTimer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbTimer.AutoSize = false;
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(160, 22);
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            // 
            // skinEgin
            // 
            this.skinEgin.SerialNumber = "";
            this.skinEgin.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(784, 544);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.MainStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Manage Main Panel";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWorkers.ResumeLayout(false);
            this.tabPageWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageProjects.ResumeLayout(false);
            this.tabPageCompany.ResumeLayout(false);
            this.tabPageMaintance.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusUserLabel;
        private System.Windows.Forms.ToolStripStatusLabel CurrentLoginUser;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWorkers;
        private System.Windows.Forms.TabPage tabPageProjects;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.TabPage tabPageMaintance;
        private System.Windows.Forms.ListView lvWorker;
        private System.Windows.Forms.Button btnDataBackup;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolAddBtn;
        private System.Windows.Forms.ToolStripButton toolEditBtn;
        private System.Windows.Forms.ToolStripButton toolDeleteBtn;
        private System.Windows.Forms.ToolStripButton stripHelpBtn;
        private System.Windows.Forms.ToolStripButton toolListBtn;
        private System.Windows.Forms.ImageList mainImageList;
        private System.Windows.Forms.ListView lvProjects;
        private System.Windows.Forms.ListView lvCompanys;
        private System.Windows.Forms.BindingSource salaryDatSetBindingSource;
        private System.Windows.Forms.BindingSource corpsBindingSource;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.ToolStripLabel lbTimer;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.ComboBox cmbJobCard;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.TextBox txFind;
        private System.Windows.Forms.Button btnFind;
        private Sunisoft.IrisSkin.SkinEngine skinEgin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}