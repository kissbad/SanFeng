using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class jh_rkhz:DataInfor,Interface.jh_rkhz
    {
        public string djbh { get; set; }
        public string djbs { get; set; }
        public string djlx { get; set; }
        public string rq { get; set; }
        public string ontime { get; set; }
        public string bm { get; set; }
        public string dwbh { get; set; }
        public string username { get; set; }
        public string ywy { get; set; }
        public string bendian { get; set; }
        public string is_chonghong { get; set; }
        public string dj_chonghong { get; set; }
        public string thfs { get; set; }
        public string is_fp { get; set; }
        public string deywy { get; set; }
        public string shjy { get; set; }
        public string shjy2 { get; set; }
        public string shjy3 { get; set; }
        public string lhdh { get; set; }
        public string is_zx { get; set; }
        public string lastmodifytime { get; set; }
        public string gldjbh { get; set; }

        public static List<jh_rkhz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,a.djbs,a.djlx,a.rq,a.ontime,a.bm,a.dwbh,a.username,a.ywy,a.bendian,a.is_chonghong,
a.dj_chonghong,a.thfs,a.is_fp,a.deywy,a.shjy,a.shjy2,a.shjy3,b.lhdh,a.lastmodifytime 
from jh_rkhz a 
left join jh_djhz b ON b.djbh=a.xgdjbh 
where a.lastmodifytime > @lastmodifytime";
                return conn.Query<jh_rkhz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
