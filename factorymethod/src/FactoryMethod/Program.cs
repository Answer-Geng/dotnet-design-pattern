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
            BarChartFactory factory = new BarChartFactory();
            Chart chart = factory.CreateChart();
            chart.Draw();
            Console.ReadLine();
        }
    }
}
