using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
            Flyweight fw = factory.GetFlyweight("A");

            int extrinsicState = 1;
            fw.Operation(extrinsicState);

            Flyweight fw2 = factory.GetFlyweight("B");
            fw2.Operation(extrinsicState);

            extrinsicState = 2;
            Flyweight fw3 = factory.GetFlyweight("A");
            fw3.Operation(extrinsicState);

            Console.ReadLine();

        }
    }
}
