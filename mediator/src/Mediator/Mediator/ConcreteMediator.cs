using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleagueA ConcreteColleagueA { get; set; }
        public ConcreteColleagueB ConcreteColleagueB { get; set; }
        public void SendMessage(string message, Colleague colleague)
        {
            if (colleague == ConcreteColleagueA)
            {
                ConcreteColleagueB.Receive(message);
            }
            else
            {
                ConcreteColleagueA.Receive(message);
            }
        }
    }
}
