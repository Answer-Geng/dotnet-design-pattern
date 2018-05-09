using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TextReport
    {
        public string ReportName { get; set; }
        public string ReportType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public void Show()
        {
            Console.WriteLine($"ReportName:{ReportName}");
            Console.WriteLine($"ReportType:{ReportType}");
            Console.WriteLine($"Title:[{Title}]");
            Console.WriteLine($"Content:{Content}");
        }
    }
}
