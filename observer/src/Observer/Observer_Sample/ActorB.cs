using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Sample
{
    public class ActorB : Observer
    {
        public ActorB(Actress actress)
        {
            _actress = actress;
            actress.Attach(this);
        }
        public override void LightCigarette()
        {
            Console.WriteLine($"ActorB light the cigarette");
        }
    }
}
