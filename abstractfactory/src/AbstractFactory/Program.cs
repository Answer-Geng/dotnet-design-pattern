using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new WindowsFactory();
            //AbstractFactory factory = new MacFactory();
            var pieChart = factory.CreatePieChart();
            var barChart = factory.CreateBarChart();
            pieChart.Draw();
            Console.WriteLine();
            barChart.Draw();
            Console.ReadLine();
        }
    }
}
