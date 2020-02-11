using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class jh_rkmx : DataInfor,Interface.jh_rkmx
    {
        public string djbh { get; set; }
        public int dj_sn { get; set; }
        public int dj_sort { get; set; }
        public string spid { get; set; }
        public string hw { get; set; }
        public decimal shl { get; set; }
        public decimal dj { get; set; }
        public decimal hshj { get; set; }
        public decimal je { get; set; }
        public decimal hsje { get; set; }
        public decimal shlv { get; set; }
        public decimal she { get; set; }
        public string zengp { get; set; }
        public string pihao { get; set; }
        public string sxrq { get; set; }
        public string baozhiqi { get; set; }
        public string is_fp { get; set; }
        public decimal pfpj { get; set; }
        public string is_dj { get; set; }
        public string jwh { get; set; }
        public string is_chonghong { get; set; }
        public decimal ch_shl { get; set; }
        public int chdj_sn { get; set; }
        public decimal yshl { get; set; }
        public decimal yhshj { get; set; }
        public string is_zx { get; set; }
        public string is_sjjh { get; set; }
        public string lastmodifytime { get; set; }
        public decimal ydj { get; set; }
        public decimal ndj { get; set; }
        public decimal nhshj { get; set; }

        public static List<jh_rkmx> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select * from jh_rkmx where lastmodifytime > @lastmodifytime";
                return conn.Query<jh_rkmx>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
