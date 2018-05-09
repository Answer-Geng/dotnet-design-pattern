using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TextReportBuilder : ReportBuilder
    {
        TextReport report = new TextReport();
        public override void FillContent()
        {
            report.Content = "TEXT REPORT CONTENT";
        }

        public override void FillTitle()
        {
            report.Title = "This is a TEXT REPORT";
        }

        public override void SetReportName()
        {
            report.ReportName = "TextReport";
        }

        public override void SetReportType()
        {
            report.ReportType = "txt";
        }

        public TextReport GetResult()
        {
            return report;
        }
    }
}
