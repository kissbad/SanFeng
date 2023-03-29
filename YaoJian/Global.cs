using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace YaoJian
{
    public class Global
    {
        /// <summary>
        /// KOSA数据库连接
        /// </summary>
        public static readonly string KSOA_ConnectionString = ConfigurationManager.ConnectionStrings["KSOA"]?.ConnectionString;
        /// <summary>
        /// 程序路径
        /// </summary>
        public static readonly string BasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        /// <summary>
        /// 证书名称
        /// </summary>
        public static readonly string Certificate_name = ConfigurationManager.ConnectionStrings["Certificate_name"]?.ConnectionString;
    }
}