using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK_DataSync.KSOA
{
    internal class DataInfor
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["KSOA"]?.ConnectionString;
    }
}
