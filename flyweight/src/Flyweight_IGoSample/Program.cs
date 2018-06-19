using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_IGoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessmanFactory factory = new ChessmanFactory();
            var chessmanA = factory.GetChessman(Color.White);
            chessmanA.Display(1,1);

            var chessmanB = factory.GetChessman(Color.Black);
            chessmanB.Display(4, 3);

            var chessmanC = factory.GetChessman(Color.White);
            chessmanC.Display(5, 10);

            Console.ReadLine();
        }
    }
}
