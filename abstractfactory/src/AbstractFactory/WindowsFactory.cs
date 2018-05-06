namespace AbstractFactory
{
    public class WindowsFactory : AbstractFactory
    {
        public override BarChart CreateBarChart()
        {
            return new WindowsBarChart();
        }

        public override PieChart CreatePieChart()
        {
            return new WindowsPieChart();
        }
    }
}
