using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FlowChart : Chart
    {
        public override void Draw()
        {
            string flowChart = "|                              \n";
            flowChart += "|                                    \n";
            flowChart += "|                -------             \n";
            flowChart += "|               | START |            \n";
            flowChart += "|                -------             \n";
            flowChart += "|                   |                \n";
            flowChart += "|                -------             \n";
            flowChart += "|               |  ...  |            \n";
            flowChart += "|                -------             \n";
            flowChart += "|                   |                \n";
            flowChart += "|                -------             \n";
            flowChart += "|               |  END  |            \n";
            flowChart += "|                -------             \n";
            flowChart += "|                                    \n";
            flowChart += "|______________________________________";
            Console.WriteLine(flowChart);
        }
    }
}
