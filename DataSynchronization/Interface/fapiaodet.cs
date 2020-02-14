using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.Interface
{
    interface fapiaodet
    {
        string fapiaoh { get; set; }
        string djbh { get; set; }
        int dj_sn { get; set; }
        string spid { get; set; }
        decimal shl { get; set; }
        decimal dj { get; set; }
        decimal je { get; set; }
        decimal shlv { get; set; }
        decimal she { get; set; }
        string dwbh { get; set; }
        decimal yisfje { get; set; }
        decimal hsje { get; set; }
        decimal hshj { get; set; }
        string jieqing { get; set; }
        string pihao { get; set; }
        string sxrq { get; set; }
        string guihao { get; set; }
        string lastmodifytime { get; set; }
    }
}
