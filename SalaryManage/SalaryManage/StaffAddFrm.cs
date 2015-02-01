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
using SalaryManage.Data;



namespace SalaryManage
{
    public partial class StaffAddFrm : Form
    {
        private Dbaccess dba;

        public Person person = null;

        /*
        public StaffAddFrm()
        {
            InitializeComponent();
        }
        */

        public StaffAddFrm(object obj)
        {
            InitializeComponent();
            if (obj != null)
                person = (Person)obj;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffAddFrm_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Hide();
            cmbCompanyItemLoad();
            cmbJobCardItemLoad();
            if (Utility.Optype == OpreatType.add)
            {
                tabControl1.SelectedTab = tabPerson;
                ///自动加载工人编号
                string workNo = Utility.WorkerNumberHead + DateTime.Now.ToString("yyyy-MMdd-hhmmss") + Utility.WorkerNumberEnd;
                txIndexNo.Text = workNo;
               ///按照指定值加载初始化资料
                cmbGender.SelectedIndex = 0;
                cmbAge.SelectedIndex = 1;
                cmbIdtype.SelectedIndex = 1;
                cmbRate1.SelectedIndex = 2;
                cmbRate2.SelectedIndex = 2;
                cmbGrade.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now.AddYears(1);
            }
            else if (Utility.Optype == OpreatType.edit) 
            {
                txIndexNo.Text = person.WorkerNum;
                cbBusiness.Text = person.CompanyID;
                cmbJobCard.Text = person.ProjectID;
                txWorkerName.Text = person.WorkerName;
                txNationality.Text = person.Nationality;
                cmbGender.Text = person.Gender ? "Male" : "Female";
                cmbAge.Text = person.Age;
                cmbIdtype.Text = person.Idtype;
                txIDNum.Text = person.IdNumber;
                txSkill.Text = person.Skill;
                cmbGrade.Text = person.Grade;
                rdPolicyNo.Checked = person.Policy;
                rdPolicyYes.Checked = !person.Policy;
                dateTimePicker1.Text = person.RegDate;
                dateTimePicker2.Text = person.ContractPeriod;
                txBaseSalary.Text = person.BaseSalary.ToString();
                cmbRate1.Text = person.Rate1.ToString();
                cmbRate2.Text = person.Rate2.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabControl1.TabPages[0]) 
            {
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                return; 
            }
            if (Utility.Optype == OpreatType.add)
            {
                AppendPerson();
            }
            else if (Utility.Optype == OpreatType.edit)
            {
                AppendPerson();
            }
            else if (Utility.Optype == OpreatType.delet)
            {

            }
        }


        /// <summary>
        /// 添加一个记录
        /// </summary>
        private void AppendPerson()
        {
            //检查空值
            if (!IsHaveEmpty()) return;

            dba = new Dbaccess();
            if (Utility.Optype == OpreatType.add)   //添加
            {      //检查重复
                person = AssignPersonData(OpreatType.add);
                string sql = "select * from staffs where (wWorkerNum = '" + person.WorkerNum +
                             "') or ((wIdtype = '" + person.Idtype +
                             "') and (wIdNumber = '" + person.IdNumber + "'))";
                DataTable thedt = dba.ReadDatas(sql, false);
                if (thedt.Rows.Count >= 1)
                {
                    MessageBox.Show("This employee data already exists in the database.");
                    return;
                }

                //执行 SQL 命令
                if (dba.SavePersonData(person))
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

                person = AssignPersonData(OpreatType.edit);
                if (dba.UpdatePersonData(person))
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


        private bool IsHaveEmpty()
        {
            bool isempty = true;
            Control[] txitems = new Control[] { 
                                cbBusiness, 
                                //cbJobCard, 
                                txWorkerName, 
                                txNationality, 
                                cmbGender, 
                                cmbAge, 
                                cmbIdtype, 
                                txIDNum, 
                                txSkill, 
                                cmbGrade, 
                                rdPolicyNo, 
                                dateTimePicker1, 
                                dateTimePicker2, 
                                txBaseSalary, 
                                cmbRate1, 
                                cmbRate2 };
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


        /// <summary>
        /// 赋值 person
        /// </summary>
        /// <returns></returns>
        private Person AssignPersonData(OpreatType type)
        {
            Person pers = new Person();
            pers.WorkerNum = txIndexNo.Text;
            pers.CompanyID = (string) cbBusiness.SelectedValue;
            pers.ProjectID = (string) cmbJobCard.SelectedValue;
            pers.WorkerName = txWorkerName.Text;
            pers.Nationality = txNationality.Text;
            pers.Gender = cmbGender.Text == "Male" ? true : false;
            pers.Age = cmbAge.Text;
            pers.Idtype = cmbIdtype.Text;
            pers.IdNumber = txIDNum.Text;
            pers.Skill = txSkill.Text;
            pers.Grade = cmbGrade.Text;
            pers.Policy = rdPolicyNo.Checked;
            string riqi = dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm:ss");
            if (type == OpreatType.add)
            {
                pers.RegDate = riqi;
                pers.EditDate = riqi;
            }
            else
            {
                pers.EditDate = riqi;
            }
            pers.ContractPeriod = dateTimePicker2.Value.ToString("dd/MM/yyyy hh:mm:ss");
            pers.LeaveDate = "";
            pers.Editer = Utility.LoginUser;
            pers.Active = true;
            pers.Descript = "";
            pers.BaseSalary = float.Parse(txBaseSalary.Text);
            pers.Rate1 = float.Parse(cmbRate1.Text);
            pers.Rate2 = float.Parse(cmbRate2.Text);
            return pers;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabSelectChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPerson) { lbNote.Visible = true; }
            else lbNote.Visible = false;
        }



        /**********************/
        private void cmbJobCardItemLoad()
        {
            DataTable jobItemsTable = ProDataset.JobCardDataSource;
            cmbJobCard.DataSource = jobItemsTable;
            cmbJobCard.DisplayMember = jobItemsTable.Columns["pName"].ColumnName;
            cmbJobCard.ValueMember = jobItemsTable.Columns["ProjectID"].ColumnName;
        }


        private void cmbCompanyItemLoad()
        {
            DataTable tableCorps = ProDataset.CorpDataSource;
            cbBusiness.DataSource = tableCorps;
            cbBusiness.DisplayMember = tableCorps.Columns["cCorpName"].ColumnName;
            cbBusiness.ValueMember = tableCorps.Columns["cCorpID"].ColumnName;
        }

        private void AddCompanyBtn_Click(object sender, EventArgs e)
        {
            CompanyAddFrm caf = new CompanyAddFrm(null);
            if (caf.ShowDialog() == DialogResult.OK)
            {
                cmbCompanyItemLoad();
            }
        }

        private void AddJobCardBtn_Click(object sender, EventArgs e)
        {
            ProjectAddFrm paf = new ProjectAddFrm(null);
            if (paf.ShowDialog() == DialogResult.OK)
            {
                cmbJobCardItemLoad();
            }
        }


    }

}
