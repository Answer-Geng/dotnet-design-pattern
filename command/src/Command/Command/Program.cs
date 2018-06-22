using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            ConcreteCommand concreteCommand = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(concreteCommand);
            invoker.Call();
            Console.ReadLine();
        }
    }
}
