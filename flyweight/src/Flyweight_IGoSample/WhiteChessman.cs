using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_IGoSample
{
    class WhiteChessman : Chessman
    {
        public override void Display(int x, int y)
        {
            Console.WriteLine($"While Chessman , Position:X=>{x},Y=>{y}");
        }
    }
}
