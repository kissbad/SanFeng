using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace YaoJian.Models
{
    interface UplondMod
    {
        string djbh { get; set; }
        XmlElement GetXML(XmlDocument xml);
    }
}
