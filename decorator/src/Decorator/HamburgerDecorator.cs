using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class HamburgerDecorator : IHamburger
    {
        protected IHamburger hamburgerToBeDecorated;
        public HamburgerDecorator(IHamburger hamburgerToBeDecorated)
        {
            this.hamburgerToBeDecorated = hamburgerToBeDecorated;
        }
        public virtual void Make()
        {
            hamburgerToBeDecorated.Make();
        }
    }
}
