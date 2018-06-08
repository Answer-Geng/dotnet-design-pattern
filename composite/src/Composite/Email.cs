using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Email : IEmail
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public Email(string name,string address)
        {
            this.Name = name;
            this.EmailAddress = address;
        }
        public void Print()
        {
            Console.WriteLine($"Name:{Name} , EmailAddress:{EmailAddress}");
        }
    }
}
