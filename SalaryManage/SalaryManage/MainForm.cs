using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SalaryManage.Methods;
using SalaryManage.DBConecte;
using SalaryManage.Data;

namespace SalaryManage
{
    public partial class MainForm : Form
    {
        Dbaccess dba = new Dbaccess();
        DataTable dt = new DataTable();
        ProDataset pdt = new ProDataset();

        public FLAG flag = FLAG.STAFF;
        public ListView currentLView = null;
        public ProDataset pds;

        public MainForm()
        {
            InitializeComponent();
            skinEgin.SkinFile = "SkinAll/MSN.SSK";
        }



    #region 事件响应
        
        /// <summary>
        /// 加载窗体
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            CurrentLoginUser.Text = Utility.LoginUser;
            ///权限设定
            Utility.Authorizes = UserAuthorize.AdminisUsers;
            if (Utility.Authorizes == UserAuthorize.OrdinaryUsers)
            {
                toolEditBtn.Enabled = false;
                toolDeleteBtn.Enabled = false;
            }
            else if (Utility.Authorizes == UserAuthorize.AdvanceUsers)
            {
                toolEditBtn.Enabled = true;
                toolDeleteBtn.Enabled = false;
            }
            else
            {
                toolEditBtn.Enabled = true;
                toolDeleteBtn.Enabled = true;
            }
            currentLView = lvWorker;
            pds = new ProDataset("");
            LoadCorpsComboItems();
            LoadProjectComboItems();


            //加载显示列表
            LoadStaffInfoToList();
            LoadProjectsInfoToList();
            LoadCompanyInfoToList();

            MainTimer.Tick += new EventHandler(HandleTimer);
            MainTimer.Start();

            
            DataTable dtest = ProDataset.CorpDataSource;
        }

        /// <summary>
        /// 时间处理
        /// </summary>
        private void HandleTimer(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("dd MMMM yyyy,  hh:mm:ss");
        }

        /// <summary>
        /// 程序退出
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 工具栏按钮 [添加]
        /// </summary>
        private void toolAddBtn_Click(object sender, EventArgs e)
        {
            Utility.Optype = OpreatType.add;
            AddNewInfo(null);
        }

        /// <summary>
        /// 工具栏按钮 [编辑]
        /// </summary>
        private void toolEditBtn_Click(object sender, EventArgs e)
        {
            if (currentLView == null) return;
            if (currentLView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a item in list, Please.");
                return;
            }

            Utility.Optype = OpreatType.edit;
            UpdateInfo(currentLView.SelectedItems[0].Tag);
        }

        /// <summary>
        /// 工具栏按钮 [删除]
        /// </summary>
        private void toolDeleteBtn_Click(object sender, EventArgs e)
        {
            if (currentLView == null) return;
            if (currentLView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select a item in list, Please.");
                return;
            }
            string msgStr = "This operation will delete you have chosen to data. \nAre you sure to continue?";
            if (MessageBox.Show(msgStr, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Utility.Optype = OpreatType.delet;
                DeleteInfo(currentLView.SelectedItems[0].Tag);
            }
        }

        /// <summary>
        /// 工具栏按钮 [列表]
        /// </summary>
        private void toolListBtn_Click(object sender, EventArgs e)
        {
            if (flag == FLAG.STAFF)
            {
                cmbCompany.SelectedIndex = -1;
                cmbJobCard.SelectedIndex = -1;
                RefreshListview(currentLView);
            }
        }


        /// <summary>
        /// 员工选项改变 [lvWorker]
        /// </summary>
        private void StaffItemChange(object sender, EventArgs e)
        {
            if (lvWorker.SelectedItems.Count == 0) return;

            //Person per = (Person)lvWorker.SelectedItems[0].Tag;
            DataTable retdt = dba.ReadDatas("Select * from staffs where wActive = true and wWorkerNum = '" +
                currentLView.SelectedItems[0].SubItems[1].Text + "'", false);
            Person per = new Person(retdt.Rows[0]);
            
            //txStaffDetail.Text = "";
            //{
            //    txStaffDetail.Text += "Worker Number >>> \t" + per.WorkerNum + "\r\n";
            //    txStaffDetail.Text += "Company >>> \t" + per.CompanyID + "\r\n";
            //    txStaffDetail.Text += "Project >>> \t" + per.ProjectID + "\r\n";
            //    txStaffDetail.Text += "Worker Name >>> \t" + per.WorkerName + "\r\n";
            //}
        }

        /// <summary>
        /// Tab 页 [改变]
        /// </summary>
        private void tabIndexChange(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == null) return;
            if (tabControlMain.SelectedTab == tabPageWorkers)
            {
                flag = FLAG.STAFF;
                currentLView = lvWorker;
            }
            else if (tabControlMain.SelectedTab == tabPageProjects)
            {
                flag = FLAG.PROJECT;
                currentLView = lvProjects;
            }
            else if (tabControlMain.SelectedTab == tabPageCompany)
            {
                flag = FLAG.CORP;
                currentLView = lvCompanys;
            }
            else
            {
                flag = FLAG.MAINTANCE;
                currentLView = null;
                return;
            }
            RefreshListview(currentLView);
        }

