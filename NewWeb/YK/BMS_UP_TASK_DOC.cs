using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class BMS_UP_TASK_DOC
    {
        public int TASKID { get; set; }
        public int STHOUSEID { get; set; }
        public int RGID { get; set; }
        public int COMPANYID { get; set; }
        public int PRINTCOUNT { get; set; }
        public DateTime PRINTDATE { get; set; }
        public int PRINTMANID { get; set; }
        public int USESTATUS { get; set; }
        public int INPUTMANID { get; set; }
        public DateTime CREDATE { get; set; }
        public static void print(int taskid, int employeeid)
        {
            string sql = @"update BMS_UP_TASK_DOC set PRINTMANID = :employeeid ,PRINTDATE = SYSDATE,PRINTCOUNT = nvl(PRINTCOUNT,0)+1 where taskid = :taskid";
            if (Oracle.ExecuteNonQuery(sql, [new OracleParameter("employeeid", employeeid), new OracleParameter("taskid", taskid)]) <= 0)
            {
                throw new Exception("记录打印数据失败！！");
            }
        }
    }
}
