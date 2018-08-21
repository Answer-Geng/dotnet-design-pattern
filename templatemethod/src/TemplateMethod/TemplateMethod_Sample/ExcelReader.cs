using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Sample
{
    class ExcelReader : DocumentReader
    {
        public ExcelReader(string path) : base(path)
        {
        }

        public override void Close()
        {
            Console.WriteLine($"Closing Excel : [{_fileName}]");
        }

        public override void Open()
        {
            Console.WriteLine($"Openning Excel : [{_fileName}]");
        }

        public override void Read()
        {
            Console.WriteLine($"Reading Excel : [{_fileName}]");
        }
    }
}
