using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SalaryManage.DBConecte;
using SalaryManage.Methods;
using SalaryManage.Data;

namespace SalaryManage
{
    public partial class ProjectAddFrm : Form
    {
        private Dbaccess dba;
        private Projects proj;

        public ProjectAddFrm(object pjObj)
        {
            InitializeComponent();
            if (pjObj != null)
                proj = (Projects) pjObj;
        }



        private void Form_Load(object sender, EventArgs e)
        {
            string ProjectNo = "PJ" + DateTime.Now.ToString("yyyy-MMdd-hhmmss") + Utility.WorkerNumberEnd;
            cmbCompanyItemLoad();

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(1);
            cmbStatus.DataSource = new string[] { "", "Underway", "Complete", "Suspend", "Other" };
            if (Utility.Optype == OpreatType.add)
            {
                txProjectID.Text = ProjectNo;
            }
            else // (Utility.Optype == OpreatType.edit)
            {
                txProjectID.Text = proj.ProjectID;
                txProjectTitle.Text = proj.ProjectName;
                txProjectClassify.Text = proj.Classify;
                cmbCompanyID.Text = proj.ContractID;
                txWorkplace.Text = proj.Workplace;
                txProjectTitle.Text = proj.Contents;
                txManagerName.Text = proj.Manager;
                txManageTel.Text = proj.ManageTel;
                dtpStartDate.Value = DateTime.Parse(proj.StartDate);
                dtpEndDate.Value = DateTime.Parse(proj.EndDate);
                txCorpAddress.Text = proj.CorpID;
                cmbStatus.SelectedIndex = proj.Status;
                txDescript.Text = proj.Remark;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!IsEmptyValue()) return;
            dba = new Dbaccess();
            if (Utility.Optype == OpreatType.add)   //添加
            {      //检查重复
                proj = GetProjectData(OpreatType.add);
                string sql = "select * from staffs where (wWorkerNum = '" + proj.ProjectID +
                             "')" /* + or ((wIdtype = '" + person.Idtype +
                             "') and (wIdNumber = '" + person.IdNumber + "'))" */;
                DataTable thedt = dba.ReadDatas(sql, false);
                if (thedt.Rows.Count >= 1)
                {
                    MessageBox.Show("This employee data already exists in the database.");
                    return;
                }

                //执行 SQL 命令
                if (dba.SavProjectData(proj))
                {
                    System.Windows.Forms.MessageBox.Show("Operation Successfuly.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation Fail.\nErrorCode: >> " + dba.ErrorCode);
                }
            }

            if (Utility.Optype == OpreatType.edit)  //编辑
            {

                proj = GetProjectData(OpreatType.edit);
                if (dba.UpdateProjectData(proj))
                {
                    System.Windows.Forms.MessageBox.Show("Update Data Successfuly.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation Fail.\nErrorCode: >> " + dba.ErrorCode);
                }
            }
        }

        
        
        //=========================================//

        private bool IsEmptyValue()
        {
            bool isempty = true;
            Control[] txitems = new Control[] { 
                                txProjectClassify, 
                                //cbJobCard, 
                                txProjectTitle, 
                                cmbCompanyID, 
                                txWorkplace, 
                                txManagerName, 
                                txManageTel, 
                                txCorpAddress,
                                cmbStatus };
            foreach (Control item in txitems)
            {
                if (item.Text.Trim() == "")
                {
                    item.Focus();
                    MessageBox.Show("Please complete information.");
                    return false;
                }
            }
            return isempty;
        }


        private Projects GetProjectData(OpreatType optype){
            Projects pj = new Projects();
            pj.ProjectID = txProjectID.Text;
            pj.ProjectName = txProjectTitle.Text;
            pj.Classify = txProjectClassify.Text;
            pj.ContractID = cmbCompanyID.Text;
            pj.Workplace = txWorkplace.Text;
            pj.Contents = txProjectTitle.Text;
            pj.Manager = txManagerName.Text;
            pj.ManageTel = txManageTel.Text;
            pj.StartDate = dtpStartDate.Value.ToString();
            pj.EndDate = dtpEndDate.Value.ToString();
            pj.CorpID = txCorpAddress.Text;
            pj.Status = cmbStatus.SelectedIndex + 1;
            pj.Remark = txDescript.Text;
            return pj;
        }



        private void cmbCompanyItemLoad()
        {
            DataTable tableCorps = ProDataset.CorpDataSource;
            cmbCompanyID.DataSource = tableCorps;
            cmbCompanyID.DisplayMember = tableCorps.Columns["cCorpName"].ColumnName;
            cmbCompanyID.ValueMember = tableCorps.Columns["cCorpID"].ColumnName;
        }
    }
}
