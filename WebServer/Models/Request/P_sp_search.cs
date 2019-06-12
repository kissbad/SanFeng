using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_sp_search
    {
        public string keyword { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}