using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class DataInfor
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["KSOA"]?.ConnectionString;
    }
}