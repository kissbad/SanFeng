using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_sp_search_order
    {
        public string deywy { get; set; }
        public string deywybm { get; set; }
        public string is_fp { get; set; }
        public string keyword { get; set; }
        public string pageIndex { get; set; }
        public string pageSize { get; set; }
    }
}