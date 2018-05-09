using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class ReportBuilder
    {
        public abstract void SetReportName();
        public abstract void SetReportType();
        public abstract void FillTitle();
        public abstract void FillContent();
    }
}
