using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Sample
{
    class UnderlineExpression : IExpression
    {
        public void Interpret(Context context)
        {
            if (context.Content.Contains("---"))
            {
                context.Content = context.Content.Replace("---", "__________________________");
            }
        }
    }
}
