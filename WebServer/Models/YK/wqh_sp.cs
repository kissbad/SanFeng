using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Razor.Tokenizer.Symbols;

namespace WebServer.YK
{
    public class wqh_sp
    {
        public int goodsid { get; set; }
        public string goodsname { get; set; }
        public string currencyname { get; set; }
        public string opcode { get; set; }
        public string barcode { get; set; }
        public string goodstype { get; set; }
        public string goodsunit { get; set; }
        public string factoryname { get; set; }
        public string holdersname { get; set; }
        public string approvedocno { get; set; }

        public static List<wqh_sp> get_splist(string keyword) {
            string sql = @"select goodsid, goodsname, currencyname, opcode, barcode, goodstype, goodsunit, factoryname, holdersname, approvedocno 
from wqh_sp
where to_char(GOODSID) = :keyword or to_char(BARCODE) = :keyword or GOODSNAME like '%' || :keyword || '%' or CURRENCYNAME like '%' || :keyword || '%' or OPCODE like '%' || upper(:keyword)|| '%'";
            var splist = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("keyword", keyword) });
            return WQH.Convert.TableToList<wqh_sp>(splist);
        }

        public static void update_barcode(int goodsid,string barcode) {
            string sql = @"update pub_goods set barcode = '"+ barcode + "' where goodsid = " + goodsid;
            Oracle.ExecuteNonQuery(sql);
        }
    }
}