using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;

            B B = new B();
            B.SetColor(new Black());
            B.Write();

            R R = new R();
            R.SetColor(new Black());
            R.Write();

            I I = new I();
            I.SetColor(new Black());
            I.Write();

            D D = new D();
            D.SetColor(new Red());
            D.Write();

            G G = new G();
            G.SetColor(new Black());
            G.Write();

            E E = new E();
            E.SetColor(new Blue());
            E.Write();
            Console.ReadLine();
        }
    }
}
