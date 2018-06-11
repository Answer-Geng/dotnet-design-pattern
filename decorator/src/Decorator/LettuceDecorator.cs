using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class LettuceDecorator : HamburgerDecorator
    {
        public LettuceDecorator(IHamburger hamburgerToBeDecorated) : base(hamburgerToBeDecorated)
        {
        }

        public override void Make()
        {
            Console.WriteLine("~~~~~~~Lettuce~~~~~~");
            base.Make();
        }
    }
}
