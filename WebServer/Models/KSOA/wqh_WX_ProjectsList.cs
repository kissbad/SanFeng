using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class wqh_WX_ProjectsList : DataInfor
    {
        public string AppID { get; set; }
        public string AppSecret { get; set; }
        public string AppName { get; set; }

        public static string GetAppSecret(string AppID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select AppSecret from wqh_WX_ProjectsList(nolock) where AppID = @AppID ";
                return conn.QueryFirstOrDefault<string>(sql, new { AppID });
            }
        }
    }
}