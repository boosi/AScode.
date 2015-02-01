using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SalaryManage.DBConecte;

namespace SalaryManage.Data
{
    public class ProDataset
    {
        private String Provider = "Microsoft.Jet.OLEDB.4.0";
        public String DataSource = "PersonnelDB.tdb";
        private String Persist = "Persist Security Info=True";
        public String oleConnStr = Properties.Settings.Default.ConnStr;
        private OleDbConnection oleConn;

        private static Dbaccess DBA;
        private OleDbCommand oleComd;
        private OleDbCommandBuilder oleCombud;
        private OleDbDataAdapter oleAdap;
        private OleDbDataReader oleRad;

        public DataSet ProDatSet;
        public DataTable PersonTable;
        public DataTable JobCardTable;
        public DataTable CorpTable;


        private DataTable corpDataSource;
        private DataTable jobCardDataSource;


        //static Dbaccess DBA = new Dbaccess();

        public ProDataset()
        {
            //DBA = new Dbaccess();

            //OpenDB(true);
            //if (oleConn != null)
            //{
            //    ProDatSet = new DataSet();
            //    PersonTable = new DataTable();
            //    JobCardTable = new DataTable();
            //    CorpTable = new DataTable();

            //    oleComd = new OleDbCommand();
            //    oleAdap = new OleDbDataAdapter(oleComd);
            //    oleCombud = new OleDbCommandBuilder(oleAdap);
            //}
            //else if (oleConn.State == ConnectionState.Open)
            //{
            //    oleConn.Close();
            //}

            //LoadDataSource();
        }


        public ProDataset(string sqlCommandText)
        {
            DBA = new Dbaccess();

            oleConnStr = Properties.Settings.Default.ConnStr; ;
            oleConn = new OleDbConnection(oleConnStr);
            ProDatSet = new DataSet();
            PersonTable = new DataTable("personTable");
            JobCardTable = new DataTable("jobcardTable");
            CorpTable = new DataTable("corpTable");
            ProDatSet.Tables.Add(PersonTable);
            ProDatSet.Tables.Add(JobCardTable);
            ProDatSet.Tables.Add(CorpTable);

            string sqlstr = "";
            try
            {
                oleConn.Open();
                sqlstr = "select * from staffs";
                oleComd = new OleDbCommand(sqlstr, oleConn); 
                oleAdap = new OleDbDataAdapter(oleComd);
                oleAdap.Fill(ProDatSet, "personTable");
                //oleAdap.Fill(PersonTable);

                sqlstr = "select * from projects";
                oleComd = new OleDbCommand(sqlstr, oleConn); 
                oleAdap = new OleDbDataAdapter(oleComd);
                oleAdap.Fill(ProDatSet, "jobcardTable");

                sqlstr = "select * from corps";
                oleComd = new OleDbCommand(sqlstr, oleConn); 
                oleAdap = new OleDbDataAdapter(oleComd);
                oleAdap.Fill(ProDatSet, "corpTable");
            }
            catch (Exception ex)
            {
                if (oleConn.State == ConnectionState.Open) oleConn.Close();
                System.Windows.Forms.MessageBox.Show(
                    "Execute fail.\nError code::>> " + ex.Message,
                    "Warning!!!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }


        private void OpenDB(bool isKeep)
        {
            oleConn = new OleDbConnection(oleConnStr);
            try
            {
                oleConn.Open();
                if (!isKeep)
                    oleConn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Execute fail.\nError code::>> " + ex.Message, 
                    "Warning!!!", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Warning);
                if (oleConn.State == ConnectionState.Open) oleConn.Close();
            }
        }
    
    
    /**********************/


        /// <summary>
        /// 用于 ComboBox 的数据源
        /// </summary>
        public static DataTable CorpDataSource
        {
            get {
                return DBA.getDataTable("SELECT cCorpName, cCorpID FROM Corps WHERE comStatus = true"); 
            }
        }


        public static DataTable JobCardDataSource
        {
            get {
                return DBA.getDataTable("SELECT pName, ProjectID FROM Projects");
            }
        }
    }
}
