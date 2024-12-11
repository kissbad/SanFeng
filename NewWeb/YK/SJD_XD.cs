using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class SJD_XD
    {
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? GOODSUNIT { get; set; }
        public int DTLGOODSQTY { get; set; }
        public int ZJ { get; set; }
        public int SJ { get; set; }
        public string? LOTNO { get; set; }
        public string? STHOUSENAME { get; set; }
        public string? POSNO { get; set; }
        public string? ECODEFLAG { get; set; }
        public int IODTLID { get; set; }

        public static List<SJD_XD> get_list(int task)
        {
            string sql = @"SELECT goodsid,goodsname,goodstype,factoryname,goodsunit,dtlgoodsqty, 
floor(A.dtlgoodsqty / packsize) zj, decode(substr((A.dtlgoodsqty - floor(A.dtlgoodsqty / packsize) * packsize), 1, 1), '.', '0' || 
(A.dtlgoodsqty - floor(A.dtlgoodsqty / packsize) * packsize), 
(dtlgoodsqty - floor(A.dtlgoodsqty / packsize) * packsize)) sj,  
lotno, sthousename, posno, DECODE(NVL(ecodeflag,0),0,'否','是') ecodeflag, iodtlid 
FROM bms_st_io_dtl_finputin_v a 
WHERE A.TASKID = :TASKID";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("task", task)]);
            return WQH.Convert.TableToList<SJD_XD>(data);
        }
    }
}
