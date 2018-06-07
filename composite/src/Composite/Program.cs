using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Email wangWu = new Email("Wang Wu", "Wu.Wang@xx.com");
            Group ShangHai = new Group("ShangHai");
            ShangHai.Add(new Email("Zhang San", "San.Zhange@xx.com"), new Email("Li Si", "Si.Li@xx.com"));
            Group BeiJing = new Group("BeiJing");
            BeiJing.Add(new Email("Zhao Liu", "Liu.Zhao@xx.com"));
            Group China = new Group("China");
            China.Add(ShangHai);
            China.Add(wangWu);
            China.Add(BeiJing);
            China.Print();
            Console.ReadLine();
      
        }
    }
}
