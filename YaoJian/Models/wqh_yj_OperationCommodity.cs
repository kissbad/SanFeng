using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoJian.Models
{
    class wqh_yj_OperationCommodity
    {
        public string medicineCodeNumber { get; set; }
        public string medicineGeneralName { get; set; }
        public string measureUnit { get; set; }
        public string packSpec { get; set; }
        public string specifications { get; set; }
        public string doseType { get; set; }
        public string productionEprice { get; set; }

        public bool save()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"insert into wqh_yj_OperationCommodity(medicineCodeNumber,medicineGeneralName,measureUnit,packSpec,specifications,doseType,productionEprice)
values(@medicineCodeNumber,@medicineGeneralName,@measureUnit,@packSpec,@specifications,@doseType,@productionEprice)";
                return conn.Execute(sql, this) > 0;
            }
        }

        public static bool clear()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"truncate table wqh_yj_OperationCommodity";
                return conn.Execute(sql) > 0;
            }
        }
    }


}
