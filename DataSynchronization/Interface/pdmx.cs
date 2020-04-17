using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.Interface
{
    interface pdmx
    {
        string djbh { get; set; }
        int dj_sn { get; set; }
        string spid { get; set; }
        string dj_sort { get; set; }
        string pdbz { get; set; }
        string plh { get; set; }
        string dw { get; set; }
        string pihao { get; set; }
        int jlgg { get; set; }
        int baozhshl { get; set; }
        decimal lingsshl { get; set; }
        decimal shpshl { get; set; }
        decimal shpje { get; set; }
        decimal zhmshl { get; set; }
        decimal zhmje { get; set; }
        decimal chbdj { get; set; }
        decimal psshl { get; set; }
        decimal psje { get; set; }
        decimal lshj { get; set; }
        string sxrq { get; set; }
        string is_shp { get; set; }
        string jwh { get; set; }
        string baozhiqi { get; set; }
        string beizhu { get; set; }
        string Hjid { get; set; }
        decimal jiansh { get; set; }
        string Tpid { get; set; }
        string biaoshi { get; set; }
        decimal fkcshl { get; set; }
        string isxzph { get; set; }
        decimal ychbdj { get; set; }
        string lastmodifytime { get; set; }
    }
}
