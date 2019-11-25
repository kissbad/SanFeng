using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_WX_order:KSOA.wqh_WX_order_hz
    {
        public List<KSOA.wqh_WX_order_mx> mx { get; set; }
    }
}