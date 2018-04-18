using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ChartFactory
    {
        public Chart CreateChart(string type)
        {
            Chart chart;

            switch (type)
            {
                case "L":
                    chart = new LineChart();
                    break;
                case "B":
                    chart = new BarChart();
                    break;
                case "P":
                    chart = new PieChart();
                    break;
                default:
                    throw new KeyNotFoundException();
            }

            return chart;

        }
    }
}
