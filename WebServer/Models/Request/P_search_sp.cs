using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_search_sp
    {
        public string token { get; set; }
        public string keyword { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}