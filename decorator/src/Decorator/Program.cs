using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken();
            LettuceDecorator withLettuce = new LettuceDecorator(chicken);
            SaladDecorator withSalad = new SaladDecorator(withLettuce);
            BreadDecorator withBread = new BreadDecorator(withSalad);
            withBread.Make();
            Console.ReadLine();
        }
    }
}
