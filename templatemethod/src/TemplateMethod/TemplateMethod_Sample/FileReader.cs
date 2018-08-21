using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Sample
{
    public abstract class DocumentReader
    {
        protected string _fileName;
        public DocumentReader(string fileName)
        {
            _fileName = fileName;
        }
        public abstract void Open();
        public abstract void Read();
        public abstract void Close();
        public void DoRead()
        {
            Open();
            Read();
            Close();
        }
    }
}
