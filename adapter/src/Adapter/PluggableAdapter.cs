using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PluggableAdapter
    {
        public Action MakeSound { get; private set; }
        public PluggableAdapter(Action makeSound)
        {
            this.MakeSound = makeSound;
        }
    }
}
