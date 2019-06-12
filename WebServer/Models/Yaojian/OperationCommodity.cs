using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
{
    public class OperationCommodity
    {
        public string medicineCodeNumber { get; set; }
        public string packagSpecifications { get; set; }
        public string medicineGeneralName { get; set; }
        public string doseType { get; set; }
        public string specifications { get; set; }
        public string measureUnit { get; set; }
        public string productionEprice { get; set; }
        public string medicineOfficeNumber { get; set; }

        public bool save()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"insert into jk_OperationCommodity(medicineCodeNumber,packagSpecifications,medicineGeneralName,doseType,specifications,measureUnit,productionEprice,medicineOfficeNumber)
values(@medicineCodeNumber,@packagSpecifications,@medicineGeneralName,@doseType,@specifications,@measureUnit,@productionEprice,@medicineOfficeNumber)";
                return conn.Execute(sql, this) > 0;
            }
        }

        public static bool clear() {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"truncate table jk_OperationCommodity";
                return conn.Execute(sql) > 0;
            }
        }

        public static List<OperationCommodity> GetOperationCommodities() {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"select * from jk_OperationCommodity";
                return conn.Query<OperationCommodity>(sql).ToList();
            }
        }
    }
}