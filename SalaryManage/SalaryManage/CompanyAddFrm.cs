using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SalaryManage.Methods;
using SalaryManage.DBConecte;

namespace SalaryManage
{
    public partial class CompanyAddFrm : Form
    {
        private Corps corps;
        private Dbaccess dba;


        public CompanyAddFrm(object paraObj)
        {
            InitializeComponent();
            corps = (Corps) paraObj;
        }

        private void Form_Load(object sender, EventArgs e)
        {

            if (Utility.Optype == OpreatType.add)
            {
                txCompanyID.Text = "CID-" + DateTime.Now.ToString("yyMMdd-hhmmss") + Utility.WorkerNumberEnd;
                txCompanyName.Text = "";
                txProjectID.Text = "";
                txAddress.Text = "";
                txCompanyTel.Text = "";
                txCorporate.Text = "";
                txContract.Text = "";
                txRemark.Text = "";
                cmbStatus.Text = "Active";
            }
            else
            {
                txCompanyID.Text  = corps.CorpID;
                txCompanyName.Text = corps.CorpName;
                txProjectID.Text = corps.Project;
                txAddress.Text = corps.Address;
                txCompanyTel.Text = corps.Telphone;
                txCorporate.Text = corps.Corporation;
                txContract.Text = corps.Contract;
                txRemark.Text = corps.Mark;
                cmbStatus.Text = (corps.Status == 1) ? "Active" : "Inactive";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (AddAndUpdateInfo())
                DialogResult = DialogResult.OK;
        }


        private bool AddAndUpdateInfo()
        {
            bool isExecute = false;
            Control[] ctls = new Control[] { txCompanyID, txCompanyName, txCorporate, txContract, txAddress, txCompanyTel };
            //查空
            foreach (Control item in ctls)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Please fill the necessary projects.");
                    item.Focus();
                    return false;
                }
            }
            dba = new Dbaccess();
            getCorps();
            try
            {
                //添加信息
                if (Utility.Optype == OpreatType.add)
                {   
                    //查重
                    string sqlstr = "";
                    isExecute = dba.SaveCompanyData(corps);
                }
                if (Utility.Optype == OpreatType.edit) {
                    isExecute = dba.UpdateCompanyData(corps);
                }
                
                if (isExecute)
                    MessageBox.Show("Operation successful.\nData had be saved to database.");
                else
                    MessageBox.Show("Operation fail. Error:\n" + dba.ErrorCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation fail. Error:\n" + ex.Message);
                isExecute = false;
            }

            return isExecute;
        }


        public Corps getCorps()
        {
            corps = new Corps();
            corps.CorpID = txCompanyID.Text;
            corps.CorpName = txCompanyName.Text;
            corps.Project = txProjectID.Text;
            corps.Address = txAddress.Text;
            corps.Telphone = txCompanyTel.Text;
            corps.Corporation = txCorporate.Text;
            corps.Contract = txContract.Text;
            corps.Mark = txRemark.Text;
            corps.Status = cmbStatus.Text == "Active" ? 1 : 0;
            return corps;
        }
    }
}
