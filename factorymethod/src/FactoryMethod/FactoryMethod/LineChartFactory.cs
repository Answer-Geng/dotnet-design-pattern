namespace FactoryMethod
{
    public class LineChartFactory : ChartFactory
    {
        public override Chart CreateChart()
        {
            return new LineChart();
        }
    }
}
