using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PDFAdapter : IExporter
    {
        private PDFWriter writer = new PDFWriter();
        public void Export()
        {
            writer.WriteToPDF();
        }
    }
}
