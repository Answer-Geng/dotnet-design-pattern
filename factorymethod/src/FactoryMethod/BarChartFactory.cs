namespace FactoryMethod
{
    public class BarChartFactory : ChartFactory
    {
        public override Chart CreateChart()
        {
            return new BarChart();
        }
    }
}
