using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class ConcreteFlyweightA : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyweightA->Operation[{extrinsicState}]");
        }
    }
}
