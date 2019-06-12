using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class dwdydz : DataInfor
    {
        public int shouhid { get; set; }
        public string dwbh { get; set; }
        public string dwlxr { get; set; }
        public string dangqzht { get; set; }

        public static List<dwdydz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from dwdydz(nolock) where lastmodifytime > @lastmodifytime";
                return conn.Query<dwdydz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
