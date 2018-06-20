using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_InternetSample
{
    class RealInternet : Internet
    {
        public override void Connect(string url)
        {
            Console.WriteLine($"Connecting to {url}");
        }
    }
}
