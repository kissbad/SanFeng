using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebServer.Models
{
    public class Global
    {
        /// <summary>
        /// KOSA数据库连接
        /// </summary>
        public static readonly string KSOA_ConnectionString = ConfigurationManager.ConnectionStrings["KSOA"]?.ConnectionString;
        public static readonly string BasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
    }
}