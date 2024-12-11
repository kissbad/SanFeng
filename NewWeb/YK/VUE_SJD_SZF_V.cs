using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class VUE_SJD_SZF_V
    {
        public string? COMEFROM { get; set; }
        public int COMPANYID { get; set; }
        public string? CREDATE { get; set; }
        public string? COMPANYNAME { get; set; }
        public int TASKID { get; set; }
        public string? CHECKMANNAME { get; set; }
        public int ZDUSESTATUS { get; set; }
        public int PRINTMANID { get; set; }
        public DateTime PRINTDATE { get; set; }
        public int PRINTCOUNT { get; set; }
        public int DTLKEEPMANID { get; set; }
        public int XDUSESTATUS { get; set; }
        public string? ECODEFLAG { get; set; }
        public string? ZX_COLUMNA { get; set; }

        public static VUE_SJD_SZF_V get_data(int task)
        {
            string sql = @"SELECT * from VUE_SJD_SZF_V where TASKID = :task";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("task", task)]);
            return WQH.Convert.TableToList<VUE_SJD_SZF_V>(data)[0];
        }

        public static int first_sjd()
        {
            string sql = @"SELECT TASKID FROM VUE_SJD_SZF_V WHERE ZDUSESTATUS = 1 AND NVL(PRINTMANID, 0) = 0 AND PRINTDATE IS NULL
AND NVL(PRINTCOUNT, 0) = 0 AND NVL(DTLKEEPMANID, 0) = 0 AND XDUSESTATUS = 1 and rownum = 1";

            var data = Oracle.ExecuteDataTable(sql);
            if (data.Rows.Count <= 0) throw new Exception("无待上架单！！");

            return Convert.ToInt32(data.Rows[0][0]);
        }
    }
}
