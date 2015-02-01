using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryManage
{
    public class Utility
    {
        public static string LoginUser = "SSS";    //登录者名称
        public static int loginUserClassIndex = 0;  //登录者类型索引
        public static string LABEL = "";    //操作类型
        public static string WorkerNumberHead = "WP";   //工号编码的字头
        public static string WorkerNumberRule = DateTime.Now.ToString("yyyy-MMdd-hhmmss");   //工号编码的规则
        public static string WorkerNumberEnd = "S";   //工号编码的字尾


        public static OpreatType Optype = OpreatType.add;
        public static UserAuthorize Authorizes = UserAuthorize.AdminisUsers;
    }


    /// <summary>
    /// 区别 "用户权限" 或者是 "用户类型"
    /// </summary>
    public enum UserAuthorize
    {
        OrdinaryUsers = 0,
        AdvanceUsers = 1,
        AdminisUsers = 2
    }

    /// <summary>
    /// 区别程序分类S
    /// </summary>
    public enum FLAG
    {
        STAFF,
        PROJECT,
        CORP,
        MAINTANCE
    }

    public enum OpreatType
    {
        add,
        edit,
        delet
    }


    public enum ProjectStatus
    {
        Underway,
        Complete,
        Suspend,
        Other
    }
}
