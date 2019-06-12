using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebServer.Models.Request;

namespace WebServer.Models.KSOA
{
    public class mchk:DataInfor
    {
        public string dwbh { get; set; }
        public string danwbh { get; set; }
        public string dwmch { get; set; }
        public string zjm { get; set; }
        public string isjh { get; set; }
        public string isxs { get; set; }
        public string dzhdh { get; set; }
        public string lxr { get; set; }

        public static List<mchk> search_dw(object p)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"wqh_WX_search_dw";
                return conn.Query<mchk>(sql, p, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }
    }
}