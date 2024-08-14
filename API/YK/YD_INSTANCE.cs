using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Oracle.ManagedDataAccess.Client;
using System.Xml.Linq;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace API.YK
{
    public class YD_INSTANCE
    {
        public int INSTTYPE { get; set; }
        public int INSTID { get; set; }
        public int INSTDTLID { get; set; }
        public string? PNAME { get; set; }
        public string? OPNAME { get; set; }
        public int DOCID { get; set; }
        public string? ENTRYDESC { get; set; }
        public DateTime CREDATE { get; set; }
        public string? EMPLOYEENAMES { get; set; }
        public string? ROLEEMPLOYEENAMES { get; set; }
        public int QFUSESTATUS { get; set; }

        public void insert()
        {
            string sql = @"insert into YD_INSTANCE(INSTTYPE,INSTID,INSTDTLID,PNAME,OPNAME,DOCID,ENTRYDESC,CREDATE,EMPLOYEENAMES,ROLEEMPLOYEENAMES,QFUSESTATUS) values(:INSTTYPE,:INSTID,:INSTDTLID,:PNAME,:OPNAME,:DOCID,:ENTRYDESC,:CREDATE,:EMPLOYEENAMES,:ROLEEMPLOYEENAMES,:QFUSESTATUS)";
            Oracle.ExecuteNonQuery(sql,
                [new OracleParameter("INSTTYPE", this.INSTTYPE),
                    new OracleParameter("INSTID", this.INSTID),
                    new OracleParameter("INSTDTLID", this.INSTDTLID),
                    new OracleParameter("PNAME", this.PNAME),
                    new OracleParameter("OPNAME", this.OPNAME),
                    new OracleParameter("DOCID", this.DOCID),
                    new OracleParameter("ENTRYDESC", this.ENTRYDESC),
                    new OracleParameter("CREDATE", this.CREDATE),
                    new OracleParameter("EMPLOYEENAMES", this.EMPLOYEENAMES),
                    new OracleParameter("ROLEEMPLOYEENAMES", this.ROLEEMPLOYEENAMES),
                    new OracleParameter("QFUSESTATUS", this.QFUSESTATUS)]);
        }

        public static void delete(int instdtlid) {
            string sql = @"delete YD_INSTANCE where instdtlid = :instdtlid";
            Oracle.ExecuteNonQuery(sql, [new OracleParameter("instdtlid", instdtlid)]);
        }

        public void update() {
            string sql = @"update YD_INSTANCE set INSTTYPE = :INSTTYPE,INSTID = :INSTID,PNAME = :PNAME,OPNAME = :OPNAME,DOCID = :DOCID,ENTRYDESC = :ENTRYDESC,
CREDATE = :CREDATE,EMPLOYEENAMES = :EMPLOYEENAMES,ROLEEMPLOYEENAMES = :ROLEEMPLOYEENAMES,QFUSESTATUS = :QFUSESTATUS
where instdtlid = :instdtlid";
            int i = Oracle.ExecuteNonQuery(sql,
                [new OracleParameter("INSTTYPE", this.INSTTYPE),
                    new OracleParameter("INSTID", this.INSTID),
                    new OracleParameter("PNAME", this.PNAME),
                    new OracleParameter("OPNAME", this.OPNAME),
                    new OracleParameter("DOCID", this.DOCID),
                    new OracleParameter("ENTRYDESC", this.ENTRYDESC),
                    new OracleParameter("CREDATE", this.CREDATE),
                    new OracleParameter("EMPLOYEENAMES", this.EMPLOYEENAMES),
                    new OracleParameter("ROLEEMPLOYEENAMES", this.ROLEEMPLOYEENAMES),
                    new OracleParameter("QFUSESTATUS", this.QFUSESTATUS),
                    new OracleParameter("INSTDTLID", this.INSTDTLID)
                ]);
            if (i == 0) throw new Exception(string.Format("修改数据不存在,instdtlid:{0}", this.INSTDTLID));
        }
    }
}
