using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.Interface
{
    interface pf_ckmx
    {
        string djbh { get; set; }
        int dj_sn { get; set; }
        int dj_sort { get; set; }
        string spid { get; set; }
        string hw { get; set; }
        decimal shl { get; set; }
        decimal dj { get; set; }
        decimal hshj { get; set; }
        decimal je { get; set; }
        decimal hsje { get; set; }
        decimal shlv { get; set; }
        decimal she { get; set; }
        string zengp { get; set; }
        string pihao { get; set; }
        string sxrq { get; set; }
        string baozhiqi { get; set; }
        string is_chonghong { get; set; }
        decimal ch_shl { get; set; }
        int chdj_sn { get; set; }
        decimal yshl { get; set; }
        decimal yhshj { get; set; }
        string is_zx { get; set; }
        string is_sjjh { get; set; }
        string lastmodifytime { get; set; }
        decimal ydj { get; set; }
        decimal ndj { get; set; }
        decimal nhshj { get; set; }
        string is_fp { get; set; }
    }
}
