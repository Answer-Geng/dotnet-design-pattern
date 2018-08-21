using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Actress actress = new Actress();
            ActorA a = new ActorA(actress);
            ActorB b = new ActorB(actress);
            ActorC c = new ActorC(actress);

            actress.SetState(1);
            Console.ReadLine();
        }
    }
}
