using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WarningTool.Models
{
    class wkpdj:DataInfor,dj
    {
        public string djbh { get; set; }
        public string rq { get; set; }
        public string danwbh { get; set; }
        public string dwmch { get; set; }
        public decimal je { get; set; }

        public static List<wkpdj> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"exec wqh_warningtool 'wkpdj',@lastmodifytime";
                return conn.Query<wkpdj>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
