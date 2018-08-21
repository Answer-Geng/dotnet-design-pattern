using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sample
{
    public class Product
    {
        private ISalesPromotion _promotion;
        public void SetPromotion(ISalesPromotion promotion)
        {
            _promotion = promotion;
        }
        public void PrintPrice(int price)
        {
            _promotion.Calculate(price);
        }
    }
}
