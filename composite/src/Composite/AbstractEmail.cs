using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class AbstractEmail
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public abstract void Print();
    }
}
