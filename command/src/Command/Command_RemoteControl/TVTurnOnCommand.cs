using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_RemoteControl
{
    class TVTurnOnCommand : ICommand
    {
        private TV _tv;
        public TVTurnOnCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}
