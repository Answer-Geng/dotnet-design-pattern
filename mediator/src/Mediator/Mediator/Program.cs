using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleagueA colleagueA = new ConcreteColleagueA(mediator);
            ConcreteColleagueB colleagueB = new ConcreteColleagueB(mediator);

            mediator.ConcreteColleagueA = colleagueA;
            mediator.ConcreteColleagueB = colleagueB;

            colleagueA.Send("Hello,how are you?");
            colleagueB.Send("Fine,thank you.And you?");
            Console.ReadLine();
        }
    }
}
