using System;
namespace SimpleFactory
{
    public class PieChart : Chart
    {
        public override void Draw()
        {
            string lineChart = "|                         \n";
            lineChart += "|          ------------         \n";
            lineChart += "|         |***@@@@@@@@@|        \n";
            lineChart += "|        |*****@@@@@@@@@|       \n";
            lineChart += "|       |*******@@@@@@@@@|      \n";
            lineChart += "|      |*********@@@@@@@@@|     \n";
            lineChart += "|       |********$$$$$$$$|      \n";
            lineChart += "|        |******$$$$$$$$|       \n";
            lineChart += "|         |****$$$$$$$$|        \n";
            lineChart += "|          ------------         \n";
            lineChart += "|______________________________";
            Console.WriteLine(lineChart);
        }
    }
}
