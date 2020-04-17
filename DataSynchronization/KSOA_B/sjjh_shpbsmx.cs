using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_shpbsmx : DataInfor
    {
        public static void Save(Interface.shpbsmx data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_shpbsmx where djbh = @djbh and dj_sn = @dj_sn ";
                if (conn.QueryFirst<int>(sql, new { data.djbh, data.dj_sn }) > 0)
                {
                    string sql1 = @"update a set spid = @spid,recnum = @recnum,xgdjbh = @xgdjbh,dj_sort = @dj_sort,dw = @dw,pihao = @pihao,
baosshl = @baosshl,baoyshl = @baoyshl,syje = @syje,Hjid = @Hjid,sxrq = @sxrq,Tpid = @Tpid,bsyyj = @bsyyj,
beizhu = @beizhu,is_con = @is_con,baozhiqi = @baozhiqi,lastmodifytime = @lastmodifytime
from sjjh_shpbsmx a
where djbh = @djbh and dj_sn = @dj_sn ";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_shpbsmx(djbh,dj_sn,spid,recnum,xgdjbh,dj_sort,dw,pihao,baosshl,
baoyshl,syje,Hjid,sxrq,Tpid,bsyyj,beizhu,is_con,baozhiqi,lastmodifytime)
values(@djbh,@dj_sn,@spid,@recnum,@xgdjbh,@dj_sort,@dw,@pihao,@baosshl,@baoyshl,
@syje,@Hjid,@sxrq,@Tpid,@bsyyj,@beizhu,@is_con,@baozhiqi,@lastmodifytime) ";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
