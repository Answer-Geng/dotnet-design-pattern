using System;

namespace FactoryMethod
{
    public class FlowChartFactory : ChartFactory
    {
        public override Chart CreateChart()
        {
            return new FlowChart();
        }
    }
}
