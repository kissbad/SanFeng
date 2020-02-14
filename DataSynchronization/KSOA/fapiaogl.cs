using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class fapiaogl:DataInfor,Interface.fapiaogl
    {
        public string fapiaoh { get; set; }
        public string djbh { get; set; }
        public string rq { get; set; }
        public decimal yuankpze { get; set; }
        public decimal kaipze { get; set; }
        public decimal je { get; set; }
        public decimal she { get; set; }
        public string fx { get; set; }
        public string beizhu { get; set; }
        public string is_dc { get; set; }
        public string guihao { get; set; }
        public string username { get; set; }
        public string kaiprq { get; set; }
        public string dwbh { get; set; }
        public string jieqing { get; set; }
        public string bendian { get; set; }
        public string ontime { get; set; }
        public string gysrq { get; set; }
        public string lastmodifytime { get; set; }

        public static List<fapiaogl> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select * from fapiaogl where lastmodifytime > @lastmodifytime";
                return conn.Query<fapiaogl>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
