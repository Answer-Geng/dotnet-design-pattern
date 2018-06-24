using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_RemoteControl
{
    class RemoteController
    {
        private List<ICommand> _commandList = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            _commandList.Add(command);
        }
        public void Call(int i)
        {
            _commandList[i].Execute();
        }
    }
}
