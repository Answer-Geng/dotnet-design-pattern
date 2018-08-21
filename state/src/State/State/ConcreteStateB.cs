using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            context.SetState(new ConcreteStateA());
        }
    }
}
