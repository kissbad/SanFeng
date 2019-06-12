using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Models.KSOA
{
    public interface IToken
    {
        string dzyid { get; set; }
        string kl { get; set; }
    }
}
