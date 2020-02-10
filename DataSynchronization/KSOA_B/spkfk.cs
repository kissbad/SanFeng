using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class spkfk : DataInfor
    {
        public static void Save(Interface.spkfk spkfk)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from spkfk where spid = @spid";
                if (conn.QueryFirst<int>(sql, new { spkfk.spid }) > 0)
                {
                    string sql1 = @"update a set spbh = @spbh,sptm = @sptm,spmch = @spmch,zjm = @zjm,beactive = @beactive,yishj = @yishj,is_gdsj = @is_gdsj,
is_gdzk = @is_gdzk,is_tjsp = @is_tjsp,is_hysp = @is_hysp,is_gmp = @is_gmp,is_gsp = @is_gsp,is_sy = @is_sy,is_yp = @is_yp,jingd = @jingd,
denglrq = @denglrq,gengxshj = @gengxshj,delrq = @delrq,dw = @dw,shpchd = @shpchd,shpgg = @shpgg,kemuhao = @kemuhao,oldcode = @oldcode,
rkhw = @rkhw,ckhw = @ckhw,bzqfs = @bzqfs,fenlbh = @fenlbh,guojbh = @guojbh,changjbh = @changjbh,huaxm = @huaxm,changym = @changym,
suming = @suming,xiwname = @xiwname,tongym = @tongym,shengccj = @shengccj,pizhwh = @pizhwh,zhucsb = @zhucsb,jixing = @jixing,
shiyzh = @shiyzh,bulfy = @bulfy,chuczysx = @chuczysx,chuffl = @chuffl,yaofpd = @yaofpd,yongfyyl = @yongfyyl,jinjzh = @jinjzh,
zhuysx = @zhuysx,yaowchf = @yaowchf,youxq = @youxq,shangplx = @shangplx,guizbz = @guizbz,yongyfl = @yongyfl,leibie = @leibie,
jlgg = @jlgg,otd = @otd,ordercycle = @ordercycle,stkquot = @stkquot,shlv = @shlv,hshjj = @hshjj,jj = @jj,shj = @shj,hshsj = @hshsj,
lshj = @lshj,koul = @koul,kcsx = @kcsx,kcxx = @kcxx,helkc = @helkc,bzqts = @bzqts,yujts = @yujts,zgshl = @zgshl,zhdcbj = @zhdcbj,
zdshj = @zdshj,zgshj = @zgshj,zgjjxz = @zgjjxz,maolv = @maolv,huiytj = @huiytj,itemlength = @itemlength,itemheight = @itemheight,
itemwidth = @itemwidth,weight = @weight,casevolume = @casevolume,caseweight = @caseweight,zuixdwtj = @zuixdwtj,zuixdwzl = @zuixdwzl,
pfpj = @pfpj,dispcolor = @dispcolor,jx = @jx,bzgg = @bzgg,lastmodifytime = @lastmodifytime,is_cmd = @is_cmd,lsgg = @lsgg,is_zdyh = @is_zdyh,
is_jkyp = @is_jkyp,minshl = @minshl,cx_dj_kl = @cx_dj_kl,is_cx_dj = @is_cx_dj,zdyh = @zdyh,zdhyzklshj = @zdhyzklshj,is_cyhydz = @is_cyhydz,
huiyshl = @huiyshl,nocalcopys = @nocalcopys,fuzr = @fuzr,is_jsh = @is_jsh,is_lc = @is_lc,is_zhongyao = @is_zhongyao,type_bh = @type_bh,
zdlshj = @zdlshj,guanjzjh = @guanjzjh,shiyq = @shiyq,abbrImageURL = @abbrImageURL,cbflbh = @cbflbh,imageUrl = @imageUrl,is_ybsp = @is_ybsp,
yb_zfbl = @yb_zfbl,yb_spbh = @yb_spbh,username = @username,chuchj = @chuchj,pifj = @pifj,zhilbz = @zhilbz,chargelb = @chargelb,
is_sendybzx = @is_sendybzx,tj_ylshj = @tj_ylshj,is_hj = @is_hj,is_yxbz = @is_yxbz,wdid = @wdid,chbjs = @chbjs,dwbh = @dwbh,zengp = @zengp,
beizhu = @beizhu,zhongbz = @zhongbz,jifen = @jifen,hyj = @hyj,pizhwhxq = @pizhwhxq,spsx = @spsx,czdjbh = @czdjbh,sp_beizhu = @sp_beizhu,
dah = @dah,dzjgm = @dzjgm,chuctj = @chuctj,syrq = @syrq,length = @length,width = @width,height = @height,maozh = @maozh,cgfzr = @cgfzr,
bzckkf = @bzckkf,is_xj = @is_xj,khywy = @khywy,cxxx = @cxxx,tchdj = @tchdj,yblx = @yblx,is_jf = @is_jf,tongymzjm = @tongymzjm,
bili = @bili,bilie = @bilie,spywzt = @spywzt,dians = @dians,is_srzp = @is_srzp,is_yb = @is_yb,is_jifen = @is_jifen,shj1 = @shj1,
shj2 = @shj2,shj3 = @shj3,shj4 = @shj4,shj5 = @shj5,shj6 = @shj6,shj7 = @shj7,shj8 = @shj8,gxrq = @gxrq,hszhongbj = @hszhongbj,
hsfzhongbj = @hsfzhongbj,fzhongbj = @fzhongbj,zhongbj = @zhongbj,shengccjzjm = @shengccjzjm,jibie = @jibie,is_cx = @is_cx,
cx_start_date = @cx_start_date,cx_end_date = @cx_end_date,wgj = @wgj,wgpp = @wgpp,wgfl = @wgfl,sjsj = @sjsj,scsj = @scsj,xxwb = @xxwb,
is_jytm = @is_jytm,is_cg = @is_cg,laihxz = @laihxz,khxszdj = @khxszdj,baozhgg = @baozhgg,zsbzgg = @zsbzgg,zhongbzgg = @zhongbzgg,
zglshj = @zglshj,oldcode2 = @oldcode2,jianyxm = @jianyxm,bzgd = @bzgd,guig = @guig,fyjs = @fyjs,cx_spfl = @cx_spfl,is_xianxsp = @is_xianxsp,
sp_cxxx = @sp_cxxx,pifj1 = @pifj1,gnlb = @gnlb,zdchbj = @zdchbj,jyfw = @jyfw,is_dzjgm = @is_dzjgm,jylb = @jylb,bwm = @bwm,dzjgfl = @dzjgfl,
is_glsx = @is_glsx,tsglyp = @tsglyp,tsyp = @tsyp,xfjlyp = @xfjlyp,rsjb = @rsjb,yyzjej = @yyzjej,ylqxej = @ylqxej,yssx = @yssx,zhuzlx = @zhuzlx,
qiche = @qiche,tielu = @tielu,hangkong = @hangkong,chuanyun = @chuanyun,is_yjbg = @is_yjbg,yanghffcsh = @yanghffcsh,xz = @xz,modifier = @modifier,
modifytime = @modifytime,oldshpgg = @oldshpgg,zhongbz2 = @zhongbz2,pinzlx = @pinzlx,yhts = @yhts,frdb = @frdb,dzhdh = @dzhdh,lxrdh = @lxrdh,
zipno = @zipno,faxno = @faxno,yingyzz = @yingyzz,SERIAL_MED = @SERIAL_MED,sjf = @sjf,tcbl = @tcbl,spdw = @spdw,plhz = @plhz,bwtqy = @bwtqy,
is_dj = @is_dj,nocyzdkoul = @nocyzdkoul,getpihao = @getpihao,minbz = @minbz,is_cl = @is_cl,cl_jlgg = @cl_jlgg,cl_dj = @cl_dj,cl_dw = @cl_dw,
is_huiysp = @is_huiysp,xxshl = @xxshl,xgshl = @xgshl,is_chfy = @is_chfy,is_nocyzyzdzk = @is_nocyzyzdzk,cubage = @cubage,jgmzhongbz = @jgmzhongbz,
shuilv = @shuilv,cx_nr = @cx_nr,uField1 = @uField1,uField2 = @uField2,uField3 = @uField3,uField4 = @uField4,uField5 = @uField5,uField6 = @uField6,
uField7 = @uField7,uField8 = @uField8,uField9 = @uField9,uField10 = @uField10,is_tb = @is_tb,taxcode = @taxcode,dept = @dept,ypcyr = @ypcyr
from spkfk a where a.spid = @spid";
                    conn.Execute(sql1, spkfk);
                }
                else
                {
                    string sql2 = @"insert into spkfk(spid,spbh,sptm,spmch,zjm,beactive,yishj,is_gdsj,is_gdzk,is_tjsp,is_hysp,is_gmp,
is_gsp,is_sy,is_yp,jingd,denglrq,gengxshj,delrq,dw,shpchd,shpgg,kemuhao,oldcode,rkhw,ckhw,bzqfs,fenlbh,guojbh,changjbh,huaxm,changym,
suming,xiwname,tongym,shengccj,pizhwh,zhucsb,jixing,shiyzh,bulfy,chuczysx,chuffl,yaofpd,yongfyyl,jinjzh,zhuysx,yaowchf,youxq,shangplx,
guizbz,yongyfl,leibie,jlgg,otd,ordercycle,
stkquot,shlv,hshjj,jj,shj,hshsj,lshj,koul,kcsx,kcxx,helkc,bzqts,yujts,zgshl,zhdcbj,zdshj,zgshj,zgjjxz,maolv,huiytj,itemlength,
itemheight,itemwidth,weight,casevolume,caseweight,zuixdwtj,zuixdwzl,pfpj,dispcolor,jx,bzgg,lastmodifytime,is_cmd,lsgg,is_zdyh,
is_jkyp,minshl,cx_dj_kl,is_cx_dj,zdyh,zdhyzklshj,is_cyhydz,huiyshl,nocalcopys,fuzr,is_jsh,is_lc,is_zhongyao,type_bh,zdlshj,
guanjzjh,shiyq,abbrImageURL,cbflbh,imageUrl,is_ybsp,yb_zfbl,yb_spbh,username,chuchj,pifj,zhilbz,chargelb,is_sendybzx,tj_ylshj,
is_hj,is_yxbz,wdid,chbjs,dwbh,zengp,beizhu,zhongbz,jifen,hyj,pizhwhxq,spsx,czdjbh,sp_beizhu,dah,dzjgm,chuctj,syrq,length,width,
height,maozh,cgfzr,bzckkf,is_xj,khywy,cxxx,tchdj,yblx,is_jf,tongymzjm,bili,bilie,spywzt,dians,is_srzp,is_yb,is_jifen,shj1,shj2,
shj3,shj4,shj5,shj6,shj7,shj8,gxrq,hszhongbj,hsfzhongbj,fzhongbj,zhongbj,shengccjzjm,jibie,is_cx,cx_start_date,cx_end_date,wgj,
wgpp,wgfl,sjsj,scsj,xxwb,is_jytm,is_cg,laihxz,khxszdj,baozhgg,zsbzgg,zhongbzgg,zglshj,oldcode2,jianyxm,bzgd,guig,fyjs,cx_spfl,
is_xianxsp,sp_cxxx,pifj1,gnlb,zdchbj,jyfw,is_dzjgm,jylb,bwm,dzjgfl,is_glsx,tsglyp,tsyp,xfjlyp,rsjb,yyzjej,ylqxej,yssx,zhuzlx,
qiche,tielu,hangkong,chuanyun,is_yjbg,yanghffcsh,xz,modifier,modifytime,oldshpgg,zhongbz2,pinzlx,yhts,frdb,dzhdh,lxrdh,zipno,
faxno,yingyzz,SERIAL_MED,sjf,tcbl,spdw,plhz,bwtqy,is_dj,nocyzdkoul,getpihao,minbz,is_cl,cl_jlgg,cl_dj,cl_dw,is_huiysp,xxshl,
xgshl,is_chfy,is_nocyzyzdzk,cubage,jgmzhongbz,shuilv,cx_nr,uField1,uField2,uField3,uField4,uField5,uField6,uField7,uField8,
uField9,uField10,is_tb,taxcode,dept,ypcyr)
values(@spid,@spbh,@sptm,@spmch,@zjm,@beactive,@yishj,@is_gdsj,@is_gdzk,@is_tjsp,@is_hysp,@is_gmp,@is_gsp,@is_sy,@is_yp,@jingd,@denglrq,
@gengxshj,@delrq,@dw,@shpchd,@shpgg,@kemuhao,@oldcode,@rkhw,@ckhw,@bzqfs,@fenlbh,@guojbh,@changjbh,@huaxm,@changym,@suming,@xiwname,@tongym,
@shengccj,@pizhwh,@zhucsb,@jixing,@shiyzh,@bulfy,@chuczysx,@chuffl,@yaofpd,@yongfyyl,@jinjzh,@zhuysx,@yaowchf,@youxq,@shangplx,@guizbz,
@yongyfl,@leibie,@jlgg,@otd,@ordercycle,@stkquot,@shlv,@hshjj,@jj,@shj,@hshsj,@lshj,@koul,@kcsx,@kcxx,@helkc,@bzqts,@yujts,@zgshl,@zhdcbj,
@zdshj,@zgshj,@zgjjxz,@maolv,@huiytj,@itemlength,@itemheight,@itemwidth,@weight,@casevolume,@caseweight,@zuixdwtj,@zuixdwzl,@pfpj,
@dispcolor,@jx,@bzgg,@lastmodifytime,@is_cmd,@lsgg,@is_zdyh,@is_jkyp,@minshl,@cx_dj_kl,@is_cx_dj,@zdyh,@zdhyzklshj,@is_cyhydz,@huiyshl,
@nocalcopys,@fuzr,@is_jsh,@is_lc,@is_zhongyao,@type_bh,@zdlshj,@guanjzjh,@shiyq,@abbrImageURL,@cbflbh,@imageUrl,@is_ybsp,@yb_zfbl,
@yb_spbh,@username,@chuchj,@pifj,@zhilbz,@chargelb,@is_sendybzx,@tj_ylshj,@is_hj,@is_yxbz,@wdid,@chbjs,@dwbh,@zengp,@beizhu,@zhongbz,
@jifen,@hyj,@pizhwhxq,@spsx,@czdjbh,@sp_beizhu,@dah,@dzjgm,@chuctj,@syrq,@length,@width,@height,@maozh,@cgfzr,@bzckkf,@is_xj,@khywy,
@cxxx,@tchdj,@yblx,@is_jf,@tongymzjm,@bili,@bilie,@spywzt,@dians,@is_srzp,@is_yb,@is_jifen,@shj1,@shj2,@shj3,@shj4,@shj5,@shj6,@shj7,
@shj8,@gxrq,@hszhongbj,@hsfzhongbj,@fzhongbj,@zhongbj,@shengccjzjm,@jibie,@is_cx,@cx_start_date,@cx_end_date,@wgj,@wgpp,@wgfl,@sjsj,
@scsj,@xxwb,@is_jytm,@is_cg,@laihxz,@khxszdj,@baozhgg,@zsbzgg,@zhongbzgg,@zglshj,@oldcode2,@jianyxm,@bzgd,@guig,@fyjs,@cx_spfl,@is_xianxsp,
@sp_cxxx,@pifj1,@gnlb,@zdchbj,@jyfw,@is_dzjgm,@jylb,@bwm,@dzjgfl,@is_glsx,@tsglyp,@tsyp,@xfjlyp,@rsjb,@yyzjej,@ylqxej,@yssx,@zhuzlx,
@qiche,@tielu,@hangkong,@chuanyun,@is_yjbg,@yanghffcsh,@xz,@modifier,@modifytime,@oldshpgg,@zhongbz2,@pinzlx,@yhts,@frdb,@dzhdh,@lxrdh,
@zipno,@faxno,@yingyzz,@SERIAL_MED,@sjf,@tcbl,@spdw,@plhz,@bwtqy,@is_dj,@nocyzdkoul,@getpihao,@minbz,@is_cl,@cl_jlgg,@cl_dj,@cl_dw,
@is_huiysp,@xxshl,@xgshl,@is_chfy,@is_nocyzyzdzk,@cubage,@jgmzhongbz,@shuilv,@cx_nr,@uField1,@uField2,@uField3,@uField4,@uField5,
@uField6,@uField7,@uField8,@uField9,@uField10,@is_tb,@taxcode,@dept,@ypcyr)";
                    conn.Execute(sql2, spkfk);
                }
            }
        }
    }
}
