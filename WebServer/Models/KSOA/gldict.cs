using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class gldict : DataInfor
    {
        public string fdname { get; set; }
        public string dictlist { get; set; }
        public string bianh { get; set; }
        public string is_mr { get; set; }
        public int xlh { get; set; }

        public static List<string> get_gldict(string fdname)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select dictlist from gldict(nolock) where fdname = @fdname ";
                return conn.Query<string>(sql, new { fdname }).ToList();
            }
        }
    }
}