using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BreadDecorator : HamburgerDecorator
    {
        public BreadDecorator(IHamburger hamburgerToBeDecorated) : base(hamburgerToBeDecorated)
        {
        }

        public override void Make()
        {
            Console.WriteLine(" .................. ");
            Console.WriteLine("....................");
            base.Make();
            Console.WriteLine("....................");
            Console.WriteLine(" .................. ");
        }
    }
}
