using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class mchk:DataInfor
    {
        public string dwbh { get; set; }
        public string danwbh { get; set; }
        public string dwmch { get; set; }
        public string isjh { get; set; }
        public string isxs { get; set; }
        public static List<mchk> getList(string lastmodifytime) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return conn.Query<mchk>("select * from mchk(nolock) where lastmodifytime > @lastmodifytime",new { lastmodifytime }).ToList();
            }
        }
    }
}
