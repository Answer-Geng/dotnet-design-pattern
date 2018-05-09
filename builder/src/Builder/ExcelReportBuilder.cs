using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ExcelReportBuilder : ReportBuilder
    {
        ExcelReport report = new ExcelReport();
        public override void FillContent()
        {
            report.Content = "EXCEL REPORT CONTENT";
        }

        public override void FillTitle()
        {
            report.Title = "This is a EXCEL REPORT";
        }

        public override void SetReportName()
        {
            report.ReportName = "TextReport";
        }

        public override void SetReportType()
        {
            report.ReportType = "txt";
        }

        public ExcelReport GetResult()
        {
            return report;
        }
    }
}
