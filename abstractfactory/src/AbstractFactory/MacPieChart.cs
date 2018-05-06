using System;

namespace AbstractFactory
{
    class MacPieChart : PieChart
    {
        public override void Draw()
        {
            string macPieChart = "|                         \n";
            macPieChart += "|                               \n";
            macPieChart += "|                 /             \n";
            macPieChart += "|                /              \n";
            macPieChart += "|        |****      @@@@|       \n";
            macPieChart += "|       |*******  @@@@@@@|      \n";
            macPieChart += "|      |*********@@@@@@@@@|     \n";
            macPieChart += "|       |********$$$$$$$$|      \n";
            macPieChart += "|        |******$$$$$$$$|       \n";
            macPieChart += "|         |****$ $$$$$$|        \n";
            macPieChart += "|          |***   $$$$|         \n";
            macPieChart += "|______________________________";
            Console.WriteLine(macPieChart);
        }
    }
}
