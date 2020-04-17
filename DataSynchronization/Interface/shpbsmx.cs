using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.Interface
{
    interface shpbsmx
    {
        string djbh { get; set; }
        int dj_sn { get; set; }
        string spid { get; set; }
        int recnum { get; set; }
        string xgdjbh { get; set; }
        int dj_sort { get; set; }
        string dw { get; set; }
        string pihao { get; set; }
        decimal baosshl { get; set; }
        decimal baoyshl { get; set; }
        decimal syje { get; set; }
        string Hjid { get; set; }
        string sxrq { get; set; }
        string Tpid { get; set; }
        string bsyyj { get; set; }
        string beizhu { get; set; }
        string is_con { get; set; }
        string baozhiqi { get; set; }
        string lastmodifytime { get; set; }
    }
}
