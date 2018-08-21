using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sample
{
    public class Discount : ISalesPromotion
    {
        public void Calculate(int orgPrice)
        {
            var price = orgPrice * 2 * 0.8;
            Console.WriteLine($"Original Price : [{orgPrice}] , Price : [{price}]");
        }
    }
}
