using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();

            AbstractClass b = new ConcreteClassB();
            b.TemplateMethod();
            Console.ReadLine();
        }
    }
}
