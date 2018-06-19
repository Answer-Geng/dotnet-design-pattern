using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_IGoSample
{
    class ChessmanFactory
    {
        private Dictionary<Color, Chessman> _chessman = new Dictionary<Color, Chessman>();
        public Chessman GetChessman(Color color)
        {
            Chessman chessman;
            if (_chessman.ContainsKey(color))
            {
                Console.WriteLine("Already in the pool , use the exist one.");
                chessman = _chessman[color];
            }
            else
            {
                Console.WriteLine("new object");
                switch (color)
                {
                    case Color.White:
                        chessman = new WhiteChessman();
                        _chessman.Add(color,chessman);
                        break;
                    case Color.Black:
                        chessman = new BlackChessman();
                        _chessman.Add(color, chessman);
                        break;
                    default:
                        throw new Exception("Don't support this color");
                }
            }

            return chessman;
        }
    }
}
