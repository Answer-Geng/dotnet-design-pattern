using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ConcreteAdaptee : IAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest by ConcreteAdaptee");
        }
    }
}
