using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class dwdydz : DataInfor
    {
        public string dwbh { get; set; }
        public string shouhid { get; set; }
        public string dwlxr { get; set; }
        public string lxrdh { get; set; }
        public string shouhr { get; set; }
        public string shouhrdh { get; set; }
        public string shouhrdz { get; set; }
        public string quyufl { get; set; }
        public string jsfs { get; set; }
        public string kpy { get; set; }

        public static List<dwdydz> search_dwlxr(string dwbh)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select dwbh,shouhid,dwlxr,lxrdh,shouhr,shouhrdh,shouhrdz,quyufl,jsfs,kpy 
from dwdydz(nolock) where dwbh = @dwbh";
                return conn.Query<dwdydz>(sql, new { dwbh }).ToList();
            }
        }
    }
}