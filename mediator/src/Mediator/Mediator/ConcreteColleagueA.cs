using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleagueA Receive Message:{message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"ConcreteColleagueA Send Message:{message}");
            _mediator.SendMessage(message, this);
        }
    }
}
