using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TextReader
    {
        string text;
        public TextReader(string text)
        {
            this.text = text;
        }

        public void Parse(ReportBuilder reportBuilder)
        {
            reportBuilder.SetReportName();
            reportBuilder.SetReportType();
            reportBuilder.FillTitle();
            reportBuilder.FillContent();
        }

    }
}
