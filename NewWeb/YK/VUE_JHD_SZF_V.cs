using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class VUE_JHD_SZF_V
    {
        public int PICKDOCID { get; set; }
        public string? WAVENO { get; set; }
        public string? CREDATE { get; set; }
        public int WAVEID { get; set; }
        public string? COMPANYNAME { get; set; }
        public string? INVTYPENAME { get; set; }
        public string? MERMECDEPTNAME { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? MEMO { get; set; }
        public string? CONSIGNEE { get; set; }
        public string? PLACETYPENAME { get; set; }
        public string? TRANSLINENAME { get; set; }
        public string? INPUTMANNAME { get; set; }
        public string? GOODSUNITFLAG { get; set; }
        public int XDUSESTATUS { get; set; }
        public int ZDUSESTATUS { get; set; }
        public int DRAWSTATUS { get; set; }
        public int PICKMANID { get; set; }
        public DateTime PICKDATE { get; set; }
        public int PRINTCOUNT { get; set; }
        public DateTime PRINTDATE { get; set; }
        public int PRINTMANID { get; set; }
        public int FINISHMANID { get; set; }
        public int QF_JJBZ { get; set; }
        public DateTime CONFIRMDATE { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public string? COMEFROM { get; set; }
        public string? ZX_COLUMNA { get; set; }

        public static VUE_JHD_SZF_V get_data(int task)
        {
            string sql = @"SELECT A.PICKDOCID, A.WAVENO, A.CREDATE, A.WAVEID, A.COMPANYNAME, A.INVTYPENAME, A.MERMECDEPTNAME, A.GOODSDEPTNAME,A.COMEFROM,
A.ISRECFLAG, A.MEMO, A.CONSIGNEE, A.PLACETYPENAME, A.TRANSLINENAME, A.INPUTMANNAME,A.GOODSUNITFLAG,a.ZX_COLUMNA
FROM VUE_JHD_SZF_V A WHERE PICKDOCID = :task";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("task", task)]);
            return WQH.Convert.TableToList<VUE_JHD_SZF_V>(data)[0];
        }

        public static int first_jhd()
        {
            string sql = @"SELECT a.PICKDOCID
FROM VUE_JHD_SZF_V a
WHERE a.xdusestatus = 2 and a.zdusestatus = 1 and a.drawstatus = 0 AND NVL(a.pickmanid, 0) = 0 
AND a.pickdate IS NULL and NVL(a.printcount, 0) = 0 
AND NVL(a.finishmanid, 0) = 0 and rownum = 1";

            var data = Oracle.ExecuteDataTable(sql);
            if (data.Rows.Count <= 0) throw new Exception("无待拣货单！！");

            return Convert.ToInt32(data.Rows[0][0]);
        }
    }
}
