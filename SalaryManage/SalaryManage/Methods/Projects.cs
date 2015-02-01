using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SalaryManage.Methods
{
    public class Projects
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ProjectID = "";
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName = "";
        /// <summary>
        /// 分类
        /// </summary>
        public string Classify = "";
        /// <summary>
        /// 联系人ID
        /// </summary>
        public string ContractID = "";
        /// <summary>
        /// 工作地点
        /// </summary>
        public string Workplace = "";
        /// <summary>
        /// 管理人员
        /// </summary>
        public string Manager = "";
        /// <summary>
        /// 承包公司
        /// </summary>
        public string CorpID = "";
        /// <summary>
        /// 管理人电话
        /// </summary>
        public string ManageTel = "";
        /// <summary>
        /// 工作内容
        /// </summary>
        public string Contents = "";
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartDate = "";
        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndDate = "";
        /// <summary>
        /// 当前状态
        /// </summary>
        public int Status = -1;
        /// <summary>
        /// 说明
        /// </summary>
        public string Remark = "";


        public Projects()
        {
            init();
        }

        public Projects(DataRow thedr)
        {
            ProjectID = thedr[0].ToString();
            ProjectName = thedr[1].ToString();
            Classify = thedr[2].ToString();
            ContractID = thedr[3].ToString();
            Workplace = thedr[4].ToString();
            Manager = thedr[5].ToString();
            CorpID = thedr[6].ToString();
            ManageTel = thedr[7].ToString();
            Contents = thedr[8].ToString();
            StartDate = thedr[9].ToString();
            EndDate = thedr[10].ToString();
            Status = int.Parse(thedr[11].ToString());
            Remark = thedr[12].ToString();

            init();
        }


        public object[] ItemArray = null;

        private void init()
        {
            ItemArray = new object[] {
                ProjectID,
                ProjectName,
                Classify,
                ContractID,
                Workplace,
                Manager,
                CorpID,
                ManageTel,
                Contents,
                StartDate,
                EndDate,
                Status,
                Remark
            };
        }
    }
}
