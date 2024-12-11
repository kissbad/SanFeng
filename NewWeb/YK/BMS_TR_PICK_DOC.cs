using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class BMS_TR_PICK_DOC
    {
        public int PICKDOCID { get; set; }
        public DateTime PRINTDATE { get; set; }
        public int PRINTMANID { get; set; }
        public int PRINTCOUNT { get; set; }
        public string? TOTALPACKQTY { get; set; }
        public DateTime CREDATE { get; set; }
        public int INPUTMANID { get; set; }
        public int USESTATUS { get; set; }
        public DateTime FINISHDATE { get; set; }
        public int COMEFROM { get; set; }
        public string? MEMO { get; set; }
        public int PICKMANID { get; set; }
        public string? BOXMANID { get; set; }
        public string? DESKID { get; set; }
        public string? WAVENO { get; set; }
        public int DRAWSTATUS { get; set; }
        public DateTime PICKDATE { get; set; }
        public int BOXQTY { get; set; }
        public int FINISHMANID { get; set; }
        public int FINISH2MANID { get; set; }
        public int TRANSLINEID { get; set; }
        public int PICKGROUPID { get; set; }
        public int CONTAINERID { get; set; }
        public int TRID { get; set; }
        public int STORERID { get; set; }
        public int GOODSUNITFLAG { get; set; }
        public int DTL_LINES { get; set; }
        public int URGENTFLAG { get; set; }
        public int NOWMSFLAG { get; set; }

        public static void print(int pickdocid, int employeeid)
        {
            string sql = @"update bms_tr_pick_doc set printmanid= :employeeid ,printdate=sysdate,printcount=nvl(printcount,0)+1 where pickdocid = :pickdocid";
            if (Oracle.ExecuteNonQuery(sql, [new OracleParameter("employeeid", employeeid), new OracleParameter("pickdocid", pickdocid)]) <= 0)
            {
                throw new Exception("记录打印数据失败！！");
            }
        }
    }
}
