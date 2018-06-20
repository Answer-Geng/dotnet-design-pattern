using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_InternetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetProxy proxy = new InternetProxy();
            proxy.Connect("aaa.com");
            proxy.Connect("abc.com");
            Console.ReadLine();
        }
    }
}
