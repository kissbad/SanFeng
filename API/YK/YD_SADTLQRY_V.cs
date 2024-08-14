using Oracle.ManagedDataAccess.Client;

namespace API.YK
{
    public class YD_SADTLQRY_V
    {
        public int SALESID { get; set; }
        public string? SATYPEID { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? ISREGISTERFLAG { get; set; }
        public DateTime CREDATE { get; set; }
        public decimal TOTAL { get; set; }
        public string? CUSTOMNAME { get; set; }
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public string? CONTACTMAN { get; set; }
        public string? MERMECDEPTNAME { get; set; }
        public string? PROVINCENAME { get; set; }
        public string? STIOFLAG { get; set; }
        public DateTime STIODATE { get; set; }
        public string? ISRECFLAGDTL { get; set; }
        public string? INVOICENAME { get; set; }
        public string? SALERMASTERNAME { get; set; }
        public string? BIOSSALERNAME { get; set; }
        public int SALESDTLID { get; set; }
        public int GOODSID { get; set; }
        public decimal UNITPRICE { get; set; }
        public int GOODSQTY { get; set; }
        public decimal TOTAL_LINE { get; set; }
        public string? GOODSNAME { get; set; }
        public string? CURRENCYNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public int PACKSIZE { get; set; }
        public string? PACKNAME { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? LOTNO { get; set; }
        public DateTime INVALIDDATE { get; set; }
        public DateTime PRODDATE { get; set; }
        public decimal COSTINGPRICE { get; set; }
        public decimal SALESTAXRATE { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }
        public decimal COSTINGMONEY { get; set; }
        public decimal PROFIT { get; set; }


        public static object get_sum(string and) {
            string sql = @"select nvl(sum(total_line),0) sumtotal_line,nvl(sum(costingmoney),0) sumcostingmoney,nvl(sum(profit),0) sumprofit,nvl(sum(goodsqty),0) sumgoodsqty
from yd_sadtlqry_v yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumtotal_line = Convert.ToDecimal(sum.Rows[0]["sumtotal_line"]);
            decimal sumcostingmoney = Convert.ToDecimal(sum.Rows[0]["sumcostingmoney"]);
            decimal sumprofit = Convert.ToDecimal(sum.Rows[0]["sumprofit"]);
            decimal sumgoodsqty = Convert.ToDecimal(sum.Rows[0]["sumgoodsqty"]);
            return new { sumtotal_line, sumcostingmoney , sumprofit , sumgoodsqty };
        }
    }
}
