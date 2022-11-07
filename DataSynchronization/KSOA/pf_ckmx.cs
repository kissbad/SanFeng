using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class pf_ckmx:DataInfor,Interface.pf_ckmx
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
        public string is_chonghong { get; set; }
        public decimal ch_shl { get; set; }
        public int chdj_sn { get; set; }
        public decimal yshl { get; set; }
        public decimal yhshj { get; set; }
        public string is_zx { get; set; } = "";
        public string lastmodifytime { get; set; }
        public decimal ydj { get; set; }
        public decimal ndj { get; set; }
        public decimal nhshj { get; set; }
        public string is_fp { get; set; }

        public static List<pf_ckmx> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,a.dj_sn,a.dj_sort,a.spid,a.hw,a.shl,a.dj,case when a.djbh like 'xsb%' then a.hshj else a.xsdj end as hshj,
a.je,a.hsje,a.shlv,a.she,a.zengp,a.pihao,a.sxrq,a.baozhiqi,a.is_chonghong,a.ch_shl,a.chdj_sn,a.shl as yshl,a.ydj,a.yhshj,
a.ndj,a.hshj2 as nhshj,a.lastmodifytime,a.is_fp 
from pf_ckmx a 
join pf_ckhz b on a.djbh=b.djbh 
where a.lastmodifytime > Dateadd(d,-7,convert(datetime,@lastmodifytime)) ";
                return conn.Query<pf_ckmx>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
