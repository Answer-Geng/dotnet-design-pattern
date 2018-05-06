namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract PieChart CreatePieChart();
        public abstract BarChart CreateBarChart();
    }
}
