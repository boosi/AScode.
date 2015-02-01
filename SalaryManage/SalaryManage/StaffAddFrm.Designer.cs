namespace SalaryManage
{
    partial class StaffAddFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAddFrm));
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbWorkerName = new System.Windows.Forms.Label();
            this.lbJobCard = new System.Windows.Forms.Label();
            this.lbBusinessUnit = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbNationality = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbSkill = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbBaseSalary = new System.Windows.Forms.Label();
            this.lbRate1 = new System.Windows.Forms.Label();
            this.lbRate2 = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.txIndexNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txWorkerName = new System.Windows.Forms.TextBox();
            this.txNationality = new System.Windows.Forms.TextBox();
            this.txSkill = new System.Windows.Forms.TextBox();
            this.txBaseSalary = new System.Windows.Forms.TextBox();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.AddJobCardBtn = new System.Windows.Forms.Button();
            this.AddCompanyBtn = new System.Windows.Forms.Button();
            this.cmbJobCard = new System.Windows.Forms.ComboBox();
            this.cbBusiness = new System.Windows.Forms.ComboBox();
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.cmbIdtype = new System.Windows.Forms.ComboBox();
            this.lbIdtype = new System.Windows.Forms.Label();
            this.txIDNum = new System.Windows.Forms.TextBox();
            this.lbIdNum = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.rdPolicyYes = new System.Windows.Forms.RadioButton();
            this.rdPolicyNo = new System.Windows.Forms.RadioButton();
            this.lbPolicy = new System.Windows.Forms.Label();
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.gbSalary = new System.Windows.Forms.GroupBox();
            this.cmbRate2 = new System.Windows.Forms.ComboBox();
            this.cmbRate1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txContactFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdContactsGerder2 = new System.Windows.Forms.RadioButton();
            this.rdContactsGerder = new System.Windows.Forms.RadioButton();
            this.lbContactTel = new System.Windows.Forms.Label();
            this.lbContactName = new System.Windows.Forms.Label();
            this.txContactName = new System.Windows.Forms.TextBox();
            this.txContactTel = new System.Windows.Forms.TextBox();
            this.txContactID = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbTraning = new System.Windows.Forms.GroupBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.proDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbProject.SuspendLayout();
            this.gbWorker.SuspendLayout();
            this.gbSalary.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecute.Location = new System.Drawing.Point(234, 407);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbWorkerName
            // 
            this.lbWorkerName.AutoSize = true;
            this.lbWorkerName.ForeColor = System.Drawing.Color.Black;
            this.lbWorkerName.Location = new System.Drawing.Point(30, 20);
            this.lbWorkerName.Name = "lbWorkerName";
            this.lbWorkerName.Size = new System.Drawing.Size(38, 13);
            this.lbWorkerName.TabIndex = 2;
            this.lbWorkerName.Text = "Name:";
            // 
            // lbJobCard
            // 
            this.lbJobCard.AutoSize = true;
            this.lbJobCard.ForeColor = System.Drawing.Color.Black;
            this.lbJobCard.Location = new System.Drawing.Point(323, 22);
            this.lbJobCard.Name = "lbJobCard";
            this.lbJobCard.Size = new System.Drawing.Size(52, 13);
            this.lbJobCard.TabIndex = 3;
            this.lbJobCard.Text = "Job Card:";
            // 
            // lbBusinessUnit
            // 
            this.lbBusinessUnit.AutoSize = true;
            this.lbBusinessUnit.ForeColor = System.Drawing.Color.Black;
            this.lbBusinessUnit.Location = new System.Drawing.Point(10, 22);
            this.lbBusinessUnit.Name = "lbBusinessUnit";
            this.lbBusinessUnit.Size = new System.Drawing.Size(54, 13);
            this.lbBusinessUnit.TabIndex = 4;
            this.lbBusinessUnit.Text = "Company:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.ForeColor = System.Drawing.Color.Black;
            this.lbGender.Location = new System.Drawing.Point(384, 22);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(45, 13);
            this.lbGender.TabIndex = 6;
            this.lbGender.Text = "Gender:";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.ForeColor = System.Drawing.Color.Black;
            this.lbNationality.Location = new System.Drawing.Point(10, 59);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(59, 13);
            this.lbNationality.TabIndex = 7;
            this.lbNationality.Text = "Nationality:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.ForeColor = System.Drawing.Color.Black;
            this.lbAge.Location = new System.Drawing.Point(501, 22);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(29, 13);
            this.lbAge.TabIndex = 8;
            this.lbAge.Text = "Age:";
            // 
            // lbSkill
            // 
            this.lbSkill.AutoSize = true;
            this.lbSkill.ForeColor = System.Drawing.Color.Black;
            this.lbSkill.Location = new System.Drawing.Point(40, 91);
            this.lbSkill.Name = "lbSkill";
            this.lbSkill.Size = new System.Drawing.Size(29, 13);
            this.lbSkill.TabIndex = 9;
            this.lbSkill.Text = "Skill:";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.ForeColor = System.Drawing.Color.Black;
            this.lbGrade.Location = new System.Drawing.Point(253, 91);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(39, 13);
            this.lbGrade.TabIndex = 10;
            this.lbGrade.Text = "Grade:";
            this.lbGrade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBaseSalary
            // 
            this.lbBaseSalary.AutoSize = true;
            this.lbBaseSalary.ForeColor = System.Drawing.Color.Black;
            this.lbBaseSalary.Location = new System.Drawing.Point(28, 25);
            this.lbBaseSalary.Name = "lbBaseSalary";
            this.lbBaseSalary.Size = new System.Drawing.Size(36, 13);
            this.lbBaseSalary.TabIndex = 11;
            this.lbBaseSalary.Text = "Basic:";
            // 
            // lbRate1
            // 
            this.lbRate1.AutoSize = true;
            this.lbRate1.ForeColor = System.Drawing.Color.Black;
            this.lbRate1.Location = new System.Drawing.Point(141, 25);
            this.lbRate1.Name = "lbRate1";
            this.lbRate1.Size = new System.Drawing.Size(64, 13);
            this.lbRate1.TabIndex = 12;
            this.lbRate1.Text = "Off Day OT:";
            // 
            // lbRate2
            // 
            this.lbRate2.AutoSize = true;
            this.lbRate2.ForeColor = System.Drawing.Color.Black;
            this.lbRate2.Location = new System.Drawing.Point(262, 25);
            this.lbRate2.Name = "lbRate2";
            this.lbRate2.Size = new System.Drawing.Size(63, 13);
            this.lbRate2.TabIndex = 2;
            this.lbRate2.Text = "Holiday OT:";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(10, 18);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(72, 13);
            this.lbIndex.TabIndex = 16;
            this.lbIndex.Text = "Worker\'s No.:";
            // 
            // txIndexNo
            // 
            this.txIndexNo.BackColor = System.Drawing.Color.AliceBlue;
            this.txIndexNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.txIndexNo.Location = new System.Drawing.Point(88, 15);
            this.txIndexNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txIndexNo.Name = "txIndexNo";
            this.txIndexNo.ReadOnly = true;
            this.txIndexNo.Size = new System.Drawing.Size(163, 20);
            this.txIndexNo.TabIndex = 0;
            this.txIndexNo.Text = "Auto genate.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(Auto. Cannot be changed)";
            // 
            // txWorkerName
            // 
            this.txWorkerName.ForeColor = System.Drawing.Color.Navy;
            this.txWorkerName.Location = new System.Drawing.Point(75, 17);
            this.txWorkerName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txWorkerName.Name = "txWorkerName";
            this.txWorkerName.Size = new System.Drawing.Size(290, 20);
            this.txWorkerName.TabIndex = 0;
            // 
            // txNationality
            // 
            this.txNationality.ForeColor = System.Drawing.Color.Navy;
            this.txNationality.Location = new System.Drawing.Point(75, 54);
            this.txNationality.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txNationality.Name = "txNationality";
            this.txNationality.Size = new System.Drawing.Size(88, 20);
            this.txNationality.TabIndex = 1;
            // 
            // txSkill
            // 
            this.txSkill.ForeColor = System.Drawing.Color.Navy;
            this.txSkill.Location = new System.Drawing.Point(75, 86);
            this.txSkill.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txSkill.Name = "txSkill";
            this.txSkill.Size = new System.Drawing.Size(169, 20);
            this.txSkill.TabIndex = 6;
            // 
            // txBaseSalary
            // 
            this.txBaseSalary.ForeColor = System.Drawing.Color.Navy;
            this.txBaseSalary.Location = new System.Drawing.Point(70, 22);
            this.txBaseSalary.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txBaseSalary.Name = "txBaseSalary";
            this.txBaseSalary.Size = new System.Drawing.Size(60, 20);
            this.txBaseSalary.TabIndex = 0;
            this.txBaseSalary.Text = "500.00";
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.AddJobCardBtn);
            this.gbProject.Controls.Add(this.AddCompanyBtn);
            this.gbProject.Controls.Add(this.cmbJobCard);
            this.gbProject.Controls.Add(this.cbBusiness);
            this.gbProject.Controls.Add(this.lbJobCard);
            this.gbProject.Controls.Add(this.lbBusinessUnit);
            this.gbProject.ForeColor = System.Drawing.Color.Firebrick;
            this.gbProject.Location = new System.Drawing.Point(7, 47);
            this.gbProject.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(632, 56);
            this.gbProject.TabIndex = 33;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Project";
            // 
            // AddJobCardBtn
            // 
            this.AddJobCardBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddJobCardBtn.Location = new System.Drawing.Point(599, 18);
            this.AddJobCardBtn.Name = "AddJobCardBtn";
            this.AddJobCardBtn.Size = new System.Drawing.Size(22, 20);
            this.AddJobCardBtn.TabIndex = 3;
            this.AddJobCardBtn.Text = "+";
            this.AddJobCardBtn.UseVisualStyleBackColor = true;
            this.AddJobCardBtn.Click += new System.EventHandler(this.AddJobCardBtn_Click);
            // 
            // AddCompanyBtn
            // 
            this.AddCompanyBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddCompanyBtn.Location = new System.Drawing.Point(290, 19);
            this.AddCompanyBtn.Name = "AddCompanyBtn";
            this.AddCompanyBtn.Size = new System.Drawing.Size(22, 20);
            this.AddCompanyBtn.TabIndex = 1;
            this.AddCompanyBtn.Text = "+";
            this.AddCompanyBtn.UseVisualStyleBackColor = true;
            this.AddCompanyBtn.Click += new System.EventHandler(this.AddCompanyBtn_Click);
            // 
            // cmbJobCard
            // 
            this.cmbJobCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobCard.FormattingEnabled = true;
            this.cmbJobCard.Location = new System.Drawing.Point(381, 19);
            this.cmbJobCard.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbJobCard.Name = "cmbJobCard";
            this.cmbJobCard.Size = new System.Drawing.Size(215, 21);
            this.cmbJobCard.TabIndex = 2;
            // 
            // cbBusiness
            // 
            this.cbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusiness.DropDownWidth = 300;
            this.cbBusiness.FormattingEnabled = true;
            this.cbBusiness.Location = new System.Drawing.Point(70, 19);
            this.cbBusiness.Name = "cbBusiness";
            this.cbBusiness.Size = new System.Drawing.Size(215, 21);
            this.cbBusiness.TabIndex = 0;
            // 
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.cmbIdtype);
            this.gbWorker.Controls.Add(this.lbIdtype);
            this.gbWorker.Controls.Add(this.txIDNum);
            this.gbWorker.Controls.Add(this.lbIdNum);
            this.gbWorker.Controls.Add(this.cmbGrade);
            this.gbWorker.Controls.Add(this.rdPolicyYes);
            this.gbWorker.Controls.Add(this.rdPolicyNo);
            this.gbWorker.Controls.Add(this.lbPolicy);
            this.gbWorker.Controls.Add(this.cmbAge);
            this.gbWorker.Controls.Add(this.cmbGender);
            this.gbWorker.Controls.Add(this.txWorkerName);
            this.gbWorker.Controls.Add(this.lbWorkerName);
            this.gbWorker.Controls.Add(this.lbGender);
            this.gbWorker.Controls.Add(this.lbNationality);
            this.gbWorker.Controls.Add(this.lbAge);
            this.gbWorker.Controls.Add(this.txNationality);
            this.gbWorker.Controls.Add(this.txSkill);
            this.gbWorker.Controls.Add(this.lbSkill);
            this.gbWorker.Controls.Add(this.lbGrade);
            this.gbWorker.ForeColor = System.Drawing.Color.Firebrick;
            this.gbWorker.Location = new System.Drawing.Point(7, 115);
            this.gbWorker.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbWorker.Size = new System.Drawing.Size(632, 120);
            this.gbWorker.TabIndex = 34;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "Worker";
            // 
            // cmbIdtype
            // 
            this.cmbIdtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdtype.FormattingEnabled = true;
            this.cmbIdtype.Items.AddRange(new object[] {
            "I.D. card",
            "Passport",
            "WP",
            "SP",
            "EP",
            "Other"});
            this.cmbIdtype.Location = new System.Drawing.Point(298, 56);
            this.cmbIdtype.Name = "cmbIdtype";
            this.cmbIdtype.Size = new System.Drawing.Size(80, 21);
            this.cmbIdtype.TabIndex = 4;
            // 
            // lbIdtype
            // 
            this.lbIdtype.AutoSize = true;
            this.lbIdtype.ForeColor = System.Drawing.Color.Black;
            this.lbIdtype.Location = new System.Drawing.Point(239, 61);
            this.lbIdtype.Name = "lbIdtype";
            this.lbIdtype.Size = new System.Drawing.Size(53, 13);
            this.lbIdtype.TabIndex = 37;
            this.lbIdtype.Text = "I.C. Type:";
            this.lbIdtype.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txIDNum
            // 
            this.txIDNum.Location = new System.Drawing.Point(435, 56);
            this.txIDNum.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txIDNum.Name = "txIDNum";
            this.txIDNum.Size = new System.Drawing.Size(161, 20);
            this.txIDNum.TabIndex = 5;
            // 
            // lbIdNum
            // 
            this.lbIdNum.AutoSize = true;
            this.lbIdNum.ForeColor = System.Drawing.Color.Black;
            this.lbIdNum.Location = new System.Drawing.Point(400, 61);
            this.lbIdNum.Name = "lbIdNum";
            this.lbIdNum.Size = new System.Drawing.Size(27, 13);
            this.lbIdNum.TabIndex = 34;
            this.lbIdNum.Text = "No.:";
            this.lbIdNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "Primary",
            "Middle",
            "Aadvanced"});
            this.cmbGrade.Location = new System.Drawing.Point(298, 86);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(80, 21);
            this.cmbGrade.TabIndex = 7;
            // 
            // rdPolicyYes
            // 
            this.rdPolicyYes.AutoSize = true;
            this.rdPolicyYes.ForeColor = System.Drawing.Color.Black;
            this.rdPolicyYes.Location = new System.Drawing.Point(551, 89);
            this.rdPolicyYes.Name = "rdPolicyYes";
            this.rdPolicyYes.Size = new System.Drawing.Size(43, 17);
            this.rdPolicyYes.TabIndex = 32;
            this.rdPolicyYes.Text = "Yes";
            this.rdPolicyYes.UseVisualStyleBackColor = true;
            // 
            // rdPolicyNo
            // 
            this.rdPolicyNo.AutoSize = true;
            this.rdPolicyNo.Checked = true;
            this.rdPolicyNo.ForeColor = System.Drawing.Color.Black;
            this.rdPolicyNo.Location = new System.Drawing.Point(506, 89);
            this.rdPolicyNo.Name = "rdPolicyNo";
            this.rdPolicyNo.Size = new System.Drawing.Size(39, 17);
            this.rdPolicyNo.TabIndex = 9;
            this.rdPolicyNo.TabStop = true;
            this.rdPolicyNo.Text = "No";
            this.rdPolicyNo.UseVisualStyleBackColor = true;
            // 
            // lbPolicy
            // 
            this.lbPolicy.AutoSize = true;
            this.lbPolicy.ForeColor = System.Drawing.Color.Black;
            this.lbPolicy.Location = new System.Drawing.Point(400, 91);
            this.lbPolicy.Name = "lbPolicy";
            this.lbPolicy.Size = new System.Drawing.Size(100, 13);
            this.lbPolicy.TabIndex = 8;
            this.lbPolicy.Text = "Policy of Insurance:";
            this.lbPolicy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbAge
            // 
            this.cmbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Items.AddRange(new object[] {
            "18 - 22",
            "23 - 28",
            "28 - 33",
            "34 - 39",
            "40 - 45",
            "46 - 49",
            "50 - 55",
            "56 - 60",
            "60 +"});
            this.cmbAge.Location = new System.Drawing.Point(536, 17);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(60, 21);
            this.cmbAge.TabIndex = 3;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(435, 17);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(60, 21);
            this.cmbGender.TabIndex = 2;
            // 
            // gbSalary
            // 
            this.gbSalary.Controls.Add(this.cmbRate2);
            this.gbSalary.Controls.Add(this.cmbRate1);
            this.gbSalary.Controls.Add(this.txBaseSalary);
            this.gbSalary.Controls.Add(this.lbBaseSalary);
            this.gbSalary.Controls.Add(this.lbRate2);
            this.gbSalary.Controls.Add(this.lbRate1);
            this.gbSalary.ForeColor = System.Drawing.Color.Firebrick;
            this.gbSalary.Location = new System.Drawing.Point(7, 247);
            this.gbSalary.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbSalary.Name = "gbSalary";
            this.gbSalary.Size = new System.Drawing.Size(632, 54);
            this.gbSalary.TabIndex = 35;
            this.gbSalary.TabStop = false;
            this.gbSalary.Text = "Salary";
            // 
            // cmbRate2
            // 
            this.cmbRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRate2.FormattingEnabled = true;
            this.cmbRate2.Items.AddRange(new object[] {
            "1",
            "1.2",
            "1.5",
            "1.8",
            "2",
            "2.2",
            "2.5",
            "3"});
            this.cmbRate2.Location = new System.Drawing.Point(331, 22);
            this.cmbRate2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbRate2.Name = "cmbRate2";
            this.cmbRate2.Size = new System.Drawing.Size(45, 21);
            this.cmbRate2.TabIndex = 3;
            // 
            // cmbRate1
            // 
            this.cmbRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRate1.FormattingEnabled = true;
            this.cmbRate1.Items.AddRange(new object[] {
            "1",
            "1.2",
            "1.5",
            "1.8",
            "2",
            "2.2",
            "2.5",
            "3"});
            this.cmbRate1.Location = new System.Drawing.Point(211, 22);
            this.cmbRate1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbRate1.Name = "cmbRate1";
            this.cmbRate1.Size = new System.Drawing.Size(45, 21);
            this.cmbRate1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(212, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Register:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 23);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dateTimePicker2.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2011, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2012, 4, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2011, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2011, 4, 28, 0, 0, 0, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPerson);
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 400);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabSelectChange);
            // 
            // tabPerson
            // 
            this.tabPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.tabPerson.Controls.Add(this.groupBox1);
            this.tabPerson.Controls.Add(this.lbIndex);
            this.tabPerson.Controls.Add(this.txIndexNo);
            this.tabPerson.Controls.Add(this.label1);
            this.tabPerson.Controls.Add(this.gbSalary);
            this.tabPerson.Controls.Add(this.gbProject);
            this.tabPerson.Controls.Add(this.gbWorker);
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(648, 374);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Person";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(7, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(632, 57);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register:";
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.gbContact);
            this.tabDetail.Controls.Add(this.groupBox2);
            this.tabDetail.Controls.Add(this.gbPicture);
            this.tabDetail.Controls.Add(this.gbTraning);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(648, 374);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Detail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // gbContact
            // 
            this.gbContact.BackColor = System.Drawing.Color.Transparent;
            this.gbContact.Controls.Add(this.txContactFirstName);
            this.gbContact.Controls.Add(this.label3);
            this.gbContact.Controls.Add(this.label2);
            this.gbContact.Controls.Add(this.rdContactsGerder2);
            this.gbContact.Controls.Add(this.rdContactsGerder);
            this.gbContact.Controls.Add(this.lbContactTel);
            this.gbContact.Controls.Add(this.lbContactName);
            this.gbContact.Controls.Add(this.txContactName);
            this.gbContact.Controls.Add(this.txContactTel);
            this.gbContact.Controls.Add(this.txContactID);
            this.gbContact.Controls.Add(this.lbContact);
            this.gbContact.Enabled = false;
            this.gbContact.ForeColor = System.Drawing.Color.Firebrick;
            this.gbContact.Location = new System.Drawing.Point(138, 6);
            this.gbContact.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(266, 184);
            this.gbContact.TabIndex = 38;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact";
            // 
            // txContactFirstName
            // 
            this.txContactFirstName.Location = new System.Drawing.Point(97, 83);
            this.txContactFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txContactFirstName.Name = "txContactFirstName";
            this.txContactFirstName.Size = new System.Drawing.Size(150, 20);
            this.txContactFirstName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Family Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ttitle:";
            // 
            // rdContactsGerder2
            // 
            this.rdContactsGerder2.AutoSize = true;
            this.rdContactsGerder2.ForeColor = System.Drawing.Color.Black;
            this.rdContactsGerder2.Location = new System.Drawing.Point(145, 54);
            this.rdContactsGerder2.Name = "rdContactsGerder2";
            this.rdContactsGerder2.Size = new System.Drawing.Size(40, 17);
            this.rdContactsGerder2.TabIndex = 42;
            this.rdContactsGerder2.TabStop = true;
            this.rdContactsGerder2.Text = "Mr.";
            this.rdContactsGerder2.UseVisualStyleBackColor = true;
            // 
            // rdContactsGerder
            // 
            this.rdContactsGerder.AutoSize = true;
            this.rdContactsGerder.ForeColor = System.Drawing.Color.Black;
            this.rdContactsGerder.Location = new System.Drawing.Point(97, 54);
            this.rdContactsGerder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.rdContactsGerder.Name = "rdContactsGerder";
            this.rdContactsGerder.Size = new System.Drawing.Size(42, 17);
            this.rdContactsGerder.TabIndex = 41;
            this.rdContactsGerder.TabStop = true;
            this.rdContactsGerder.Text = "Ms.";
            this.rdContactsGerder.UseVisualStyleBackColor = true;
            // 
            // lbContactTel
            // 
            this.lbContactTel.AutoSize = true;
            this.lbContactTel.ForeColor = System.Drawing.Color.Black;
            this.lbContactTel.Location = new System.Drawing.Point(36, 150);
            this.lbContactTel.Name = "lbContactTel";
            this.lbContactTel.Size = new System.Drawing.Size(55, 13);
            this.lbContactTel.TabIndex = 40;
            this.lbContactTel.Text = "Telphone:";
            // 
            // lbContactName
            // 
            this.lbContactName.AutoSize = true;
            this.lbContactName.ForeColor = System.Drawing.Color.Black;
            this.lbContactName.Location = new System.Drawing.Point(53, 118);
            this.lbContactName.Name = "lbContactName";
            this.lbContactName.Size = new System.Drawing.Size(38, 13);
            this.lbContactName.TabIndex = 34;
            this.lbContactName.Text = "Name:";
            // 
            // txContactName
            // 
            this.txContactName.Location = new System.Drawing.Point(97, 115);
            this.txContactName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txContactName.Name = "txContactName";
            this.txContactName.Size = new System.Drawing.Size(150, 20);
            this.txContactName.TabIndex = 33;
            // 
            // txContactTel
            // 
            this.txContactTel.Location = new System.Drawing.Point(97, 147);
            this.txContactTel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txContactTel.Name = "txContactTel";
            this.txContactTel.Size = new System.Drawing.Size(81, 20);
            this.txContactTel.TabIndex = 32;
            // 
            // txContactID
            // 
            this.txContactID.ForeColor = System.Drawing.Color.Navy;
            this.txContactID.Location = new System.Drawing.Point(97, 22);
            this.txContactID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txContactID.Name = "txContactID";
            this.txContactID.Size = new System.Drawing.Size(90, 20);
            this.txContactID.TabIndex = 31;
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.ForeColor = System.Drawing.Color.Black;
            this.lbContact.Location = new System.Drawing.Point(24, 25);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(67, 13);
            this.lbContact.TabIndex = 15;
            this.lbContact.Text = "Contact No.:";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(410, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 362);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.button6);
            this.gbPicture.Controls.Add(this.button5);
            this.gbPicture.Controls.Add(this.button4);
            this.gbPicture.Controls.Add(this.pictureBox1);
            this.gbPicture.Enabled = false;
            this.gbPicture.ForeColor = System.Drawing.Color.Firebrick;
            this.gbPicture.Location = new System.Drawing.Point(6, 6);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(126, 184);
            this.gbPicture.TabIndex = 6;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "Picture";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(52, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(81, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(23, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbTraning
            // 
            this.gbTraning.Enabled = false;
            this.gbTraning.ForeColor = System.Drawing.Color.Firebrick;
            this.gbTraning.Location = new System.Drawing.Point(6, 196);
            this.gbTraning.Name = "gbTraning";
            this.gbTraning.Size = new System.Drawing.Size(398, 172);
            this.gbTraning.TabIndex = 0;
            this.gbTraning.TabStop = false;
            this.gbTraning.Text = "Traning";
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNote.AutoSize = true;
            this.lbNote.BackColor = System.Drawing.SystemColors.Control;
            this.lbNote.ForeColor = System.Drawing.Color.Maroon;
            this.lbNote.Location = new System.Drawing.Point(497, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(147, 13);
            this.lbNote.TabIndex = 39;
            this.lbNote.Text = "Notes: All items is must fill out.\r\n";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // proDatasetBindingSource
            // 
            this.proDatasetBindingSource.DataSource = typeof(SalaryManage.Data.ProDataset);
            // 
            // StaffAddFrm
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 436);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffAddFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Staff Information";
            this.Load += new System.EventHandler(this.StaffAddFrm_Load);
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            this.gbWorker.ResumeLayout(false);
            this.gbWorker.PerformLayout();
            this.gbSalary.ResumeLayout(false);
            this.gbSalary.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabPerson.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDatasetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbWorkerName;
        private System.Windows.Forms.Label lbJobCard;
        private System.Windows.Forms.Label lbBusinessUnit;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbSkill;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbBaseSalary;
        private System.Windows.Forms.Label lbRate1;
        private System.Windows.Forms.Label lbRate2;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.TextBox txIndexNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txWorkerName;
        private System.Windows.Forms.TextBox txNationality;
        private System.Windows.Forms.TextBox txSkill;
        private System.Windows.Forms.TextBox txBaseSalary;
        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.GroupBox gbSalary;
        private System.Windows.Forms.ComboBox cbBusiness;
        private System.Windows.Forms.ComboBox cmbJobCard;
        private System.Windows.Forms.ComboBox cmbRate2;
        private System.Windows.Forms.ComboBox cmbRate1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.RadioButton rdPolicyYes;
        private System.Windows.Forms.RadioButton rdPolicyNo;
        private System.Windows.Forms.Label lbPolicy;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.GroupBox gbTraning;
        private System.Windows.Forms.ComboBox cmbIdtype;
        private System.Windows.Forms.Label lbIdtype;
        private System.Windows.Forms.TextBox txIDNum;
        private System.Windows.Forms.Label lbIdNum;
        private System.Windows.Forms.Button AddJobCardBtn;
        private System.Windows.Forms.Button AddCompanyBtn;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txContactFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdContactsGerder2;
        private System.Windows.Forms.RadioButton rdContactsGerder;
        private System.Windows.Forms.Label lbContactTel;
        private System.Windows.Forms.Label lbContactName;
        private System.Windows.Forms.TextBox txContactName;
        private System.Windows.Forms.TextBox txContactTel;
        private System.Windows.Forms.TextBox txContactID;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource proDatasetBindingSource;
    }
}