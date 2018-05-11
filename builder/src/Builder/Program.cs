using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new TextReader("Text Content");
            ExcelReportBuilder builder = new ExcelReportBuilder();
            reader.Construct(builder);
            builder.GetResult().Show();
            Console.ReadLine();
        }
    }
}
