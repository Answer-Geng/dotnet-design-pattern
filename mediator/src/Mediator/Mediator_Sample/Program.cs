using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower tower = new ControlTower();
            Airliner airLinerA = new Airliner("A");
            Airliner airLinerB = new Airliner("B");
            Airliner airLinerC = new Airliner("C");
            Airliner airLinerD = new Airliner("D");
            Airliner airLinerE = new Airliner("E");

            tower.Register(airLinerA);
            tower.Register(airLinerB);
            tower.Register(airLinerC);
            tower.Register(airLinerD);
            tower.Register(airLinerE);

            airLinerA.Send("B","When will you arrive?");
            airLinerB.Send("A", "Already landed.");
            Console.ReadLine();
        }
    }
}
