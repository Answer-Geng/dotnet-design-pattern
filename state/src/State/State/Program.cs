using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            for (int i = 0; i < 5; i++)
            {
                context.Request();
            }
            Console.ReadLine();
        }
    }
}
