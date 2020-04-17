using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class pdmx:DataInfor,Interface.pdmx
    {
        public string djbh { get; set; }
        public int dj_sn { get; set; }
        public string spid { get; set; }
        public string dj_sort { get; set; }
        public string pdbz { get; set; }
        public string plh { get; set; }
        public string dw { get; set; }
        public string pihao { get; set; }
        public int jlgg { get; set; }
        public int baozhshl { get; set; }
        public decimal lingsshl { get; set; }
        public decimal shpshl { get; set; }
        public decimal shpje { get; set; }
        public decimal zhmshl { get; set; }
        public decimal zhmje { get; set; }
        public decimal chbdj { get; set; }
        public decimal psshl { get; set; }
        public decimal psje { get; set; }
        public decimal lshj { get; set; }
        public string sxrq { get; set; }
        public string is_shp { get; set; }
        public string jwh { get; set; }
        public string baozhiqi { get; set; }
        public string beizhu { get; set; }
        public string Hjid { get; set; }
        public decimal jiansh { get; set; }
        public string Tpid { get; set; }
        public string biaoshi { get; set; }
        public decimal fkcshl { get; set; }
        public string isxzph { get; set; }
        public decimal ychbdj { get; set; }
        public string lastmodifytime { get; set; }

        public static List<pdmx> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,dj_sn,a.spid,dj_sort,a.pdbz,plh,dw,a.pihao,jlgg,baozhshl,lingsshl,shpshl,shpje,zhmshl,zhmje,chbdj,
psshl,a.psje,lshj,a.sxrq,is_shp,a.jwh,a.baozhiqi,a.beizhu,Hjid,jiansh,Tpid,biaoshi,fkcshl,isxzph,ychbdj,a.lastmodifytime  
from pdmx a 
join pdhz c on a.djbh=c.djbh 
join sphwph b on a.spid=b.spid and a.pihao =b.pihao and c.hw=b.hw and b.is_fp='是'
where a.lastmodifytime  > @lastmodifytime";
                return conn.Query<pdmx>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
