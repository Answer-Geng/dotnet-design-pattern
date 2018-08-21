using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sample
{
    public interface ISalesPromotion
    {
        void Calculate(int orgPrice);
    }
}
