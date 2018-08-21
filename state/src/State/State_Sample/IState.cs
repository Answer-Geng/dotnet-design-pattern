using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Sample
{
    interface IState
    {
        void Handle(Lamp context);
    }
}
