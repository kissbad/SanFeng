using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Quotation.YK
{
    public class Goods_q
    {
        public int line { get; set; }
        public int goodsid { get; set; }
        public string? goodsname { get; set; }
        public string? currencyname { get; set; }
        public string? factoryname { get; set; }
        public string? holdersname { get; set; }
        public string? goodstype { get; set; }
        public string? approvedocno { get; set; }
        public string? barcode { get; set; }
        public decimal examprice { get; set; }
        public decimal price { get; set; }
        public decimal marketprice { get; set; }
        public decimal terminalprice { get; set; }
        public DateTime invaliddate { get; set; }
        public decimal baojia { get; set; }
        public static List<Goods_q> getList(Goods g)
        {
            string sql = "";
            DataTable data = new DataTable();

            if (!string.IsNullOrEmpty(g.barcode))
            {
                sql = @"select goodsid,goodsname,currencyname,factoryname,holdersname,goodstype,approvedocno,barcode,
examprice,price,marketprice,terminalprice,invaliddate from wqh_quotation where  barcode = :barcode ";

                data = Oracle.ExecuteDataTable(sql, new OracleParameter("barcode", g.barcode));
            }

            if (data.Rows.Count == 0 && !string.IsNullOrEmpty(g.approvedocno) && !string.IsNullOrEmpty(g.goodstype))
            {
                sql = @"select goodsid,goodsname,currencyname,factoryname,holdersname,goodstype,approvedocno,barcode,
examprice,price,marketprice,terminalprice,invaliddate from wqh_quotation where approvedocno = :approvedocno and goodstype = :goodstype";
                data = Oracle.ExecuteDataTable(sql, [new OracleParameter("approvedocno", g.approvedocno),new OracleParameter("goodstype", g.goodstype)]);
            }

            if (data.Rows.Count == 0 && !string.IsNullOrEmpty(g.approvedocno))
            {
                sql = @"select goodsid,goodsname,currencyname,factoryname,holdersname,goodstype,approvedocno,barcode,
examprice,price,marketprice,terminalprice,invaliddate from wqh_quotation where approvedocno = :approvedocno ";
                data = Oracle.ExecuteDataTable(sql, new OracleParameter("approvedocno", g.approvedocno));
            }

            return WQH.Convert.TableToList<Goods_q>(data);
        }
    }
}
