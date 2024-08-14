using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace API.YK
{
    public class Goods
    {
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? OPCODE { get; set; }
        public string? CURRENCYNAME { get; set; }
        public string? BARCODE { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public string? MEDICINETYPENAME { get; set; }
        public int PACKSIZE { get; set; }
        public string? PACKNAME { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }

        public static List<Goods> get_goodslist(string? keyword,int pageIndex, int pageSize,string? and) {
            string? sql = @"select * from (select ROWNUM as r,goodsid, goodsname, opcode, currencyname, barcode, 
goodstype, goodsunit, factoryname, holdersname, approvedocno,medicinetypename, packsize, packname, goodsclassname, goodsorganideptname, goodspositionname, zx_columncname
from yd_goods_v a
where (to_char(a.GOODSID) = :keyword or to_char(a.BARCODE) = :keyword or a.GOODSNAME like '%' || :keyword || '%' or a.CURRENCYNAME like '%' || :keyword || '%' or a.OPCODE like '%' || upper(:keyword)|| '%') and rownum <= " + pageIndex + " * " + pageSize  + " " + and + ")" +
"where r between (" + pageIndex + " - 1) * " + pageSize + " + 1 and " + pageIndex + " * " + pageSize ;

            var goods = Oracle.ExecuteDataTable(sql, [new OracleParameter("keyword", keyword)]);
            return WQH.Convert.TableToList<Goods>(goods);
        }
    }
}
