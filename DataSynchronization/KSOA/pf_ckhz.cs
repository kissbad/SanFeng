using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class pf_ckhz:DataInfor,Interface.pf_ckhz
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
        public string is_zhongyao { get; set; }
        public string is_jhfh { get; set; }
        public string printfa { get; set; }
        public string ychrq { get; set; }
        public string ptmch { get; set; }
        public string ptdjbh { get; set; }
        public string isds { get; set; }
        public string is_zt { get; set; }
        public string is_fyf { get; set; }
        public string is_fp { get; set; }
        public string is_fpwc { get; set; }
        public string dj_chonghong { get; set; }
        public string is_chonghong { get; set; }
        public string shouhr { get; set; }
        public string sanhdsh { get; set; }
        public string sanhjsh { get; set; }
        public string wzbh { get; set; }
        public string is_zx { get; set; }
        public string is_sjjh { get; set; }
        public string lastmodifytime { get; set; }
        public string gldjbh { get; set; }

        public static List<pf_ckhz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,a.djbs,a.djlx,a.rq,a.ontime,a.bm,
case when a.djbh like 'xs[ab]%' or a.is_fp='是' then a.dwbh else c.dwbh2 end as dwbh,
a.username,a.ywy,a.bendian,a.is_zhongyao,a.is_jhfh,b.printfa,b.ychrq,a.is_zt,a.is_fyf,
a.is_fp,a.is_fpwc,a.dj_chonghong,a.is_chonghong,a.shouhr,a.sanhdsh,a.sanhjsh,a.wzbh,a.lastmodifytime 
from pf_ckhz a 
left join pf_djhz b on b.djbh=a.xgdjbh 
left join pf_ckhz c on c.djbh=b.xgdjbh
where a.lastmodifytime > @lastmodifytime ";
                return conn.Query<pf_ckhz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
