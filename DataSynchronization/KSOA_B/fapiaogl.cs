using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class fapiaogl:DataInfor
    {
        public static void Save(Interface.fapiaogl data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from fapiaogl where fapiaoh = @fapiaoh and djbh = @djbh";
                if (conn.QueryFirst<int>(sql, new { data.fapiaoh,data.djbh }) > 0)
                {
                    string sql1 = @"update a set rq = @rq,yuankpze = @yuankpze,kaipze = @kaipze,je = @je,she = @she,fx = @fx,beizhu = @beizhu,
is_dc = @is_dc,guihao = @guihao,username = @username,kaiprq = @kaiprq,dwbh = @dwbh,jieqing = @jieqing,
bendian = @bendian,ontime = @ontime,gysrq = @gysrq,lastmodifytime = @lastmodifytime
from fapiaogl a
where fapiaoh = @fapiaoh and djbh = @djbh";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into fapiaogl(fapiaoh,djbh,rq,yuankpze,kaipze,je,she,fx,beizhu,is_dc,
guihao,username,kaiprq,dwbh,jieqing,bendian,ontime,gysrq,lastmodifytime)
values(@fapiaoh,@djbh,@rq,@yuankpze,@kaipze,@je,@she,@fx,@beizhu,@is_dc,
@guihao,@username,@kaiprq,@dwbh,@jieqing,@bendian,@ontime,@gysrq,@lastmodifytime)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
