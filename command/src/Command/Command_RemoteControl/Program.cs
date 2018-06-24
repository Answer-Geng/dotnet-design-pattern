using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteController remoteController = new RemoteController();
            Light light = new Light();
            LightTurnOnCommand lightTurnOn = new LightTurnOnCommand(light);
            LightTurnOffCommand lightTurnOff = new LightTurnOffCommand(light);
            TV tv = new TV();
            TVTurnOnCommand tvTurnOn = new TVTurnOnCommand(tv);
            TVTurnOffCommand tvTurnOff = new TVTurnOffCommand(tv);
            remoteController.AddCommand(lightTurnOn);
            remoteController.AddCommand(lightTurnOff);
            remoteController.AddCommand(tvTurnOn);
            remoteController.AddCommand(tvTurnOff);

            int input = 0;
            do
            {
                Console.WriteLine("Please enter your command(enter 99 to exit):");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 99)
                {
                    Console.WriteLine("Exit!");
                    break;
                }
                remoteController.Call(input - 1);
            } while (input != 99);

            Console.ReadLine();
        }
    }
}
