﻿using System;

namespace FactoryMethod
{
    public class LineChart : Chart
    {
        public override void Draw()
        {
            string lineChart = "|                        \n";
            lineChart += "|                       -     \n";
            lineChart += "|                       -     \n";
            lineChart += "|                    --       \n";
            lineChart += "|                --           \n";
            lineChart += "|            ---              \n";
            lineChart += "|      ---                    \n";
            lineChart += "|   -                         \n";
            lineChart += "|______________________________";
            Console.WriteLine(lineChart);
        }
    }
}
