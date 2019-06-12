using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_Index_spList
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}