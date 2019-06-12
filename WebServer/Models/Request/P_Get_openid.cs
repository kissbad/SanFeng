using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Request
{
    public class P_Get_openid
    {
        public string appid { get; set; }
        public string code { get; set; }
    }
}