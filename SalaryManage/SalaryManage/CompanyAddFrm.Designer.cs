namespace SalaryManage
{
    partial class CompanyAddFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyAddFrm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbCompanyID = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbProjectID = new System.Windows.Forms.Label();
            this.lbCompanyAddress = new System.Windows.Forms.Label();
            this.lbCompanyTel = new System.Windows.Forms.Label();
            this.lbCorporate = new System.Windows.Forms.Label();
            this.lbContract = new System.Windows.Forms.Label();
            this.lbRemark = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txCompanyID = new System.Windows.Forms.TextBox();
            this.txCompanyName = new System.Windows.Forms.TextBox();
            this.txProjectID = new System.Windows.Forms.TextBox();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txCompanyTel = new System.Windows.Forms.TextBox();
            this.txCorporate = new System.Windows.Forms.TextBox();
            this.txContract = new System.Windows.Forms.TextBox();
            this.txRemark = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecute.Location = new System.Drawing.Point(164, 305);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbCompanyID
            // 
            this.lbCompanyID.AutoSize = true;
            this.lbCompanyID.Location = new System.Drawing.Point(12, 17);
            this.lbCompanyID.Name = "lbCompanyID";
            this.lbCompanyID.Size = new System.Drawing.Size(68, 13);
            this.lbCompanyID.TabIndex = 14;
            this.lbCompanyID.Text = "Company ID:";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(26, 47);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(54, 13);
            this.lbCompanyName.TabIndex = 3;
            this.lbCompanyName.Text = "Company:";
            // 
            // lbProjectID
            // 
            this.lbProjectID.AutoSize = true;
            this.lbProjectID.Location = new System.Drawing.Point(23, 107);
            this.lbProjectID.Name = "lbProjectID";
            this.lbProjectID.Size = new System.Drawing.Size(57, 13);
            this.lbProjectID.TabIndex = 4;
            this.lbProjectID.Text = "Project ID:";
            // 
            // lbCompanyAddress
            // 
            this.lbCompanyAddress.AutoSize = true;
            this.lbCompanyAddress.Location = new System.Drawing.Point(32, 77);
            this.lbCompanyAddress.Name = "lbCompanyAddress";
            this.lbCompanyAddress.Size = new System.Drawing.Size(48, 13);
            this.lbCompanyAddress.TabIndex = 5;
            this.lbCompanyAddress.Text = "Address:";
            // 
            // lbCompanyTel
            // 
            this.lbCompanyTel.AutoSize = true;
            this.lbCompanyTel.Location = new System.Drawing.Point(308, 77);
            this.lbCompanyTel.Name = "lbCompanyTel";
            this.lbCompanyTel.Size = new System.Drawing.Size(72, 13);
            this.lbCompanyTel.TabIndex = 6;
            this.lbCompanyTel.Text = "Company Tel:";
            // 
            // lbCorporate
            // 
            this.lbCorporate.AutoSize = true;
            this.lbCorporate.Location = new System.Drawing.Point(324, 17);
            this.lbCorporate.Name = "lbCorporate";
            this.lbCorporate.Size = new System.Drawing.Size(56, 13);
            this.lbCorporate.TabIndex = 7;
            this.lbCorporate.Text = "Corporate:";
            // 
            // lbContract
            // 
            this.lbContract.AutoSize = true;
            this.lbContract.Location = new System.Drawing.Point(330, 47);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(50, 13);
            this.lbContract.TabIndex = 8;
            this.lbContract.Text = "Contract:";
            // 
            // lbRemark
            // 
            this.lbRemark.AutoSize = true;
            this.lbRemark.Location = new System.Drawing.Point(33, 138);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Size = new System.Drawing.Size(47, 13);
            this.lbRemark.TabIndex = 9;
            this.lbRemark.Text = "Remark:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(340, 107);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status:";
            // 
            // txCompanyID
            // 
            this.txCompanyID.BackColor = System.Drawing.Color.LavenderBlush;
            this.txCompanyID.Location = new System.Drawing.Point(83, 14);
            this.txCompanyID.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txCompanyID.Name = "txCompanyID";
            this.txCompanyID.ReadOnly = true;
            this.txCompanyID.Size = new System.Drawing.Size(150, 20);
            this.txCompanyID.TabIndex = 0;
            // 
            // txCompanyName
            // 
            this.txCompanyName.Location = new System.Drawing.Point(83, 44);
            this.txCompanyName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txCompanyName.Name = "txCompanyName";
            this.txCompanyName.Size = new System.Drawing.Size(208, 20);
            this.txCompanyName.TabIndex = 1;
            // 
            // txProjectID
            // 
            this.txProjectID.Location = new System.Drawing.Point(83, 104);
            this.txProjectID.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txProjectID.Name = "txProjectID";
            this.txProjectID.Size = new System.Drawing.Size(150, 20);
            this.txProjectID.TabIndex = 5;
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(83, 74);
            this.txAddress.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(208, 20);
            this.txAddress.TabIndex = 3;
            // 
            // txCompanyTel
            // 
            this.txCompanyTel.Location = new System.Drawing.Point(383, 74);
            this.txCompanyTel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txCompanyTel.Name = "txCompanyTel";
            this.txCompanyTel.Size = new System.Drawing.Size(100, 20);
            this.txCompanyTel.TabIndex = 4;
            // 
            // txCorporate
            // 
            this.txCorporate.Location = new System.Drawing.Point(383, 14);
            this.txCorporate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txCorporate.Name = "txCorporate";
            this.txCorporate.Size = new System.Drawing.Size(100, 20);
            this.txCorporate.TabIndex = 0;
            // 
            // txContract
            // 
            this.txContract.Location = new System.Drawing.Point(383, 44);
            this.txContract.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txContract.Name = "txContract";
            this.txContract.Size = new System.Drawing.Size(100, 20);
            this.txContract.TabIndex = 2;
            // 
            // txRemark
            // 
            this.txRemark.Location = new System.Drawing.Point(36, 156);
            this.txRemark.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txRemark.Multiline = true;
            this.txRemark.Name = "txRemark";
            this.txRemark.Size = new System.Drawing.Size(447, 136);
            this.txRemark.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(383, 104);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // CompanyAddFrm
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 340);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txRemark);
            this.Controls.Add(this.txContract);
            this.Controls.Add(this.txCorporate);
            this.Controls.Add(this.txCompanyTel);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.txProjectID);
            this.Controls.Add(this.txCompanyName);
            this.Controls.Add(this.txCompanyID);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbRemark);
            this.Controls.Add(this.lbContract);
            this.Controls.Add(this.lbCorporate);
            this.Controls.Add(this.lbCompanyTel);
            this.Controls.Add(this.lbCompanyAddress);
            this.Controls.Add(this.lbProjectID);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbCompanyID);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 367);
            this.Name = "CompanyAddFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Company";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lbCompanyID;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbProjectID;
        private System.Windows.Forms.Label lbCompanyAddress;
        private System.Windows.Forms.Label lbCompanyTel;
        private System.Windows.Forms.Label lbCorporate;
        private System.Windows.Forms.Label lbContract;
        private System.Windows.Forms.Label lbRemark;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txCompanyID;
        private System.Windows.Forms.TextBox txCompanyName;
        private System.Windows.Forms.TextBox txProjectID;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txCompanyTel;
        private System.Windows.Forms.TextBox txCorporate;
        private System.Windows.Forms.TextBox txContract;
        private System.Windows.Forms.TextBox txRemark;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}