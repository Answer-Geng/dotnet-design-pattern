using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            User jack = new User("jack", "12345");
            UserMemory memory = new UserMemory();
            memory.Memento = jack.CreateMemento();
            jack.Password = "23456";
            jack.Password = "qwert";
            jack.SetMemento(memory.Memento);
            Console.WriteLine(jack.Password);
            Console.ReadLine();
        }
    }
}
