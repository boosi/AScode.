using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SalaryManage.Methods;
using SalaryManage.Data;


namespace SalaryManage.DBConecte
{
    class Dbaccess
    {
        public string AccessConnStr = Properties.Settings.Default.ConnStr;
        public OleDbConnection OledbConn;
        public OleDbCommand Comd;
        public OleDbCommandBuilder odbCommbd;
        public OleDbDataAdapter Datapt;
        public OleDbDataReader DatReader;
        public DataSet ds = null;
        public DataTable dt = null;

        /// <summary>
        /// 如果操作执行中发生错误，这个是错误代码或消息
        /// </summary>
        public string ErrorCode = "";

        /// <summary>
        /// 执行操作之后，得到的结果
        /// </summary>
        public object retObject = null; 

        public Dbaccess()
        {
            Comd = new OleDbCommand();
            Datapt = new OleDbDataAdapter(Comd);
        }


        public OleDbConnection opendb()
        {
            OledbConn = new OleDbConnection(AccessConnStr);
            try
            {
                OledbConn.Open();
            }
            catch (Exception ex)
            {
                if (OledbConn.State == ConnectionState.Open) OledbConn.Close();
                ErrorCode = ex.Message;
            }
            return OledbConn;
        }


        private void getErrMsg(Exception ex, bool isShowMsg)
        {
            ErrorCode = ex.Message;
            if (isShowMsg)
            {
                System.Windows.Forms.MessageBox.Show("Informat: [" + ex.Message + "]");
            }
        }


