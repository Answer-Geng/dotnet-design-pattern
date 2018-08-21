using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserverA : Observer
    {
        public ConcreteObserverA(Subject subject)
        {
            _subject = subject;
            subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine($"ConcreteObserverA Update State:{_subject.GetState()}");
        }
    }
}
