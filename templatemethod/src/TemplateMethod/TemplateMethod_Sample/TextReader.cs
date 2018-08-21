using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Sample
{
    public class TextReader : DocumentReader
    {
        public TextReader(string path) : base(path)
        {
        }

        public override void Close()
        {
            Console.WriteLine($"Closing Text file : [{_fileName}]");
        }

        public override void Open()
        {
            Console.WriteLine($"Openning Text file : [{_fileName}]");
        }

        public override void Read()
        {
            Console.WriteLine($"Reading Text file : [{_fileName}]");
        }
    }
}