        /// <summary>
        /// 执行 SQL 命令
        /// </summary>
        /// <param name="sqlTxt">文本形式 SQL 命令</param>
        /// <param name="isRetrieve">如果执行的是查询操作，该参数必须为 True，否则无法得到查询结果;
        /// <br>当查询成功时，返回结果在该类实例变量 retObject 中, 数据类型为 OleDbDataReader;</br>
        /// <br>增加、编辑、删除操作时，返回结果为影响的行数[ int型 ], 也存储在 retObject 当中;</br></param>
        /// <returns>成功 True, 失败 False;</returns>
        public bool ExecSql(string sqlTxt, bool isRetrieve)
        {
            bool isCorrect = true;
            
            ErrorCode = "";
            retObject = new object();
            try
            {
                // 打开数据库
                OledbConn = opendb();
                // 执行操作
                if (OledbConn != null)
                {
                    Comd = new OleDbCommand(sqlTxt, OledbConn);
                    if (isRetrieve)
                    {
                        retObject = Comd.ExecuteReader().GetSchemaTable();
                        //while (DatReader.Read())
                        //{
                            //retObject = DatReader.GetValue(0);
                        //}
                    }
                    else
                        retObject = Comd.ExecuteNonQuery();
                }
                // 关闭数据库
                OledbConn.Close();
            }
            catch (Exception ex)
            {
                ErrorCode = ex.Message;
                isCorrect = false;
                if (OledbConn.State == ConnectionState.Open) OledbConn.Close();
            }
            return isCorrect;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public bool ExecSql(string sqlStr)
        {
            bool isSave = false;
            try
            {
                OledbConn = opendb();
                if (OledbConn != null)
                {
                    Comd = new OleDbCommand(sqlStr, OledbConn);
                    if (Comd.ExecuteNonQuery() == 1)
                    {
                        isSave = true;
                    }
                    else { isSave = false; }
                }
                OledbConn.Close();
            }
            catch (Exception ex)
            {
                if (OledbConn.State == ConnectionState.Open) OledbConn.Close();
                ErrorCode = ex.Message;
            }
            return isSave;
        }



        /// <summary>
        /// 存储一个员工信息到数据库中, 当存储失败的时候，类实例变量 ErrorCode 会返回异常信息;
        /// </summary>
        /// <param name="personnerData">员工的实例对象</param>
        /// <returns>存储成功为 True, 否则为 False;</returns>
        public bool SavePersonData(Person personnerData)
        {
            bool isSave = false;
            ErrorCode = "";
                    string sqlStr = "";
                    sqlStr = "INSERT INTO staffs(wWorkerNum, wCompanyID, " +
                                "wProjectID, wName, " +
                                "wNationality, wGender, " +
                                "wAge, wIdtype, " +
                                "wIdNumber, wSkill, " +
                                "wGrade, wPolicy, " +
                                "wBaseSalary, wRate1, " +
                                "wRate2, wRegDate, " +
                                "wContractPeriod, wLeaveDate, " +
                                "wActive, wDescript," +
                                "wEditDate, wEditer)";
                    sqlStr += "VALUES('" + 
                                personnerData.WorkerNum + "', '" + personnerData.CompanyID + "', '" + 
                                personnerData.ProjectID +"', '" + personnerData.WorkerName + "', '" + 
                                personnerData.Nationality + "', "+ personnerData.Gender +", '"+
                                personnerData.Age + "', '" + personnerData.Idtype + "', '"+ 
                                personnerData.IdNumber+"', '" + personnerData.Skill +"', '"+
                                personnerData.Grade +"', " + personnerData.Policy+ "," + 
                                personnerData.BaseSalary + "," + personnerData.Rate1 + ","+ 
                                personnerData.Rate2 +",'"+ DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "', '" +
                                personnerData.ContractPeriod+"','',"+
                                personnerData.Active + ", '" + personnerData.Descript + "', '" +
                                DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "', '" + Utility.LoginUser + "')";
            isSave = ExecSql(sqlStr);
            return isSave;
        }


        /// <summary>
        /// 更新员工数据
        /// </summary>
        /// <param name="personnerData"></param>
        /// <returns></returns>
        public bool UpdatePersonData(Person personnerData)
        {
            bool isSave = false;
            ErrorCode = "";
                    string sqlStr = "";
            
                    sqlStr = "Update staffs set "+
                                "wCompanyID = '" + personnerData.CompanyID + "', " +
                                "wProjectID = '" + personnerData.ProjectID + "', " + 
                                "wName = '" + personnerData.WorkerName + "', " +
                                "wNationality = '" + personnerData.Nationality + "', " +
                                "wGender = " + personnerData.Gender + ", " +
                                "wAge = '" + personnerData.Age + "', " +
                                "wIdtype = '" + personnerData.Idtype + "', " +
                                "wIdNumber = '" + personnerData.IdNumber + "', " +
                                "wSkill = '" + personnerData.Skill + "', " +
                                "wGrade = '" + personnerData.Grade + "', " +
                                "wPolicy = " + personnerData.Policy + ", " +
                                "wBaseSalary = " + personnerData.BaseSalary + ", " +
                                "wRate1 = " + personnerData.Rate1 + ", " +
                                "wRate2 = " + personnerData.Rate2 + ", " +
                                ////"wRegDate = '" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") +"', " +
                                "wContractPeriod = '" + personnerData.ContractPeriod + "', " +
                                ////"wLeaveDate = '" +  +"', " +
                                ////"wActive = '" + personnerData.Active +"', " +
                                "wDescript = '" + personnerData.Descript + "'," +
                                "wEditDate = '" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "', " +
                                "wEditer = '" + Utility.LoginUser +"sss' " +
                                "Where wWorkerNum = '" + personnerData.WorkerNum + "'";
                    //isSave = ExecSql(sqlStr);
                isSave = ExecSql(sqlStr, false);
            return isSave;
        }


        public bool SavProjectData(Projects projectData)
        {
            bool isSave = false;
            ErrorCode = "";
            string sqlStr = "";
            sqlStr = "INSERT INTO Projects(ProjectID, pName, pClassify, " +
                        "pContractID, pWorkplace, " +
                        "pManager, pCorpID, " +
                        "pManageTel, pContents, " +
                        "pStartDate, pEndDate, " +
                        "pStatus, pRemark)";
            sqlStr += "VALUES('" +
                        projectData.ProjectID + "', '" + projectData.ProjectName + "', '" +
                        projectData.Classify + "', '" + projectData.ContractID + "', '" +
                        projectData.Workplace + "', '" + projectData.Manager + "', '" +
                        projectData.CorpID + "', '" + projectData.ManageTel + "', '" +
                        projectData.Contents + "', '" + projectData.StartDate + "', '" +
                        projectData.EndDate + "', " + projectData.Status + ",'" +
                        projectData.Remark + "')";
            isSave = ExecSql(sqlStr);

            return isSave;
        }


        public bool UpdateProjectData(Projects projectData)
        {
            ErrorCode = "";
            string sqlStr = "";

            sqlStr = "Update Projects set " +
                        "pName = '" + projectData.ProjectName + "', " +
                        "pClassify = '" + projectData.Classify + "', " +
                        "pContractID = '" + projectData.ContractID + "', " +
                        "pWorkplace= '" + projectData.Workplace + "', " +
                        "pManager = '" + projectData.Manager + "', " +
                        "pCorpID = '" + projectData.CorpID + "', " +
                        "pManageTel = '" + projectData.ManageTel + "', " +
                        "pContents = '" + projectData.Contents + "', " +
                        "pStartDate = '" + projectData.StartDate + "', " +
                        "pEndDate = '" + projectData.EndDate + "', " +
                        "pStatus = " + projectData.Status + ", " +
                        "pRemark = '" + projectData.Remark + "' " + 
                        "Where ProjectID = '" + projectData.ProjectID + "'";
            
            return ExecSql(sqlStr, false);
        }


        public bool SaveCompanyData(Corps corpData)
        {
            bool isSave = false;
            ErrorCode = "";
            string sqlStr = "";
            sqlStr = "INSERT INTO corps(" + 
                     "cCorpID, cCorpName," + 
                     "comProject, comAddress, " +
                     "comTel, comCorporation, " +
                     "comContractID, comDescript, "; 
            if (Utility.Optype == OpreatType.add)
                sqlStr += "comRegDate, comStatus) ";
            else
                sqlStr += "comEditDate, comStatus) ";
                            
            sqlStr += "VALUES('" +
                    corpData.CorpID + "', '" + corpData.CorpName + "', '" +
                    corpData.Project + "', '" + corpData.Address + "', '" +
                    corpData.Telphone + "', '" + corpData.Corporation + "', '" +
                    corpData.Contract + "', '" + corpData.Mark + "', '" +
                    DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "', " + corpData.Status + ")";
            isSave = ExecSql(sqlStr);

            return isSave;
        }


        public bool UpdateCompanyData(Corps corpData)
        {
            ErrorCode = "";
            string sqlStr = "";

            sqlStr = "Update corps set " +
                        "cCorpName = '" + corpData.CorpName + "', " +
                        "comProject = '" + corpData.Project + "', " +
                        "comAddress = '" + corpData.Address + "', " +
                        "comTel = '" + corpData.Telphone + "', " +
                        "comCorporation = '" + corpData.Corporation + "', " +
                        "comContractID = '" + corpData.Contract + "', " +
                        "comDescript = '" + corpData.Mark + "', " +
                //"comRegDate = '" + corpData.RegDate + "', " +
                        "comEditDate = '" + corpData.EditDate + "', " +
                        "comStatus = " + corpData.Status +
                        " Where cCorpID = '" + corpData.CorpID + "'";
            
            return ExecSql(sqlStr, false);
        }


        /// <summary>
        /// 读取数据库中数据表
        /// </summary>
        /// <param name="sqlStr">要执行的SQL语句</param>
        /// <param name="isWriteBack">可能需要写入数据库数据</param>
        /// <returns>数据表 DataTable 对象</returns>
        public DataTable ReadDatas(string sqlStr, bool isWriteBack)
        {
            DataTable tdt = new DataTable();
            try
            {
                OledbConn = opendb();
                Comd = new OleDbCommand(sqlStr, OledbConn);
                Datapt = new OleDbDataAdapter(Comd);
                if (isWriteBack)
                {
                    odbCommbd = new OleDbCommandBuilder(Datapt);
                }
                Datapt.Fill(tdt);
            }
            catch (Exception ex)
            {
                if (OledbConn.State == ConnectionState.Open) OledbConn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return tdt;
        }


        /// <summary>
        /// 添加对象到表中
        /// </summary>
        private void AppendRow()
        {

        }



        /// <summary>
        /// 获取 DataTable;
        /// </summary>
        /// <param name="sqlCmdText">要执行的 SQL 命令字符串</param>
        /// <returns></returns>
        public DataTable getDataTable(string sqlCmdText)
        {
            DataTable tdt = new DataTable();
            OledbConn = opendb();
            try
            {
                Datapt = new OleDbDataAdapter(sqlCmdText, OledbConn);
                Datapt.Fill(tdt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return tdt;
        }

    }
}
