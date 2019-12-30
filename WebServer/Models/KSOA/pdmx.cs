using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class pdmx : DataInfor
    {
        public string djbh { get; set; }
        public string pdbz { get; set; }
        public string spid { get; set; }
        public string pihao { get; set; }
        public string dw { get; set; }
        public string jlgg { get; set; }
        public int shpshl { get; set; }
        public string jwh { get; set; }
        public string spbh { get; set; }
        public string spmch { get; set; }
        public string shengccj { get; set; }

        public static List<pdmx> get_pdmx(string djbh)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select a.djbh,a.pdbz,a.spid,a.pihao,a.dw,a.jlgg,a.shpshl,a.jwh,
b.spbh,b.spmch,b.shengccj
from pdmx a
join spkfk b on a.spid = b.spid
where djbh = @djbh";
                return conn.Query<pdmx>(sql, new { djbh }).ToList();
            }
        }
    }
}