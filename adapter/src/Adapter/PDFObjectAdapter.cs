namespace Adapter
{
    class PDFObjectAdapter : IExporter
    {
        private PDFWriter pdfWriter = new PDFWriter();
        public void Export()
        {
            pdfWriter.WriteToPDF();
        }
    }
}
