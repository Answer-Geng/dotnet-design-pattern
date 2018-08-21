using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Sample
{
    class Dim : IState
    {
        public void Handle(Lamp context)
        {
            context.SetState(new Medium());
        }
    }
}
