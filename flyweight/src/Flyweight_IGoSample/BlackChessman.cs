using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_IGoSample
{
    class BlackChessman : Chessman
    {
        public override void Display(int x, int y)
        {
            Console.WriteLine($"Black Chessman , Position:X=>{x},Y=>{y}");
        }
    }
}
