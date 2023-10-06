using System;
using System.Collections.Generic;
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
        public string Success { get; set; }
    }
}
