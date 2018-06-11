using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Chicken : IHamburger
    {
        public void Make()
        {
            Console.WriteLine("``````Chicken```````");
        }
    }
}
