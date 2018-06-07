using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Email : AbstractEmail
    {
        public Email(string name,string address)
        {
            this.Name = name;
            this.EmailAddress = address;
        }
        public override void Print()
        {
            Console.WriteLine($"Name:{Name} , EmailAddress:{EmailAddress}");
        }
    }
}
