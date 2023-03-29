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
        public string isjh { get; set; }
        public string issx { get; set; }

        public static List<dwdydz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select a.*,b.isjh,b.isxs from dwdydz(nolock) a join mchk(nolock) b on a.dwbh = b.dwbh where a.lastmodifytime > @lastmodifytime and a.dwlxr <> ''";
                return conn.Query<dwdydz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
