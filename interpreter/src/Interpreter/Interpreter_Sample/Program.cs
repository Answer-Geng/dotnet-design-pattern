using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Content = "- apple\r\n";
            context.Content += "- orange\r\n";
            context.Content += "- banana\r\n";
            context.Content += "---";

            List<IExpression> tree = new List<IExpression>();
            tree.Add(new UnOrderedListExpression());
            tree.Add(new UnderlineExpression());

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(context.Content);
            Console.ReadLine();
        }
    }
}