    #endregion End事件响应



    # region 列表定义
        /// <summary>
        /// 加载员工信息
        /// </summary>
        private void LoadStaffInfoToList()
        {
            LoadWorkerColumHead();
            lvWorker.Scrollable = true;
            ReLoadStaffInfo();
        }

        /// <summary>
        /// 加载项目信息
        /// </summary>
        private void LoadProjectsInfoToList()
        {
            LoadProjectColumHead();
            lvProjects.Scrollable = true;
            ReLoadProjectInfo();
        }

        /// <summary>
        /// 加载公司信息
        /// </summary>
        private void LoadCompanyInfoToList()
        {
            LoadCompanyColumHead();
            lvCompanys.Scrollable = true;
            ReLoadCompanyInfo();
        }

        /// <summary>
        /// 员工列表头
        /// </summary>
        private void LoadWorkerColumHead()
        {
            lvWorker.Columns.Add("No.", 40, HorizontalAlignment.Left);
            lvWorker.Columns.Add("Work Code.", 130, HorizontalAlignment.Left);
            lvWorker.Columns.Add("Staff Name", 200, HorizontalAlignment.Center);
            lvWorker.Columns.Add("Skill", 190, HorizontalAlignment.Left);
            lvWorker.Columns.Add("Work Place", 190, HorizontalAlignment.Left);
            lvWorker.Columns.Add("Nationality", 80, HorizontalAlignment.Center);
            lvWorker.Columns.Add("Skiller Rating", 75, HorizontalAlignment.Left);
            lvWorker.Columns.Add("Policy", 75, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 项目列表头
        /// </summary>
        private void LoadProjectColumHead()
        {
            lvProjects.Columns.Add("No.", 40, HorizontalAlignment.Left);
            lvProjects.Columns.Add("Project No.", 130, HorizontalAlignment.Left);
            lvProjects.Columns.Add("Classify", 130, HorizontalAlignment.Left);
            lvProjects.Columns.Add("Project Name", 220, HorizontalAlignment.Center);
            lvProjects.Columns.Add("Company Title", 240, HorizontalAlignment.Left);
            lvProjects.Columns.Add("Contracts", 180, HorizontalAlignment.Center);
            lvProjects.Columns.Add("Contract Address", 190, HorizontalAlignment.Left);
            lvProjects.Columns.Add("Contract Phone", 100, HorizontalAlignment.Left);
            lvProjects.Columns.Add("project Status", 80, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 公司列表头
        /// </summary>
        private void LoadCompanyColumHead()
        {
            //cCorpID, cCorpName, comProject, comAddress, comTel, comCorporation, comContractID, comDescript
            lvCompanys.Columns.Add("No.", 40, HorizontalAlignment.Left);
            lvCompanys.Columns.Add("Company No.", 130, HorizontalAlignment.Left);
            lvCompanys.Columns.Add("Name", 220, HorizontalAlignment.Left);
            lvCompanys.Columns.Add("Address", 190, HorizontalAlignment.Left);
            lvCompanys.Columns.Add("Principal", 180, HorizontalAlignment.Center);
            lvCompanys.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            lvCompanys.Columns.Add("Classify", 130, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 刷新员工列表
        /// </summary>
        private void ReLoadStaffInfo()
        {
            string sqlCommandStr = "";
            ListViewItem lvi;
            DataTable theDt = new DataTable();

            sqlCommandStr = "Select * From Staffs Where wActive = " + true;
            if (cmbCompany.SelectedIndex > 0)
            {
                sqlCommandStr += " and wCompanyID = '" + cmbCompany.SelectedValue + "'";
            }
            if (cmbJobCard.SelectedIndex > 0)
            {
                sqlCommandStr += " and wProjectID = '" + cmbJobCard.SelectedValue + "'";
            }
            sqlCommandStr += " Order by wWorkerNum";
            try
            {
                dba = new Dbaccess();
                theDt = dba.getDataTable(sqlCommandStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string[] lvSubItems;
            int j = 0;
            lvWorker.Items.Clear();
            if (theDt.Rows.Count <= 0) return;
            foreach (DataRow newdr in theDt.Rows)
            {
                lvSubItems = new string[] { (j + 1).ToString().ToString(), 
                                        newdr["wWorkerNum"].ToString(), 
                                        newdr["wName"].ToString(), 
                                        newdr["wNationality"].ToString(), 
                                        newdr["wIdtype"].ToString(), 
                                        newdr["wSkill"].ToString(), 
                                        newdr["wGrade"].ToString(), 
                                        newdr["wBaseSalary"].ToString(),
                                        (bool) newdr["wPolicy"] ? "Yes" : "No"};    //.ToString() };
                lvi = new ListViewItem(lvSubItems);
                lvi.Tag = new Person(newdr);
                if (j % 2 == 0)
                {
                    lvi.BackColor = Color.FromArgb(250, 248, 255, 248);
                }
                lvWorker.Items.Add(lvi);
                j++;
            }
        }

        /// <summary>
        /// 刷新项目列表
        /// </summary>
        private void ReLoadProjectInfo()
        {
            ListViewItem lvi;
            DataTable theDt = new DataTable();
            try
            {
                dba = new Dbaccess();
                theDt = dba.ReadDatas("Select * From Projects where pstatus >= 0", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (theDt.Rows.Count <= 0) return;
            string[] lvSubItems;
            int j = 0;
            lvProjects.Items.Clear();
            foreach (DataRow newdr in theDt.Rows)
            {
                lvSubItems = new string[] { (j + 1).ToString().ToString(), 
                                        newdr["ProjectID"].ToString(), 
                                        newdr["pClassify"].ToString(), 
                                        newdr["pName"].ToString(), 
                                        newdr["pContractID"].ToString(), 

                                        newdr["pCorpID"].ToString(), 
                                        //newdr["Contract Address"].ToString(), 
                                        //newdr["Contract Phone"].ToString(),
                                        newdr["pStatus"].ToString() };
                lvi = new ListViewItem(lvSubItems);
                lvi.Tag = new Projects(newdr);
                if (j % 2 == 0)
                {
                    lvi.BackColor = Color.FromArgb(250, 248, 255, 248);
                }
                lvProjects.Items.Add(lvi);
                j++;
            }
        }

        /// <summary>
        /// 刷新公司列表
        /// </summary>
        private void ReLoadCompanyInfo()
        {
            ListViewItem lvi;
            DataTable theDt = new DataTable();
            try
            {
                dba = new Dbaccess();
                theDt = dba.ReadDatas("Select * From Corps where comStatus > 0", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (theDt.Rows.Count <= 0) return;
            string[] lvSubItems;
            int j = 0;
            lvCompanys.Items.Clear();
            foreach (DataRow newdr in theDt.Rows)
            {
                lvSubItems = new string[] { (j + 1).ToString().ToString(), 
                                        newdr["cCorpID"].ToString(), 
                                        newdr["cCorpName"].ToString(), 
                                        newdr["comAddress"].ToString(), 
                                        newdr["comCorporation"].ToString(), 
                                        newdr["comTel"].ToString(), 
                                        newdr["comClassify"].ToString(), 
                                        /*
                                         * newdr["comContractID"].ToString(),
                                        newdr["comDescript"].ToString() */};
                lvi = new ListViewItem(lvSubItems);
                lvi.Tag = new Corps(newdr);
                if (j % 2 == 0)
                {
                    lvi.BackColor = Color.FromArgb(250, 248, 255, 248);
                }
                lvCompanys.Items.Add(lvi);
                j++;
            }
        }

# endregion 结束列表头部


        #region 功能、方法

        private void RefreshListview(ListView lv)
        {
            if (flag == FLAG.STAFF)
                ReLoadStaffInfo();
            else if (flag == FLAG.PROJECT)
                ReLoadProjectInfo();
            else if (flag == FLAG.CORP)
                ReLoadCompanyInfo();
        }



        /// <summary>
        /// 添加信息
        /// </summary>
        private void AddNewInfo(object person)
        {
            Form curFm = null;
            if (flag == FLAG.STAFF)
            {
                curFm = new StaffAddFrm(person);
            }
            else if (flag == FLAG.PROJECT)
            {
                curFm = new ProjectAddFrm(person);
            }
            else if (flag == FLAG.CORP)
            {
                curFm = new CompanyAddFrm(person);
            }
            if (curFm == null) return;
            if (curFm.ShowDialog() == DialogResult.OK) 
                RefreshListview(currentLView);
            if (flag == FLAG.STAFF)
            {
                LoadCorpsComboItems();
                LoadProjectComboItems();
            }
        }

        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="upObj"></param>
        private void UpdateInfo(object upObj)
        {
            Form curFm = null;
            if (flag == FLAG.STAFF)
                curFm = new StaffAddFrm(upObj);
            else if (flag == FLAG.PROJECT)
                curFm = new ProjectAddFrm(upObj);
            else if (flag == FLAG.CORP)
                curFm = new CompanyAddFrm(upObj);

            if (curFm.ShowDialog() == DialogResult.OK)
                RefreshListview(currentLView);
        }

        /// <summary>
        /// 删除信息
        /// </summary>
        private void DeleteInfo(object obj)
        {
            dba = new Dbaccess();
            string sqlstr = "";

            if (flag == FLAG.STAFF)
            {
                Person per = (Person)obj;
                sqlstr = "update staffs set wActive = " + false + " where wWorkerNum = '" + per.WorkerNum + "'";
            }
            else if (flag == FLAG.PROJECT)
            {
                Projects proj = (Projects) obj;
                sqlstr = "update Projects set pStatus = " + (-1) + " where ProjectID = '" + proj.ProjectID + "'";
            }
            else if (flag == FLAG.CORP)
            {
                Corps corps = (Corps) obj;
                sqlstr = "update Corps set comStatus = " + (-1) + " where cCorpID = '" + corps.CorpID + "'";
            }
            dba.ExecSql(sqlstr, false);
            if ((int)dba.retObject == 1)
            {
                MessageBox.Show("Delete data successful.");
                RefreshListview(currentLView);
            }
            else
            {
                MessageBox.Show("Delete data fail. Reason:\n" + dba.ErrorCode);
            }
        }


    #endregion End 功能、方法

        /// <summary>
        /// ComboBox 选项改变时的动作
        /// </summary>
        private void CorpCmbBoxChange(object sender, EventArgs e)
        {
            ReLoadStaffInfo();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sqlCommandStr = "";
            if (flag == FLAG.STAFF)
            {
                sqlCommandStr = "SELECT wWorkerNum, wName, wNationality, wIdtype, wSkill, wGrade, wBaseSalary, wPolicy " +
                                "FROM staffs " +
                                "WHERE (wActive = True)";
                if (cmbFind.SelectedText == "")
                {
                    sqlCommandStr += " AND (wName LIKE '%" + txFind.Text + "%' " +
                                        "OR wWorkerNum LIKE '%" + txFind.Text + "%' " +
                                        "OR wProjectId LIKE '%" + txFind.Text + "%' " +
                                        "OR wCompanyId LIKE '%" + txFind.Text + "%')";
                }
                else if (cmbFind.SelectedIndex == 1)
                {
                    sqlCommandStr += " AND (wName LIKE '%" + txFind.Text + "%')";
                }
                else if (cmbFind.SelectedIndex == 2)
                {
                    sqlCommandStr += " AND (wWorkerNum LIKE '%" + txFind.Text + "%')";
                }
                else if (cmbFind.SelectedIndex == 4)
                {
                    sqlCommandStr += " AND (wcompanyid LIKE '%" + txFind.Text + "%')";
                }
                else if (cmbFind.SelectedIndex == 3)
                {
                    sqlCommandStr += " AND (wprojectid LIKE '%" + txFind.Text + "%')";
                }
            }
            if (flag == FLAG.CORP)
            {
                ;
            }
            if (flag == FLAG.PROJECT)
            {
                ;
            }

            ListViewItem lvi;
            DataTable thedt = dba.ReadDatas(sqlCommandStr, false);
            string[] lvSubItems;
            int j = 0;
            currentLView.Items.Clear();
            if (thedt.Rows.Count <= 0) return;
            foreach (DataRow newdr in thedt.Rows)
            {
                lvSubItems = new string[] { (j + 1).ToString().ToString(), 
                                        newdr[0].ToString(), 
                                        newdr[1].ToString(), 
                                        newdr[2].ToString(), 
                                        newdr[3].ToString(), 
                                        newdr[4].ToString(), 
                                        newdr[5].ToString(), 
                                        newdr[6].ToString(),
                                        newdr[7].ToString()/* ? "Yes" : "No"*/};    //.ToString() };
                lvi = new ListViewItem(lvSubItems);
                //lvi.Tag = new Person(newdr);
                if (j % 2 == 0)
                {
                    lvi.BackColor = Color.FromArgb(250, 248, 255, 248);
                }
                lvWorker.Items.Add(lvi);
                j++;
            }
        }


        private void LoadCorpsComboItems()
        {
            DataTable tableCorps = ProDataset.CorpDataSource;
            DataRow dr = tableCorps.NewRow();

            dr.ItemArray = new object[] { "", 0 };
            if (tableCorps != null && tableCorps.Rows.Count >= 1)
            {
                cmbCompany.Items.Clear();
                tableCorps.Rows.InsertAt(dr, 0);
                cmbCompany.DataSource = tableCorps;
                cmbCompany.DisplayMember = tableCorps.Columns["cCorpName"].ColumnName;
                cmbCompany.ValueMember = tableCorps.Columns["cCorpID"].ColumnName;
            }
        }


        private void LoadProjectComboItems()
        {
            DataTable tableProject = pds.JobCardTable;
            DataRow dr = tableProject.NewRow();
            dr.ItemArray = new object[] { "", "" };
            if (tableProject != null && tableProject.Rows.Count >= 1)
            {
                cmbJobCard.Items.Clear();
                tableProject.Rows.InsertAt(dr, 0);
                cmbJobCard.DataSource = tableProject;
                cmbJobCard.DisplayMember = tableProject.Columns["pName"].ColumnName;
                cmbJobCard.ValueMember = tableProject.Columns["ProjectID"].ColumnName;
            }
        }

    }
}
