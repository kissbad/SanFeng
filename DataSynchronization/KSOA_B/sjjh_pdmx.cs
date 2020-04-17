using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_pdmx:DataInfor
    {
        public static void Save(Interface.pdmx data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_pdmx where djbh = @djbh and dj_sn = @dj_sn";
                if (conn.QueryFirst<int>(sql, new { data.djbh,data.dj_sn }) > 0)
                {
                    string sql1 = @"update a set spid = @spid,dj_sort = @dj_sort,pdbz = @pdbz,plh = @plh,dw = @dw,pihao = @pihao,jlgg = @jlgg,baozhshl = @baozhshl,
lingsshl = @lingsshl,shpshl = @shpshl,shpje = @shpje,zhmshl = @zhmshl,zhmje = @zhmje,chbdj = @chbdj,psshl = @psshl,
psje = @psje,lshj = @lshj,sxrq = @sxrq,is_shp = @is_shp,jwh = @jwh,baozhiqi = @baozhiqi,beizhu = @beizhu,Hjid = @Hjid,
jiansh = @jiansh,Tpid = @Tpid,biaoshi = @biaoshi,fkcshl = @fkcshl,isxzph = @isxzph,ychbdj = @ychbdj,lastmodifytime = @lastmodifytime
from sjjh_pdmx a
where djbh = @djbh and dj_sn = @dj_sn ";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_pdmx(djbh,dj_sn,spid,dj_sort,pdbz,plh,dw,pihao,jlgg,baozhshl,lingsshl,shpshl,shpje,zhmshl,zhmje,chbdj,
psshl,psje,lshj,sxrq,is_shp,jwh,baozhiqi,beizhu,Hjid,jiansh,Tpid,biaoshi,fkcshl,isxzph,ychbdj,lastmodifytime)
values(@djbh,@dj_sn,@spid,@dj_sort,@pdbz,@plh,@dw,@pihao,@jlgg,@baozhshl,@lingsshl,@shpshl,@shpje,@zhmshl,@zhmje,@chbdj,@psshl,
@psje,@lshj,@sxrq,@is_shp,@jwh,@baozhiqi,@beizhu,@Hjid,@jiansh,@Tpid,@biaoshi,@fkcshl,@isxzph,@ychbdj,@lastmodifytime)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
