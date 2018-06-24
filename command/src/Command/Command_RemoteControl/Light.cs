using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_RemoteControl
{
    class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is turning on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is turning off");
        }
    }
}
