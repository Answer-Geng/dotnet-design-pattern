using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SaladDecorator : HamburgerDecorator
    {
        public SaladDecorator(IHamburger hamburgerToBeDecorated) : base(hamburgerToBeDecorated)
        {
        }

        public override void Make()
        {
            Console.WriteLine("=======salad========");
            base.Make();
        }
    }
}
