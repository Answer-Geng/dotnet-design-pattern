using System;

namespace AbstractFactory
{
    class WindowsBarChart : BarChart
    {
        public override void Draw()
        {
            string windowsBarChart = "|                             \n";
            windowsBarChart += "|             __                    \n";
            windowsBarChart += "|            |--|             __    \n";
            windowsBarChart += "|     __     |--|            |--|   \n";
            windowsBarChart += "|    |--|    |--|     __     |--|   \n";
            windowsBarChart += "|    |--|    |--|    |--|    |--|   \n";
            windowsBarChart += "|    |--|    |--|    |--|    |--|   \n";
            windowsBarChart += "|____|--|____|--|____|--|____|--|_____";
            Console.WriteLine(windowsBarChart);
        }
    }
}
