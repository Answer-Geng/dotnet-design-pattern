namespace FactoryMethod
{
    public class PieChartFactory : ChartFactory
    {
        public override Chart CreateChart()
        {
            return new PieChart();
        }
    }
}
