using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChartFactory factory = new ChartFactory();
            var chart = factory.CreateChart("B");
            chart.Draw();
            Console.ReadLine();
        }
    }
}
