using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class fapiaodet:DataInfor,Interface.fapiaodet
    {
        public string fapiaoh { get; set; }
        public string djbh { get; set; }
        public int dj_sn { get; set; }
        public string spid { get; set; }
        public decimal shl { get; set; }
        public decimal dj { get; set; }
        public decimal je { get; set; }
        public decimal shlv { get; set; }
        public decimal she { get; set; }
        public string dwbh { get; set; }
        public decimal yisfje { get; set; }
        public decimal hsje { get; set; }
        public decimal hshj { get; set; }
        public string jieqing { get; set; }
        public string pihao { get; set; }
        public string sxrq { get; set; }
        public string guihao { get; set; }
        public string lastmodifytime { get; set; }

        public static List<fapiaodet> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select * from fapiaodet where lastmodifytime > @lastmodifytime";
                return conn.Query<fapiaodet>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
