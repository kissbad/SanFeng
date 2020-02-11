using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_pf_ckhz:DataInfor
    {
        public static void Save(Interface.pf_ckhz data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_pf_ckhz where djbh = @djbh";
                if (conn.QueryFirst<int>(sql, new { data.djbh }) > 0)
                {
                    string sql1 = @"update a set djbs = @djbs,djlx = @djlx,rq = @rq,ontime = @ontime,bm = @bm,dwbh = @dwbh,username = @username,
ywy = @ywy,bendian = @bendian,is_zhongyao = @is_zhongyao,is_jhfh = @is_jhfh,printfa = @printfa,ychrq = @ychrq,ptmch = @ptmch,
ptdjbh = @ptdjbh,isds = @isds,is_zt = @is_zt,is_fyf = @is_fyf,is_fp = @is_fp,is_fpwc = @is_fpwc,dj_chonghong = @dj_chonghong,
is_chonghong = @is_chonghong,shouhr = @shouhr,sanhdsh = @sanhdsh,sanhjsh = @sanhjsh,wzbh = @wzbh,is_zx = @is_zx,is_sjjh = @is_sjjh,
lastmodifytime = @lastmodifytime,gldjbh = @gldjbh
from sjjh_pf_ckhz a
where djbh = @djbh";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_pf_ckhz(djbh,djbs,djlx,rq,ontime,bm,dwbh,username,ywy,bendian,is_zhongyao,
is_jhfh,printfa,ychrq,ptmch,ptdjbh,isds,is_zt,is_fyf,is_fp,is_fpwc,dj_chonghong,is_chonghong,
shouhr,sanhdsh,sanhjsh,wzbh,is_zx,is_sjjh,lastmodifytime,gldjbh)
values(@djbh,@djbs,@djlx,@rq,@ontime,@bm,@dwbh,@username,@ywy,@bendian,@is_zhongyao,
@is_jhfh,@printfa,@ychrq,@ptmch,@ptdjbh,@isds,@is_zt,@is_fyf,@is_fp,@is_fpwc,@dj_chonghong,@is_chonghong,
@shouhr,@sanhdsh,@sanhjsh,@wzbh,@is_zx,@is_sjjh,@lastmodifytime,@gldjbh)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
