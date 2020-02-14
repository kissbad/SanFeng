using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class fapiaodet : DataInfor
    {
        public static void Save(Interface.fapiaodet data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from fapiaodet where fapiaoh = @fapiaoh and djbh = @djbh and dj_sn = @dj_sn";
                if (conn.QueryFirst<int>(sql, new { data.fapiaoh, data.djbh, data.dj_sn }) > 0)
                {
                    string sql1 = @"update a set spid = @spid,shl = @shl,dj = @dj,je = @je,shlv = @shlv,
she = @she,dwbh = @dwbh,yisfje = @yisfje,hsje = @hsje,hshj = @hshj,jieqing = @jieqing,
pihao = @pihao,sxrq = @sxrq,guihao = @guihao,lastmodifytime = @lastmodifytime
from fapiaodet a
where fapiaoh = @fapiaoh and djbh = @djbh and dj_sn = @dj_sn";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into fapiaodet(fapiaoh,djbh,spid,shl,dj,je,shlv,she,dj_sn,dwbh,
yisfje,hsje,hshj,jieqing,pihao,sxrq,guihao,lastmodifytime)
values(@fapiaoh,@djbh,@spid,@shl,@dj,@je,@shlv,@she,@dj_sn,@dwbh,
@yisfje,@hsje,@hshj,@jieqing,@pihao,@sxrq,@guihao,@lastmodifytime)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
