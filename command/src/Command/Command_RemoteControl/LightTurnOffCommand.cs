using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_RemoteControl
{
    class LightTurnOffCommand : ICommand
    {
        private Light _light;
        public LightTurnOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
