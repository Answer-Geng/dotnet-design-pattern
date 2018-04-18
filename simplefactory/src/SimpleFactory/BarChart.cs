using System;

namespace SimpleFactory
{
    public class BarChart : Chart
    {
        public override void Draw()
        {
            string barChart = "|                             \n";
            barChart += "|             __                    \n";
            barChart += "|            |  |             __    \n";
            barChart += "|     __     |  |            |  |   \n";
            barChart += "|    |  |    |  |     __     |  |   \n";
            barChart += "|    |  |    |  |    |  |    |  |   \n";
            barChart += "|    |  |    |  |    |  |    |  |   \n";
            barChart += "|____|__|____|__|____|__|____|__|_____";
            Console.WriteLine(barChart);
        }
    }
}
