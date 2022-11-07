using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class mchk : DataInfor, Interface.mchk
    {
        public string dwbh { get; set; }
        public string danwbh { get; set; }
        public string dwmch { get; set; }
        public string zjm { get; set; }
        public string kemuhao { get; set; }
        public string ywy { get; set; }
        public string kehufl { get; set; }
        public string quyufl { get; set; }
        public string kehulb { get; set; }
        public string isjh { get; set; }
        public string isxs { get; set; }
        public string shh { get; set; }
        public string dzhdh { get; set; }
        public string yhzhh { get; set; }
        public string lxr { get; set; }
        public string zipno { get; set; }
        public string kehudengji { get; set; }
        public string lxrdh { get; set; }
        public decimal ghxde { get; set; }
        public decimal xsxde { get; set; }
        public int otd { get; set; }
        public int xdqxg { get; set; }
        public int xdqxx { get; set; }
        public decimal koul { get; set; }
        public decimal canskl { get; set; }
        public decimal yshye { get; set; }
        public decimal yfye { get; set; }
        public decimal yingshsx { get; set; }
        public decimal yshjzh { get; set; }
        public decimal yfjzh { get; set; }
        public string beactive { get; set; }
        public string oldcode { get; set; }
        public string yishj { get; set; }
        public string xvkz { get; set; }
        public string shfyyzz { get; set; }
        public string yingyzz { get; set; }
        public string jingyfw { get; set; }
        public string hangymch { get; set; }
        public decimal oldyfye { get; set; }
        public decimal oldyshye { get; set; }
        public string frdb { get; set; }
        public decimal zhgzsh { get; set; }
        public decimal zhj_bl { get; set; }
        public decimal shn_xshe { get; set; }
        public string heshitg { get; set; }
        public decimal pzhshl { get; set; }
        public string zhj_dh { get; set; }
        public string is_zhdshg { get; set; }
        public string zjxpzh { get; set; }
        public string is_pxrz { get; set; }
        public string is_wf { get; set; }
        public string zhuypzh { get; set; }
        public string is_xkz { get; set; }
        public string is_yyzz { get; set; }
        public string is_shqwtsh { get; set; }
        public string is_shgzh { get; set; }
        public string is_shfzh { get; set; }
        public string is_lxdh { get; set; }
        public string is_zhlbzhxy { get; set; }
        public string is_jq { get; set; }
        public string is_gb { get; set; }
        public string is_jg { get; set; }
        public string qita { get; set; }
        public string bmyj { get; set; }
        public string zhj_yj { get; set; }
        public string zhgshp { get; set; }
        public string tbrq { get; set; }
        public string zhlfzr { get; set; }
        public decimal shn_hgl { get; set; }
        public string culture { get; set; }
        public string zhibumen { get; set; }
        public string shenhrq { get; set; }
        public string xkzyxq { get; set; }
        public string gspzsyxq { get; set; }
        public string gmpzsyxq { get; set; }
        public string khyh { get; set; }
        public string dzdh { get; set; }
        public string psdzm { get; set; }
        public string lastmodifytime { get; set; }
        public string czcaozy { get; set; }
        public string idcard { get; set; }
        public string xvkzname { get; set; }
        public string fzhjg { get; set; }
        public string fzhrq { get; set; }
        public string yyzzdjjg { get; set; }
        public decimal reg_capital { get; set; }
        public string shwdjh { get; set; }
        public string jyfsh { get; set; }
        public string zlzhshbh { get; set; }
        public string limitTime { get; set; }
        public decimal gonghnl { get; set; }
        public string gmpzsh { get; set; }
        public string faxno { get; set; }
        public decimal yusye { get; set; }
        public decimal yufye { get; set; }
        public decimal flye { get; set; }
        public string yyzzyxq { get; set; }
        public string chnjsts { get; set; }
        public string is_tingy { get; set; }
        public string dwjc { get; set; }
        public string dqzt { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string dah { get; set; }
        public string khywy { get; set; }
        public decimal zczj { get; set; }
        public string ckdz { get; set; }
        public decimal bgmj { get; set; }
        public decimal ckmj { get; set; }
        public string wyqk { get; set; }
        public string gsrs { get; set; }
        public string cls { get; set; }
        public string fpdz { get; set; }
        public string fpdh { get; set; }
        public decimal nxse { get; set; }
        public string jssm { get; set; }
        public string ckdh { get; set; }
        public string zyfze { get; set; }
        public string cwzyfzr { get; set; }
        public string cwlxdh { get; set; }
        public string jsfs { get; set; }
        public string khjc { get; set; }
        public string khrq { get; set; }
        public string czdjbh { get; set; }
        public string shenhr { get; set; }
        public string shenhe { get; set; }
        public string shenhtime { get; set; }
        public string shenhyj { get; set; }
        public string beizhu { get; set; }
        public string quyuid { get; set; }
        public string quyucode { get; set; }
        public string gxrq { get; set; }
        public string is_lastprice { get; set; }
        public string fcdj { get; set; }
        public string thfs { get; set; }
        public string syrq { get; set; }
        public string bh { get; set; }
        public string is_gsp { get; set; }
        public string GMP_zsfw { get; set; }
        public string qy_zhcedz { get; set; }
        public string frwtr { get; set; }
        public string frwts { get; set; }
        public string wtfw { get; set; }
        public string frwtsxq { get; set; }
        public string denglrq { get; set; }
        public string rzqk { get; set; }
        public string fkfs { get; set; }
        public string kpy { get; set; }
        public string iskh { get; set; }
        public string quyu { get; set; }
        public string oldcode2 { get; set; }
        public string dwlb { get; set; }
        public string modifytime { get; set; }
        public string modifier { get; set; }
        public string is_yshdmb { get; set; }
        public string duifbsh_ls { get; set; }
        public string is_yjbg { get; set; }
        public int piczq { get; set; }
        public decimal jifen { get; set; }
        public decimal ljjifen { get; set; }
        public string is_tb { get; set; }
        public string InvType { get; set; }
        public string khqy { get; set; }
        public string dept { get; set; }

        public static List<mchk> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return conn.Query<mchk>("select * from mchk(nolock) where lastmodifytime > Dateadd(d,-7,convert(datetime,@lastmodifytime))", new { lastmodifytime }).ToList();
            }
        }
    }
}
