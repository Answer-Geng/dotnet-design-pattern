using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Sample
{
    public abstract class Observer
    {
        protected Actress _actress;
        public abstract void LightCigarette();
    }
}
