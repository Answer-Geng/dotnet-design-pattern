using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Sample
{
    public class Airliner : AbstractPlane
    {
        public Airliner(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} Receive Message:{message} from {from}");
        }

        public override void Send(string to, string message)
        {
            ControlTower.SendMessage(this.Name, to, message);
        }
    }
}
