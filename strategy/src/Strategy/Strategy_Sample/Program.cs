using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int price1 = 120;
            Product p1 = new Product();
            p1.SetPromotion(new Reduction());
            p1.PrintPrice(price1);

            int price2 = 500;
            Product p2 = new Product();
            p2.SetPromotion(new Discount());
            p2.PrintPrice(price2);

            Console.ReadLine();
        }
    }
}
