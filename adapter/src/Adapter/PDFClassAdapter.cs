namespace Adapter
{
    class PDFClassAdapter : PDFWriter, IExporter
    {
        public void Export()
        {
            WriteToPDF();
        }
    }
}
