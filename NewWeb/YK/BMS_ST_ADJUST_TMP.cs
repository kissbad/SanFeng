using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class BMS_ST_ADJUST_TMP
    {
        public int STADJUSTID { get; set; }
        public int CREDATE { get; set; }
        public int INPUTMANID { get; set; }
        public string? STORAGEID { get; set; }
        public string? MEMO { get; set; }
        public int ADJUSTMANID { get; set; }
        public DateTime ADJUSTDATE { get; set; }
        public string? COMEFROM { get; set; }
        public int SOURCEID { get; set; }
        public int COMPANYID { get; set; }
        public string? ADDRESS { get; set; }
        public int TRANSLINEID { get; set; }
        public int GOODSID { get; set; }
        public int GOODSDTLID { get; set; }
        public int BATCHID { get; set; }
        public int LOTID { get; set; }
        public int POSID { get; set; }
        public int GOODSSTATUSID { get; set; }
        public int NEWPOSID { get; set; }
        public int GOODSQTY { get; set; }
        public int PRINTCOUNT { get; set; }
        public string? PRINTDATE { get; set; }
        public int PRINTMANID { get; set; }
        public int ENTRYID { get; set; }
        public string? PICKSTATUS { get; set; }
        public DateTime PICKDATE { get; set; }
        public string? ADJUSTMANNAME { get; set; }
        public decimal UNITPRICE { get; set; }

        public static void print(int stadjustid, int employeeid)
        {
            string sql = @"update BMS_ST_ADJUST_TMP set PRINTMANID= :employeeid ,PRINTDATE = SYSDATE,PRINTCOUNT = nvl(PRINTCOUNT,0)+1 where stadjustid = :stadjustid";
            if (Oracle.ExecuteNonQuery(sql, [new OracleParameter("employeeid", employeeid), new OracleParameter("stadjustid", stadjustid)]) <= 0)
            {
                throw new Exception("记录打印数据失败！！");
            }
        }
    }
}
