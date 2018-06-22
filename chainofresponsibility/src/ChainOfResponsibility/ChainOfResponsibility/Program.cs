using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 h1 = new ConcreteHandler1();
            ConcreteHandler2 h2 = new ConcreteHandler2();
            h1.SetSuccessor(h2);
            int[] requests = { 1, 4, 5, 11, 24 };
            foreach (var request in requests)
            {
                h1.Handle(request);
            }
            Console.ReadLine();
        }
    }
}
