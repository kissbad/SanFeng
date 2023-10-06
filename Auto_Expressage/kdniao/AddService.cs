using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Auto_Expressage.kdniao
{
    public class AddService
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public AddService(string n,string v) {
            this.Name = n;
            this.Value = v;
        }
    }
}
