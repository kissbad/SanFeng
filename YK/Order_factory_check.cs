using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK
{
    public class Order_factory_check
    {
        public int goodsid { get; set; }
        public string goodsname { get; set; }
        public string goodstype { get; set; }
        public string factoryname { get; set; }
        public string holdersname { get; set; }
        public string approvedocno { get; set; }
        public string lotno { get; set; }
        public int fcheckid { get; set; }
        public string filename { get; set; }
        public string path { get; set; }

        public static List<Order_factory_check> get_Order_factory_check_list(string sasettleid)
        {
            string sql = @"select distinct c.goodsid,sp.goodsname, sp.goodstype, sp.factoryname, sp.holdersname, sp.approvedocno,
e.lotno,d.fcheckid,f.fileid,f.filename,'Z:\' || f.pkid || '\质检单管理\' || f.filename as path 
from bms_sa_settle_dtl a
join bms_sa_doctoset b on a.SASETTLEDTLID = b.SASETTLEDTLID
join bms_sa_dtl c on b.SALESDTLID = c.SALESDTLID
join bms_lot_def e on c.goodsid = e.goodsid and c.lotid = e.lotid
left join gsp_goods_factory_check d on c.goodsid = d.goodsid and c.lotid = d.lotid
left join np_efiles_op_file f on f.opid = 5066 and d.fcheckid = f.pkid
join wqh_sp sp on c.goodsid = sp.goodsid
where a.sasettleid = :sasettleid";
            var fp = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("sasettleid", sasettleid) });
            return WQH.Convert.TableToList<Order_factory_check>(fp);
        }
    }
}
