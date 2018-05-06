using System;

namespace AbstractFactory
{
    class WindowsPieChart : PieChart
    {
        public override void Draw()
        {
            string windowsPieChart = "|                            \n";
            windowsPieChart += "|        -------   ---------       \n";
            windowsPieChart += "|       |*******| |@@@@@@@@@|      \n";
            windowsPieChart += "|       |*******| |@@@@@@@@@|      \n";
            windowsPieChart += "|       |*******| |@@@@@@@@@|      \n";
            windowsPieChart += "|        -------   ---------       \n";
            windowsPieChart += "|        -------   ---------       \n";
            windowsPieChart += "|       |*******| |$$$$$$$$$|      \n";
            windowsPieChart += "|       |*******| |$$$$$$$$$|      \n";
            windowsPieChart += "|       |*******| |$$$$$$$$$|      \n";
            windowsPieChart += "|        -------   ---------       \n";
            windowsPieChart += "|____________________________________";
            Console.WriteLine(windowsPieChart);
        }
    }
}
