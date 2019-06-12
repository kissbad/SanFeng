using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class sp_init
    {
        public List<hzfamx> next{get;set;}
        public sp_init() {
            var hz = hzfa.Get("sp_init");
            List<hzfamx> mx = hzfamx.Get_list("sp_init");
            string[] fjrule = hz.fjrule.Split(',');


            foreach (string i in fjrule) {
                var x = (from a in mx where a.hzflbh.Length == int.Parse(i) select a).ToList();
            }
        }
    }
}