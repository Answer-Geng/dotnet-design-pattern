using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp(new Closed());
            for (int i = 0; i < 10; i++)
            {
                lamp.Request();
            }
            Console.ReadLine();
        }
    }
}
