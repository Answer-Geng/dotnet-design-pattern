using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Refrigerator
    {
        public void OpenTheDoor()
        {
            Console.WriteLine("Open the refrigerator door");
        }

        public void CloseTheDoor()
        {
            Console.WriteLine("close the refrigerator door");
        }
    }
}
