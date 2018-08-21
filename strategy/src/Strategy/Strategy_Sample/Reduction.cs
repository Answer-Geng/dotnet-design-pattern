using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sample
{
    public class Reduction : ISalesPromotion
    {
        public void Calculate(int orgPrice)
        {
            var price = orgPrice + 50 - 20;
            Console.WriteLine($"Original Price : [{orgPrice}] , Price : [{price}]");
        }
    }
}
