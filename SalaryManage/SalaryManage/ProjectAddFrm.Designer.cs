namespace SalaryManage
{
    partial class ProjectAddFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAddFrm));
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbProjectID = new System.Windows.Forms.Label();
            this.lbProjectTitle = new System.Windows.Forms.Label();
            this.lbContractID = new System.Windows.Forms.Label();
            this.lbSubcompanyName = new System.Windows.Forms.Label();
            this.lbManageTel = new System.Windows.Forms.Label();
            this.lbProjectClassify = new System.Windows.Forms.Label();
            this.lbDescript = new System.Windows.Forms.Label();
            this.txProjectID = new System.Windows.Forms.TextBox();
            this.txProjectTitle = new System.Windows.Forms.TextBox();
            this.txManagerName = new System.Windows.Forms.TextBox();
            this.txManageTel = new System.Windows.Forms.TextBox();
            this.txProjectClassify = new System.Windows.Forms.TextBox();
            this.txDescript = new System.Windows.Forms.TextBox();
            this.txCorpAddress = new System.Windows.Forms.TextBox();
            this.txWorkplace = new System.Windows.Forms.TextBox();
            this.lbWorkplace = new System.Windows.Forms.Label();
            this.lbCorpAddress = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbManageName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCompanyID = new System.Windows.Forms.ComboBox();
            this.utilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.utilityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(218, 327);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(5);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 11;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 327);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbProjectID
            // 
            this.lbProjectID.AutoSize = true;
            this.lbProjectID.Location = new System.Drawing.Point(19, 17);
            this.lbProjectID.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbProjectID.Name = "lbProjectID";
            this.lbProjectID.Size = new System.Drawing.Size(63, 13);
            this.lbProjectID.TabIndex = 2;
            this.lbProjectID.Text = "Project No.:";
            // 
            // lbProjectTitle
            // 
            this.lbProjectTitle.AutoSize = true;
            this.lbProjectTitle.Location = new System.Drawing.Point(50, 47);
            this.lbProjectTitle.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbProjectTitle.Name = "lbProjectTitle";
            this.lbProjectTitle.Size = new System.Drawing.Size(30, 13);
            this.lbProjectTitle.TabIndex = 3;
            this.lbProjectTitle.Text = "Title:";
            // 
            // lbContractID
            // 
            this.lbContractID.AutoSize = true;
            this.lbContractID.Location = new System.Drawing.Point(327, 47);
            this.lbContractID.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbContractID.Name = "lbContractID";
            this.lbContractID.Size = new System.Drawing.Size(68, 13);
            this.lbContractID.TabIndex = 4;
            this.lbContractID.Text = "Company ID:";
            // 
            // lbSubcompanyName
            // 
            this.lbSubcompanyName.AutoSize = true;
            this.lbSubcompanyName.Location = new System.Drawing.Point(300, 107);
            this.lbSubcompanyName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbSubcompanyName.Name = "lbSubcompanyName";
            this.lbSubcompanyName.Size = new System.Drawing.Size(33, 13);
            this.lbSubcompanyName.TabIndex = 5;
            this.lbSubcompanyName.Text = "From:";
            // 
            // lbManageTel
            // 
            this.lbManageTel.AutoSize = true;
            this.lbManageTel.Location = new System.Drawing.Point(21, 107);
            this.lbManageTel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbManageTel.Name = "lbManageTel";
            this.lbManageTel.Size = new System.Drawing.Size(61, 13);
            this.lbManageTel.TabIndex = 6;
            this.lbManageTel.Text = "Telephone:";
            // 
            // lbProjectClassify
            // 
            this.lbProjectClassify.AutoSize = true;
            this.lbProjectClassify.Location = new System.Drawing.Point(314, 17);
            this.lbProjectClassify.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbProjectClassify.Name = "lbProjectClassify";
            this.lbProjectClassify.Size = new System.Drawing.Size(81, 13);
            this.lbProjectClassify.TabIndex = 7;
            this.lbProjectClassify.Text = "Project Classify:";
            // 
            // lbDescript
            // 
            this.lbDescript.AutoSize = true;
            this.lbDescript.Location = new System.Drawing.Point(33, 166);
            this.lbDescript.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbDescript.Name = "lbDescript";
            this.lbDescript.Size = new System.Drawing.Size(34, 13);
            this.lbDescript.TabIndex = 8;
            this.lbDescript.Text = "Mark:";
            // 
            // txProjectID
            // 
            this.txProjectID.BackColor = System.Drawing.Color.Linen;
            this.txProjectID.ForeColor = System.Drawing.Color.DarkRed;
            this.txProjectID.Location = new System.Drawing.Point(88, 14);
            this.txProjectID.Margin = new System.Windows.Forms.Padding(5);
            this.txProjectID.Name = "txProjectID";
            this.txProjectID.ReadOnly = true;
            this.txProjectID.Size = new System.Drawing.Size(190, 20);
            this.txProjectID.TabIndex = 9;
            // 
            // txProjectTitle
            // 
            this.txProjectTitle.Location = new System.Drawing.Point(88, 44);
            this.txProjectTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txProjectTitle.Name = "txProjectTitle";
            this.txProjectTitle.Size = new System.Drawing.Size(190, 20);
            this.txProjectTitle.TabIndex = 1;
            // 
            // txManagerName
            // 
            this.txManagerName.Location = new System.Drawing.Point(400, 75);
            this.txManagerName.Margin = new System.Windows.Forms.Padding(5);
            this.txManagerName.Name = "txManagerName";
            this.txManagerName.Size = new System.Drawing.Size(190, 20);
            this.txManagerName.TabIndex = 4;
            // 
            // txManageTel
            // 
            this.txManageTel.Location = new System.Drawing.Point(88, 104);
            this.txManageTel.Margin = new System.Windows.Forms.Padding(5);
            this.txManageTel.Name = "txManageTel";
            this.txManageTel.Size = new System.Drawing.Size(190, 20);
            this.txManageTel.TabIndex = 5;
            // 
            // txProjectClassify
            // 
            this.txProjectClassify.Location = new System.Drawing.Point(400, 14);
            this.txProjectClassify.Margin = new System.Windows.Forms.Padding(5);
            this.txProjectClassify.Name = "txProjectClassify";
            this.txProjectClassify.Size = new System.Drawing.Size(190, 20);
            this.txProjectClassify.TabIndex = 0;
            // 
            // txDescript
            // 
            this.txDescript.Location = new System.Drawing.Point(36, 183);
            this.txDescript.Margin = new System.Windows.Forms.Padding(5);
            this.txDescript.Multiline = true;
            this.txDescript.Name = "txDescript";
            this.txDescript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txDescript.Size = new System.Drawing.Size(541, 134);
            this.txDescript.TabIndex = 10;
            // 
            // txCorpAddress
            // 
            this.txCorpAddress.Location = new System.Drawing.Point(88, 134);
            this.txCorpAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txCorpAddress.Name = "txCorpAddress";
            this.txCorpAddress.Size = new System.Drawing.Size(307, 20);
            this.txCorpAddress.TabIndex = 8;
            // 
            // txWorkplace
            // 
            this.txWorkplace.Location = new System.Drawing.Point(88, 75);
            this.txWorkplace.Margin = new System.Windows.Forms.Padding(5);
            this.txWorkplace.Name = "txWorkplace";
            this.txWorkplace.Size = new System.Drawing.Size(190, 20);
            this.txWorkplace.TabIndex = 3;
            // 
            // lbWorkplace
            // 
            this.lbWorkplace.AutoSize = true;
            this.lbWorkplace.Location = new System.Drawing.Point(18, 77);
            this.lbWorkplace.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbWorkplace.Name = "lbWorkplace";
            this.lbWorkplace.Size = new System.Drawing.Size(62, 13);
            this.lbWorkplace.TabIndex = 18;
            this.lbWorkplace.Text = "Workplace:";
            // 
            // lbCorpAddress
            // 
            this.lbCorpAddress.AutoSize = true;
            this.lbCorpAddress.Location = new System.Drawing.Point(15, 137);
            this.lbCorpAddress.Name = "lbCorpAddress";
            this.lbCorpAddress.Size = new System.Drawing.Size(67, 13);
            this.lbCorpAddress.TabIndex = 19;
            this.lbCorpAddress.Text = "Co. Address:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(338, 104);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.dtpStartDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(110, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(451, 107);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(23, 13);
            this.lbEndDate.TabIndex = 21;
            this.lbEndDate.Text = "To:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(480, 104);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(110, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // lbManageName
            // 
            this.lbManageName.AutoSize = true;
            this.lbManageName.Location = new System.Drawing.Point(343, 78);
            this.lbManageName.Name = "lbManageName";
            this.lbManageName.Size = new System.Drawing.Size(52, 13);
            this.lbManageName.TabIndex = 25;
            this.lbManageName.Text = "Manager:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(423, 137);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 27;
            this.lbStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(469, 134);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // cmbCompanyID
            // 
            this.cmbCompanyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyID.FormattingEnabled = true;
            this.cmbCompanyID.Location = new System.Drawing.Point(400, 44);
            this.cmbCompanyID.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCompanyID.Name = "cmbCompanyID";
            this.cmbCompanyID.Size = new System.Drawing.Size(190, 21);
            this.cmbCompanyID.TabIndex = 2;
            // 
            // utilityBindingSource
            // 
            this.utilityBindingSource.DataSource = typeof(SalaryManage.Utility);
            // 
            // ProjectAddFrm
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.cmbCompanyID);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbManageName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbCorpAddress);
            this.Controls.Add(this.lbWorkplace);
            this.Controls.Add(this.txWorkplace);
            this.Controls.Add(this.txCorpAddress);
            this.Controls.Add(this.txDescript);
            this.Controls.Add(this.txProjectClassify);
            this.Controls.Add(this.txManageTel);
            this.Controls.Add(this.txManagerName);
            this.Controls.Add(this.txProjectTitle);
            this.Controls.Add(this.txProjectID);
            this.Controls.Add(this.lbDescript);
            this.Controls.Add(this.lbProjectClassify);
            this.Controls.Add(this.lbManageTel);
            this.Controls.Add(this.lbSubcompanyName);
            this.Controls.Add(this.lbContractID);
            this.Controls.Add(this.lbProjectTitle);
            this.Controls.Add(this.lbProjectID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 395);
            this.Name = "ProjectAddFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Projects";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbProjectID;
        private System.Windows.Forms.Label lbProjectTitle;
        private System.Windows.Forms.Label lbContractID;
        private System.Windows.Forms.Label lbSubcompanyName;
        private System.Windows.Forms.Label lbManageTel;
        private System.Windows.Forms.Label lbProjectClassify;
        private System.Windows.Forms.Label lbDescript;
        private System.Windows.Forms.TextBox txProjectID;
        private System.Windows.Forms.TextBox txProjectTitle;
        private System.Windows.Forms.TextBox txManagerName;
        private System.Windows.Forms.TextBox txManageTel;
        private System.Windows.Forms.TextBox txProjectClassify;
        private System.Windows.Forms.TextBox txDescript;
        private System.Windows.Forms.TextBox txCorpAddress;
        private System.Windows.Forms.TextBox txWorkplace;
        private System.Windows.Forms.Label lbWorkplace;
        private System.Windows.Forms.Label lbCorpAddress;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbManageName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCompanyID;
        private System.Windows.Forms.BindingSource utilityBindingSource;

    }
}