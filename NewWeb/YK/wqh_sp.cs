using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class wqh_sp
    {
        public int goodsid { get; set; }
        public string? goodsname { get; set; }
        public string? currencyname { get; set; }
        public string? opcode { get; set; }
        public string? barcode { get; set; }
        public string? goodstype { get; set; }
        public string? goodsunit { get; set; }
        public string? factoryname { get; set; }
        public string? holdersname { get; set; }
        public string? approvedocno { get; set; }

        public static List<wqh_sp> get_splist(string keyword)
        {
            string sql = @"select distinct a.goodsid, a.goodsname, a.currencyname, a.opcode, a.barcode, a.goodstype, a.goodsunit, a.factoryname, a.holdersname, a.approvedocno 
from wqh_sp a 
left join bms_st_qty_lst b on a.goodsid = b.goodsid
left join bms_storer_pos c on b.POSID = c.POSID
where to_char(a.GOODSID) = :keyword or to_char(a.BARCODE) = :keyword or a.GOODSNAME like '%' || :keyword || '%' or a.CURRENCYNAME like '%' || :keyword || '%' or a.OPCODE like '%' || upper(:keyword)|| '%'
or c.POSNO = :keyword";
            var splist = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("keyword", keyword) });
            return WQH.Convert.TableToList<wqh_sp>(splist);
        }

        public static void update_barcode(int goodsid, string barcode)
        {
            string sql = @"update pub_goods set barcode = '" + barcode + "' where goodsid = " + goodsid;
            Oracle.ExecuteNonQuery(sql);
        }
    }
}
