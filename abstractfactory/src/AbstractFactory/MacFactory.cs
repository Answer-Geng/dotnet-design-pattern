namespace AbstractFactory
{
    public class MacFactory : AbstractFactory
    {
        public override BarChart CreateBarChart()
        {
            return new MacBarChart();
        }

        public override PieChart CreatePieChart()
        {
            return new MacPieChart();
        }
    }
}
