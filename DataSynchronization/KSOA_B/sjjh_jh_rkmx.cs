using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_jh_rkmx : DataInfor
    {
        public static void Save(Interface.jh_rkmx data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_jh_rkmx where djbh = @djbh and dj_sn = @dj_sn";
                if (conn.QueryFirst<int>(sql, new { data.djbh, data.dj_sn }) > 0)
                {
                    string sql1 = @"update a set dj_sort = @dj_sort,spid = @spid,hw = @hw,shl = @shl,dj = @dj,hshj = @hshj,je = @je,hsje = @hsje,shlv = @shlv,
she = @she,zengp = @zengp,pihao = @pihao,sxrq = @sxrq,baozhiqi = @baozhiqi,is_fp = @is_fp,pfpj = @pfpj,is_dj = @is_dj,
jwh = @jwh,is_chonghong = @is_chonghong,ch_shl = @ch_shl,chdj_sn = @chdj_sn,yshl = @yshl,yhshj = @yhshj,is_zx = @is_zx,
lastmodifytime = @lastmodifytime,ydj = @ydj,ndj = @ndj,nhshj = @nhshj
from sjjh_jh_rkmx a
where djbh = @djbh and dj_sn = @dj_sn";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_jh_rkmx(djbh,dj_sn,dj_sort,spid,hw,shl,dj,hshj,je,hsje,shlv,she,zengp,pihao,sxrq,baozhiqi,
is_fp,pfpj,is_dj,jwh,is_chonghong,ch_shl,chdj_sn,yshl,yhshj,is_zx,is_sjjh,lastmodifytime,ydj,ndj,nhshj)
values(@djbh,@dj_sn,@dj_sort,@spid,@hw,@shl,@dj,@hshj,@je,@hsje,@shlv,@she,@zengp,@pihao,@sxrq,@baozhiqi,
@is_fp,@pfpj,@is_dj,@jwh,@is_chonghong,@ch_shl,@chdj_sn,@yshl,@yhshj,@is_zx,'',@lastmodifytime,@ydj,@ndj,@nhshj)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
