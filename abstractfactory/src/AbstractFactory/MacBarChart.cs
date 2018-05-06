using System;

namespace AbstractFactory
{
    class MacBarChart : BarChart
    {
        public override void Draw()
        {
            string macBarChart = "|                             \n";
            macBarChart += "|             __                    \n";
            macBarChart += "|            |$$|             __    \n";
            macBarChart += "|     __     |$$|            |$$|   \n";
            macBarChart += "|    |$$|    |$$|     __     |$$|   \n";
            macBarChart += "|    |$$|    |$$|    |$$|    |$$|   \n";
            macBarChart += "|    |$$|    |$$|    |$$|    |$$|   \n";
            macBarChart += "|____|$$|____|$$|____|$$|____|$$|_____";
            Console.WriteLine(macBarChart);
        }
    }
}
