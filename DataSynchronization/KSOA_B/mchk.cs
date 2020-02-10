using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class mchk:DataInfor
    {
        public static void Save(Interface.mchk mchk)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from mchk where dwbh = @dwbh";
                if (conn.QueryFirst<int>(sql, new { mchk.dwbh }) > 0)
                {
                    string sql1 = @"update a set danwbh = @danwbh,dwmch = @dwmch,zjm = @zjm,kemuhao = @kemuhao,ywy = @ywy,kehufl = @kehufl,quyufl = @quyufl,
kehulb = @kehulb,isjh = @isjh,isxs = @isxs,shh = @shh,dzhdh = @dzhdh,yhzhh = @yhzhh,lxr = @lxr,zipno = @zipno,kehudengji = @kehudengji,
lxrdh = @lxrdh,ghxde = @ghxde,xsxde = @xsxde,otd = @otd,xdqxg = @xdqxg,xdqxx = @xdqxx,koul = @koul,canskl = @canskl,yshye = @yshye,
yfye = @yfye,yingshsx = @yingshsx,yshjzh = @yshjzh,yfjzh = @yfjzh,beactive = @beactive,oldcode = @oldcode,yishj = @yishj,xvkz = @xvkz,
shfyyzz = @shfyyzz,yingyzz = @yingyzz,jingyfw = @jingyfw,hangymch = @hangymch,oldyfye = @oldyfye,oldyshye = @oldyshye,frdb = @frdb,
zhgzsh = @zhgzsh,zhj_bl = @zhj_bl,shn_xshe = @shn_xshe,heshitg = @heshitg,pzhshl = @pzhshl,zhj_dh = @zhj_dh,is_zhdshg = @is_zhdshg,
zjxpzh = @zjxpzh,is_pxrz = @is_pxrz,is_wf = @is_wf,zhuypzh = @zhuypzh,is_xkz = @is_xkz,is_yyzz = @is_yyzz,is_shqwtsh = @is_shqwtsh,
is_shgzh = @is_shgzh,is_shfzh = @is_shfzh,is_lxdh = @is_lxdh,is_zhlbzhxy = @is_zhlbzhxy,is_jq = @is_jq,is_gb = @is_gb,is_jg = @is_jg,
qita = @qita,bmyj = @bmyj,zhj_yj = @zhj_yj,zhgshp = @zhgshp,tbrq = @tbrq,zhlfzr = @zhlfzr,shn_hgl = @shn_hgl,culture = @culture,
zhibumen = @zhibumen,shenhrq = @shenhrq,xkzyxq = @xkzyxq,gspzsyxq = @gspzsyxq,gmpzsyxq = @gmpzsyxq,khyh = @khyh,dzdh = @dzdh,
psdzm = @psdzm,lastmodifytime = @lastmodifytime,czcaozy = @czcaozy,idcard = @idcard,xvkzname = @xvkzname,fzhjg = @fzhjg,
fzhrq = @fzhrq,yyzzdjjg = @yyzzdjjg,reg_capital = @reg_capital,shwdjh = @shwdjh,jyfsh = @jyfsh,zlzhshbh = @zlzhshbh,
limitTime = @limitTime,gonghnl = @gonghnl,gmpzsh = @gmpzsh,faxno = @faxno,yusye = @yusye,yufye = @yufye,flye = @flye,
yyzzyxq = @yyzzyxq,chnjsts = @chnjsts,is_tingy = @is_tingy,dwjc = @dwjc,dqzt = @dqzt,tel = @tel,email = @email,dah = @dah,
khywy = @khywy,zczj = @zczj,ckdz = @ckdz,bgmj = @bgmj,ckmj = @ckmj,wyqk = @wyqk,gsrs = @gsrs,cls = @cls,fpdz = @fpdz,fpdh = @fpdh,
nxse = @nxse,jssm = @jssm,ckdh = @ckdh,zyfze = @zyfze,cwzyfzr = @cwzyfzr,cwlxdh = @cwlxdh,jsfs = @jsfs,khjc = @khjc,khrq = @khrq,
czdjbh = @czdjbh,shenhr = @shenhr,shenhe = @shenhe,shenhtime = @shenhtime,shenhyj = @shenhyj,beizhu = @beizhu,quyuid = @quyuid,
quyucode = @quyucode,gxrq = @gxrq,is_lastprice = @is_lastprice,fcdj = @fcdj,thfs = @thfs,syrq = @syrq,bh = @bh,is_gsp = @is_gsp,
GMP_zsfw = @GMP_zsfw,qy_zhcedz = @qy_zhcedz,frwtr = @frwtr,frwts = @frwts,wtfw = @wtfw,frwtsxq = @frwtsxq,denglrq = @denglrq,
rzqk = @rzqk,fkfs = @fkfs,kpy = @kpy,iskh = @iskh,quyu = @quyu,oldcode2 = @oldcode2,dwlb = @dwlb,modifytime = @modifytime,
modifier = @modifier,is_yshdmb = @is_yshdmb,duifbsh_ls = @duifbsh_ls,is_yjbg = @is_yjbg,piczq = @piczq,jifen = @jifen,
ljjifen = @ljjifen,is_tb = @is_tb,InvType = @InvType,khqy = @khqy,dept = @dept
from mchk a where a.dwbh = @dwbh";
                    conn.Execute(sql1, mchk);
                }
                else
                {
                    string sql2 = @"insert into mchk(dwbh,danwbh,dwmch,zjm,kemuhao,ywy,kehufl,quyufl,kehulb,isjh,isxs,shh,dzhdh,yhzhh,lxr,zipno,kehudengji,lxrdh,ghxde,xsxde,otd,xdqxg,
xdqxx,koul,canskl,yshye,yfye,yingshsx,yshjzh,yfjzh,beactive,oldcode,yishj,xvkz,shfyyzz,yingyzz,jingyfw,hangymch,oldyfye,oldyshye,
frdb,zhgzsh,zhj_bl,shn_xshe,heshitg,pzhshl,zhj_dh,is_zhdshg,zjxpzh,is_pxrz,is_wf,zhuypzh,is_xkz,is_yyzz,is_shqwtsh,is_shgzh,is_shfzh,
is_lxdh,is_zhlbzhxy,is_jq,is_gb,is_jg,qita,bmyj,zhj_yj,zhgshp,tbrq,zhlfzr,shn_hgl,culture,zhibumen,shenhrq,xkzyxq,gspzsyxq,gmpzsyxq,
khyh,dzdh,psdzm,lastmodifytime,czcaozy,idcard,xvkzname,fzhjg,fzhrq,yyzzdjjg,reg_capital,shwdjh,jyfsh,zlzhshbh,limitTime,gonghnl,gmpzsh,
faxno,yusye,yufye,flye,yyzzyxq,chnjsts,is_tingy,dwjc,dqzt,tel,email,dah,khywy,zczj,ckdz,bgmj,ckmj,wyqk,gsrs,cls,fpdz,fpdh,nxse,jssm,
ckdh,zyfze,cwzyfzr,cwlxdh,jsfs,khjc,khrq,czdjbh,shenhr,shenhe,shenhtime,shenhyj,beizhu,quyuid,quyucode,gxrq,is_lastprice,fcdj,thfs,
syrq,bh,is_gsp,GMP_zsfw,qy_zhcedz,frwtr,frwts,wtfw,frwtsxq,denglrq,rzqk,fkfs,kpy,iskh,quyu,oldcode2,dwlb,modifytime,modifier,
is_yshdmb,duifbsh_ls,is_yjbg,piczq,jifen,ljjifen,is_tb,InvType,khqy,dept)
values(@dwbh,@danwbh,@dwmch,@zjm,@kemuhao,@ywy,@kehufl,@quyufl,@kehulb,@isjh,@isxs,@shh,@dzhdh,@yhzhh,@lxr,@zipno,@kehudengji,@lxrdh,
@ghxde,@xsxde,@otd,@xdqxg,@xdqxx,@koul,@canskl,@yshye,@yfye,@yingshsx,@yshjzh,@yfjzh,@beactive,@oldcode,@yishj,@xvkz,@shfyyzz,
@yingyzz,@jingyfw,@hangymch,@oldyfye,@oldyshye,@frdb,@zhgzsh,@zhj_bl,@shn_xshe,@heshitg,@pzhshl,@zhj_dh,@is_zhdshg,@zjxpzh,@is_pxrz,
@is_wf,@zhuypzh,@is_xkz,@is_yyzz,@is_shqwtsh,@is_shgzh,@is_shfzh,@is_lxdh,@is_zhlbzhxy,@is_jq,@is_gb,@is_jg,@qita,@bmyj,@zhj_yj,
@zhgshp,@tbrq,@zhlfzr,@shn_hgl,@culture,@zhibumen,@shenhrq,@xkzyxq,@gspzsyxq,@gmpzsyxq,@khyh,@dzdh,@psdzm,@lastmodifytime,@czcaozy,
@idcard,@xvkzname,@fzhjg,@fzhrq,@yyzzdjjg,@reg_capital,@shwdjh,@jyfsh,@zlzhshbh,@limitTime,@gonghnl,@gmpzsh,@faxno,@yusye,@yufye,
@flye,@yyzzyxq,@chnjsts,@is_tingy,@dwjc,@dqzt,@tel,@email,@dah,@khywy,@zczj,@ckdz,@bgmj,@ckmj,@wyqk,@gsrs,@cls,@fpdz,@fpdh,@nxse,
@jssm,@ckdh,@zyfze,@cwzyfzr,@cwlxdh,@jsfs,@khjc,@khrq,@czdjbh,@shenhr,@shenhe,@shenhtime,@shenhyj,@beizhu,@quyuid,@quyucode,@gxrq,
@is_lastprice,@fcdj,@thfs,@syrq,@bh,@is_gsp,@GMP_zsfw,@qy_zhcedz,@frwtr,@frwts,@wtfw,@frwtsxq,@denglrq,@rzqk,@fkfs,@kpy,@iskh,
@quyu,@oldcode2,@dwlb,@modifytime,@modifier,@is_yshdmb,@duifbsh_ls,@is_yjbg,@piczq,@jifen,@ljjifen,@is_tb,@InvType,@khqy,@dept)";
                    conn.Execute(sql2, mchk);
                }
            }
        }
    }
}
