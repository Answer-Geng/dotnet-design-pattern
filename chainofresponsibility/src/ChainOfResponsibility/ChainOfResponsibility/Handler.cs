using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _successor;
        public void SetSuccessor(Handler successor)
        {
            this._successor = successor;
        }
        public abstract void Handle(int request);
    }
}
