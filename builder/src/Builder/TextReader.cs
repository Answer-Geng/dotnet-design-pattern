namespace Builder
{
    class TextReader
    {
        private string text;
        public TextReader(string text)
        {
            this.text = text;
        }

        public void Construct(ReportBuilder reportBuilder)
        {
            reportBuilder.SetReportName();
            reportBuilder.SetReportType();
            reportBuilder.FillTitle();
            reportBuilder.FillContent();
        }

    }
}
