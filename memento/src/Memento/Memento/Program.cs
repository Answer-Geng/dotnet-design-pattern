using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "Off";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "On";
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine(originator.State);
            Console.ReadLine();
        }
    }
}
