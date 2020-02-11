using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_pf_ckmx : DataInfor
    {
        public static void Save(Interface.pf_ckmx data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_pf_ckmx where  djbh = @djbh and dj_sn = @dj_sn";
                if (conn.QueryFirst<int>(sql, new { data.djbh, data.dj_sn }) > 0)
                {
                    string sql1 = @"";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
