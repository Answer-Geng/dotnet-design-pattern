using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_InternetSample
{
    class InternetProxy : Internet
    {
        private Internet _realInternet = new RealInternet();
        private readonly List<string> _bannedSites;
        public InternetProxy()
        {
            _bannedSites = new List<string>
            {
                "abc.com",
                "111.com"
            };
        }

        public override void Connect(string url)
        {
            if (_bannedSites.Contains(url))
            {
                Console.WriteLine("Access Denied");
            }
            else
            {
                _realInternet.Connect(url);
            }
        }
    }
}
