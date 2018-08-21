using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Colleague
    {
        protected IMediator _mediator;
        public Colleague(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
