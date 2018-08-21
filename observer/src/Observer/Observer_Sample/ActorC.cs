using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Sample
{
    public class ActorC : Observer
    {
        public ActorC(Actress actress)
        {
            _actress = actress;
            actress.Attach(this);
        }
        public override void LightCigarette()
        {
            Console.WriteLine($"ActorC light the cigarette");
        }
    }
}
