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
                    string sql1 = @"update a set dj_sort = @dj_sort,spid = @spid,hw = @hw,shl = @shl,dj = @dj,hshj = @hshj,je = @je,
hsje = @hsje,shlv = @shlv,she = @she,zengp = @zengp,pihao = @pihao,sxrq = @sxrq,baozhiqi = @baozhiqi,is_chonghong = @is_chonghong,
ch_shl = @ch_shl,chdj_sn = @chdj_sn,yshl = @yshl,yhshj = @yhshj,is_zx = @is_zx,lastmodifytime = @lastmodifytime,
ydj = @ydj,ndj = @ndj,nhshj = @nhshj,is_fp = @is_fp
from sjjh_pf_ckmx a
where djbh = @djbh and dj_sn = @dj_sn";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_pf_ckmx(djbh,dj_sn,dj_sort,spid,hw,shl,dj,hshj,je,hsje,shlv,she,zengp,pihao,sxrq,baozhiqi,is_chonghong,
ch_shl,chdj_sn,yshl,yhshj,is_zx,lastmodifytime,ydj,ndj,nhshj,is_fp)
values(@djbh,@dj_sn,@dj_sort,@spid,@hw,@shl,@dj,@hshj,@je,@hsje,@shlv,@she,@zengp,@pihao,@sxrq,@baozhiqi,@is_chonghong,
@ch_shl,@chdj_sn,@yshl,@yhshj,@is_zx,@lastmodifytime,@ydj,@ndj,@nhshj,@is_fp)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
