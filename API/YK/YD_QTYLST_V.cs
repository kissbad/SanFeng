namespace API.YK
{
    public class YD_QTYLST_V
    {
        public int GOODSID { get; set; }
        public string? ISRECFLAG { get; set; }
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
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public decimal SALESTAXRATE { get; set; }
        public string? GOODSSTATUS { get; set; }
        public int GOODSQTY { get; set; }
        public int AVAILABLEQTY { get; set; }
        public string? COMMCOEF { get; set; }
        public decimal COSTPRICE { get; set; }
        public decimal COSTINGMONEY { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }
        public decimal packqty { get; set; }
        public string? posno { get; set; }
        public DateTime originalsudate { get; set; }


        public static object get_sum(string and)
        {
            string sql = @"select nvl(sum(yd_view.availableqty), 0) sumavailableqty,
       nvl(sum(yd_view.goodsqty), 0) sumgoodsqty,
       nvl(sum(yd_view.costingmoney), 0) sumcostingmoney,
       round(nvl(sum(packqty), 0),3) sumpackqty
  from yd_qtylst_v yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumavailableqty = Convert.ToDecimal(sum.Rows[0]["sumavailableqty"]);
            decimal sumgoodsqty = Convert.ToDecimal(sum.Rows[0]["sumgoodsqty"]);
            decimal sumcostingmoney = Convert.ToDecimal(sum.Rows[0]["sumcostingmoney"]);
            decimal sumpackqty = Convert.ToDecimal(sum.Rows[0]["sumpackqty"]);
            return new { sumavailableqty, sumgoodsqty, sumcostingmoney, sumpackqty };
        }
    }
}
