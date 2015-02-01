using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SalaryManage.Methods
{
    public class Corps
    {

        /// <summary>
        /// 公司 ID
        /// </summary>
        public string CorpID = "";
        /// <summary>
        /// 名称
        /// </summary>
        public string CorpName = "";
        /// <summary>
        /// 项目
        /// </summary>
        public string Project = "";
        /// <summary>
        /// 公司分类
        /// </summary>
        public string classify = "";
        /// <summary>
        /// 地址
        /// </summary>
        public string Address = "";
        /// <summary>
        /// 电话
        /// </summary>
        public string Telphone = "";
        /// <summary>
        /// 法人
        /// </summary>
        public string Corporation = "";
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contract = "";
        /// <summary>
        /// 说明
        /// </summary>
        public string Mark = "";
        /// <summary>
        /// 注册日期
        /// </summary>
        public string RegDate = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        /// <summary>
        /// 注册日期
        /// </summary>
        public string EditDate = "";
        /// <summary>
        /// 当前状态
        /// </summary>
        public int Status = 1;


        public Corps()
        {
            init();
        }

        public Corps(DataRow thedr)
        {
            CorpID = thedr[0].ToString();
            CorpName = thedr[1].ToString();
            Project = thedr[2].ToString();
            classify = thedr[3].ToString();
            Address = thedr[4].ToString();
            Telphone = thedr[5].ToString();
            Corporation = thedr[6].ToString();
            Contract = thedr[7].ToString();
            Mark = thedr[8].ToString();
            RegDate = thedr[9].ToString();
            EditDate = thedr[10].ToString();
            Status = int.Parse(thedr[11].ToString());

            init();
        }

        public object[] itemArray = null;

        private void init()
        {
            itemArray = new object[]
            { 
                CorpID, 
                CorpName, 
                Project, 
                classify, 
                Address, 
                Telphone, 
                Corporation, 
                Contract, 
                Mark,
                RegDate,
                EditDate,
                Status
            };
        }

    }





}
