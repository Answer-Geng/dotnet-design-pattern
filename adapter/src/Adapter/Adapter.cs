using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapter : IAdaptee, ITarget
    {
        private IAdaptee adaptee;
        private ITarget target;
        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public Adapter(ITarget target)
        {
            this.target = target;
        }
        public void Request()
        {
            adaptee.SpecificRequest();
        }

        public void SpecificRequest()
        {
            target.Request();
        }
    }
}
