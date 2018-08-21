using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetStrategy(new ConcreteStrategyA());
            context.ContextInterface();
            context.SetStrategy(new ConcreteStrategyB());
            context.ContextInterface();
            Console.ReadLine();
        }
    }
}
