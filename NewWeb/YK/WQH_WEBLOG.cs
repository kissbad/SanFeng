using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class WQH_WEBLOG
    {
        public int ID { get; set; }
        public DateTime CREATEDATE { get; set; }
        public string? IP { get; set; }
        public int PORT { get; set; }
        public string? PATH { get; set; }
        public string? ADDRESS { get; set; }
        public void Save()
        {
            string sql = @"insert into wqh_weblog(ID,CREATEDATE,IP,PORT,PATH,ADDRESS)values(WQH_WEBLOG_SEQ.NEXTVAL,:CREATEDATE,:IP,:PORT,:PATH,:ADDRESS)";

            Oracle.ExecuteNonQuery(sql,
                [new OracleParameter("CREATEDATE", this.CREATEDATE),
                    new OracleParameter("IP", this.IP),
                    new OracleParameter("PORT", this.PORT),
                    new OracleParameter("PATH", this.PATH),
                    new OracleParameter("ADDRESS", this.ADDRESS)]);
        }
    }
}
