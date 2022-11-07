using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WarningTool.Models
{
    class DataInfor
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["KSOA"]?.ConnectionString;
    }
}
