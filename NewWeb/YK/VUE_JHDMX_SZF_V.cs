using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class VUE_JHDMX_SZF_V
    {
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? LOTNO { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? PACKSIZE { get; set; }
        public string? ZL { get; set; }
        public int ZJ { get; set; }
        public int SJ { get; set; }
        public string? POSNO { get; set; }
        public string? STHOUSENAME { get; set; }
        public int PICKDOCID { get; set; }
        public string? ECODEFLAG { get; set; }
        public int SORTNUMBER_A { get; set; }
        public int SORTNUMBER_B { get; set; }
        public string? MEDPACKINTER { get; set; }

        public static List<VUE_JHDMX_SZF_V> get_data(int task)
        {
            string sql = @"select * from VUE_JHDMX_SZF_V WHERE PICKDOCID = :task order by sortnumber_a,sortnumber_b";
            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("task", task)]);
            return WQH.Convert.TableToList<VUE_JHDMX_SZF_V>(data);
        }
    }
}
