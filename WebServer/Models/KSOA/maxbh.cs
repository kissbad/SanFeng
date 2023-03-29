using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class maxbh:DataInfor
    {
        public static string get_maxbh(string biaoshi) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"declare @maxbh { get; set; }(15)
exec dbo.SOF_getmaxbh @biaoshi,3,@maxbh output
select @maxbh";
                return conn.QueryFirstOrDefault<string>(sql, new { biaoshi });
            }
        }
    }
}