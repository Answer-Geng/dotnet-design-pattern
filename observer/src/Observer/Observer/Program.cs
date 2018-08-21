using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ConcreteObserverA a = new ConcreteObserverA(subject);
            ConcreteObserverB b = new ConcreteObserverB(subject);
            ConcreteObserverC c = new ConcreteObserverC(subject);

            subject.SetState(200);
            Console.ReadLine();
        }
    }
}
