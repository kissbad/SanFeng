using System.ComponentModel.Design;
using System.Security.AccessControl;

namespace Web_zhilian.YK
{
    public class Dictionary
    {
        private readonly static IDictionary<string, string> DefaultDocumentation = new Dictionary<string, string> {
            { "CREDATE", "业务日期" },
            { "SUDOCID", "进货总单ID" },
            { "SALESID", "销售总单ID" },        
            { "CUSTOMID","客户ID" },
            { "CUSTOMNAME","客户" },   
            { "SUPPLYID", "供应商ID" },
            { "SUPPLYNAME", "供应商" },
            { "GOODSID", "货品ID" },
            { "GOODSNAME", "通用名" },
            { "HOLDERSNAME", "上市许可持有人" },
            { "FACTORYNAME", "生产企业" },
            { "APPROVEDOCNO", "批准文号" },
            { "GOODSTYPE", "规格" },
            { "GOODSUNIT", "单位" },
            { "LOTNO", "批号" },
            { "PRODDATE", "生产日期" },
            { "INVALIDDATE", "有效期" },
            { "GOODSQTY", "数量" },
            { "UNITPRICE", "单价" },
            { "TOTAL_LINE", "金额" },
            { "COMEFROM", "单据类型" }
        };

        public static string To(string str)
        {
            return DefaultDocumentation.ContainsKey(str) ? DefaultDocumentation[str] : str;
        }
    }
}
