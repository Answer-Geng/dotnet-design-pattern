using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserverB : Observer
    {
        public ConcreteObserverB(Subject subject)
        {
            _subject = subject;
            subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine($"ConcreteObserverB Update State:{_subject.GetState()}");
        }
    }
}
