using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class shpbsmx:DataInfor,Interface.shpbsmx
    {
        public string djbh { get; set; }
        public int dj_sn { get; set; }
        public string spid { get; set; }
        public int recnum { get; set; }
        public string xgdjbh { get; set; }
        public int dj_sort { get; set; }
        public string dw { get; set; }
        public string pihao { get; set; }
        public decimal baosshl { get; set; }
        public decimal baoyshl { get; set; }
        public decimal syje { get; set; }
        public string Hjid { get; set; }
        public string sxrq { get; set; }
        public string Tpid { get; set; }
        public string bsyyj { get; set; }
        public string beizhu { get; set; }
        public string is_con { get; set; }
        public string baozhiqi { get; set; }
        public string lastmodifytime { get; set; }

        public static List<shpbsmx> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,a.dj_sn,a.spid,a.recnum,a.xgdjbh,a.dj_sort,a.dw,a.pihao,a.baosshl,
a.baoyshl,a.syje,a.Hjid,a.sxrq,Tpid,bsyyj,a.beizhu,is_con,a.baozhiqi,a.lastmodifytime  
FROM shpbsmx a 
join shpbshz c on a.djbh=c.djbh 
join sphwph b on a.spid=b.spid and a.pihao =b.pihao and c.hw=b.hw  and b.is_fp='是'
WHERE a.lastmodifytime > @lastmodifytime ";
                return conn.Query<shpbsmx>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
