using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.Interface
{
    interface fapiaogl
    {
        string fapiaoh { get; set; }
        string djbh { get; set; }
        string rq { get; set; }
        decimal yuankpze { get; set; }
        decimal kaipze { get; set; }
        decimal je { get; set; }
        decimal she { get; set; }
        string fx { get; set; }
        string beizhu { get; set; }
        string is_dc { get; set; }
        string guihao { get; set; }
        string username { get; set; }
        string kaiprq { get; set; }
        string dwbh { get; set; }
        string jieqing { get; set; }
        string bendian { get; set; }
        string ontime { get; set; }
        string gysrq { get; set; }
        string lastmodifytime { get; set; }
    }
}
