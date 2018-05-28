using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ConcreteTarget : ITarget
    {
        public void Request()
        {
            Console.WriteLine("Request by ConcreteTarget");
        }
    }
}
