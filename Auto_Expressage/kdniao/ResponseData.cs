using Microsoft.SqlServer.Server;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Expressage.kdniao
{
    public class ResponseData
    {
        public Order Order { get; set; }
        public string PrintTemplate { get; set; }
        public string EBusinessID { get; set; }
        public string UniquerRequestNumber { get; set; }
        public string ResultCode { get; set; }
        public string Reason { get; set; }
        public bool Success { get; set; }
        public string[] SubOrders { get; set; }
        public string[] SubPrintTemplates { get; set; }
        public int SubCount { get; set; }

        public void UpdateOrder(string salesid) {
            string zx_wlnumber = Order.LogisticCode;
            string templateurl = "";
            for (int i = 0; i < SubOrders?.Count(); i++)
            {
                zx_wlnumber += "," + SubOrders?[i];
            }
            if (Order.ShipperCode == "SF") {
                templateurl = "http://resources.kdniao.com/electron/' || to_char(sysdate, 'yyyy/mm/dd') || '/SF/' || '"+ Order.LogisticCode + "' || '.pdf";
                for (int i = 0; i < SubOrders?.Count(); i++)
                {
                    templateurl += "," + "http://resources.kdniao.com/electron/' || to_char(sysdate, 'yyyy/mm/dd') || '/SF/' || '" + SubOrders?[i] + "' || '.pdf";
                }
            }
            string sql = @"update bms_sa_doc set zx_kdbirdflag = '1',zx_wlnumber = '" + zx_wlnumber + "',templateurl = '"+ templateurl + "' where salesid = " + salesid;
            //WQH.system.IO.File.WriteLog(sql, 1);
            WQH.system.IO.File.WriteLog(salesid + "：回写状态、单号", 1);
            npserver.Oracle.ExecuteNonQuery(sql);
        }

        public void SaveOrder(string salesid)
        {
            PrintTemplate = PrintTemplate.Replace("'", "''").Replace("&", "'||chr(38)||'");
            Order.ShipperInfo = Order.ShipperInfo?.Replace("'", "''").Replace("&", "'||chr(38)||'");

            //WQH.system.IO.File.WriteLog(PrintTemplate, 1);

            string sql = @"declare str varchar(32767);
begin
 dbms_output.enable(buffer_size => null);
 str := '" + PrintTemplate + @"';
 dbms_output.put_line(str);
insert into bms_sa_doc_printtemplate (salesid, printtemplate, markdestination, origincode, originname, destinatiocode, destinationame, packagecode, packagename,shipperinfo)values('" + salesid + "', str, '" + Order.MarkDestination + "','"+ Order.OriginCode + "', '"+ Order.OriginName + "', '"+ Order.DestinatioCode + "','"+ Order.DestinatioName + "','"+ Order.PackageCode + "','"+ Order.PackageName + "','"+ Order.ShipperInfo + "');end;";
           
            //WQH.system.IO.File.WriteLog(sql, 1);
            npserver.Oracle.ExecuteNonQuery(sql);
        }

        public void SaveOrder_2(string salesid) {
            if (SubOrders is null){
                exesql(salesid, Order.LogisticCode, "", PrintTemplate);
                return; }
            if (SubOrders?.Count() > 0 & SubPrintTemplates?.Count() < SubOrders?.Count())
            {
                for (int i = 0; i < SubOrders.Count(); i++)
                {
                    if (i == 0) { exesql(salesid, Order.LogisticCode, SubOrders?[i], PrintTemplate); }
                    else
                    {
                        SubPrintTemplates[i - 1] = SubPrintTemplates[i - 1].Replace("'", "''").Replace("&", "'||chr(38)||'");
                        exesql(salesid, Order.LogisticCode, SubOrders?[i], SubPrintTemplates[i - 1]);
                    }
                }
            }
            else if (SubOrders?.Count() > 0 & SubPrintTemplates?.Count() == SubOrders?.Count()) {
                exesql(salesid, Order.LogisticCode, Order.LogisticCode, PrintTemplate);
                for (int i = 0; i < SubOrders.Count(); i++)
                {
                        SubPrintTemplates[i] = SubPrintTemplates[i].Replace("'", "''").Replace("&", "'||chr(38)||'");
                        exesql(salesid, Order.LogisticCode, SubOrders?[i], SubPrintTemplates[i]);
                }
            }
        }

        public void exesql(string salesid,string logisticcode, string suborders, string printtemplate) {
            string sql = @"declare str varchar(32767);
begin
 dbms_output.enable(buffer_size => null);
 str := '"+ printtemplate + @"';
 dbms_output.put_line(str);
 insert into wqh_kd (salesid, logisticcode, suborders, printtemplate)values('"+ salesid + "','"+ logisticcode + "','"+ suborders + @"',str);
end;";
            npserver.Oracle.ExecuteNonQuery(sql);
        }

        public void error(string salesid) {
            string sql = @"insert into wqh_kd_error(salesid,resultcode,reason)values("+ salesid + ",'"+ ResultCode + "','"+ Reason + "')";
            npserver.Oracle.ExecuteNonQuery(sql);
        }
    }
}
