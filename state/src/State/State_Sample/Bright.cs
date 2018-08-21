using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Sample
{
    class Bright : IState
    {
        public void Handle(Lamp context)
        {
            context.SetState(new Closed());
        }
    }
}
