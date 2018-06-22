using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void Handle(int request)
        {
            if (request > 10)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
            }
            else if (_successor != null)
            {
                _successor.Handle(request);
            }
        }
    }
}
