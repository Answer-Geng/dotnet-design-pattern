using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_InternetSample
{
    abstract class Internet
    {
        public abstract void Connect(string url);
    }
}
