using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Auto_Expressage.npserver
{
    internal class DataInfor
    {
        //public static readonly string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.7)(PORT=1521)) (CONNECT_DATA=(SID=orcl)));User ID=sf_yk;Password=Sf2023;";
        public static readonly string ConnectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["oracle"]?.Value;
    }
}
