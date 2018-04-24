using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowChartFactory factory = new FlowChartFactory();
            var flowChart = factory.CreateChart();
            flowChart.Draw();
            Console.ReadLine();
        }
    }
}
