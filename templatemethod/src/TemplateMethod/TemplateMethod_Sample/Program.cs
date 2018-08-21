using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFileName = "abc.txt";
            DocumentReader text = new TextReader(textFileName);
            text.DoRead();

            string excelFileName = "abc.xlsx";
            DocumentReader excel = new ExcelReader(excelFileName);
            excel.DoRead();
            Console.ReadLine();
        }
    }
}
