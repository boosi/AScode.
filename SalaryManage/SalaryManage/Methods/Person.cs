using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SalaryManage.Methods
{
    public class Person
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string WorkerNum = "";

        /// <summary>
        /// 公司编号
        /// </summary>
        public string CompanyID = "";

        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectID = "";

        /// <summary>
        /// 工人名称
        /// </summary>
        public string WorkerName = "";

        /// <summary>
        /// 国籍
        /// </summary>
        public string Nationality = "";

        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender = true;

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age = "18 - 22";

        /// <summary>
        /// 证件类型
        /// </summary>
        public string Idtype = "";

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdNumber = "";

        /// <summary>
        /// 技能描述
        /// </summary>
        public string Skill = "";

        /// <summary>
        /// 技术等级
        /// </summary>
        public string Grade = "P";

        /// <summary>
        /// 保险状态
        /// </summary>
        public bool Policy = false;

        /// <summary>
        /// 基本工资
        /// </summary>
        public float BaseSalary = 500;

        /// <summary>
        /// 平常加班工资系数
        /// </summary>
        public float Rate1 = 1;

        /// <summary>
        /// 节假日加班系数
        /// </summary>
        public float Rate2 = 1;

        /// <summary>
        /// 注册时间
        /// </summary>
        public string RegDate = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

        /// <summary>
        /// 合约到达日期
        /// </summary>
        public string ContractPeriod = (DateTime.Now.AddYears(1)).ToString("dd-MM-yyyy hh:mm:ss");

        /// <summary>
        /// 离职日期
        /// </summary>
        public string LeaveDate = "";

        /// <summary>
        /// 是否激活状态
        /// </summary>
        public bool Active = true;

        /// <summary>
        /// 注释
        /// </summary>
        public string Descript = "";

        /// <summary>
        /// 最后的修改资料日期
        /// </summary>
        public string EditDate = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

        /// <summary>
        /// 资料修改者名称
        /// </summary>
        public string Editer = Utility.LoginUser;


        public Person()
        {
            init();
        }

        public Person(DataRow thedr)
        {
            WorkerNum = thedr[0].ToString(); 
            CompanyID = thedr[1].ToString(); 
            ProjectID = thedr[2].ToString(); 
            WorkerName = thedr[3].ToString(); 
            Nationality = thedr[4].ToString(); 
            Gender = (bool) thedr[5]; 
            Age = thedr[6].ToString(); 
            Idtype = thedr[7].ToString(); 
            IdNumber = thedr[8].ToString(); 
            Skill = thedr[9].ToString(); 
            Grade = thedr[10].ToString(); 
            Policy = (bool) thedr[11]; 
            BaseSalary = (float) thedr[12]; 
            Rate1 = (float) thedr[13]; 
            Rate2 = (float) thedr[14]; 
            RegDate = thedr[15].ToString(); 
            ContractPeriod = thedr[16].ToString(); 
            LeaveDate = thedr[17].ToString(); 
            Editer = thedr[18].ToString(); 
            EditDate = thedr[19].ToString(); 
            Active = (bool) thedr[20]; 
            Descript = thedr[21].ToString(); 

            init();
       }

        public object[] ItemArray = null;


        private void init()
        {
            ItemArray = new object[] {
                WorkerNum, 
                CompanyID, 
                ProjectID, 
                WorkerName, 
                Nationality, 
                Gender, 
                Age, 
                Idtype, 
                IdNumber, 
                Skill, 
                Grade, 
                Policy, 
                BaseSalary, 
                Rate1, 
                Rate2, 
                RegDate, 
                ContractPeriod, 
                LeaveDate, 
                Editer, 
                EditDate, 
                Active, 
                Descript
            };
        }
    }
}
