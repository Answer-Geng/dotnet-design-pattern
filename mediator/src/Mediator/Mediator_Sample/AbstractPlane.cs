using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Sample
{
    public abstract class AbstractPlane
    {
        protected string _name;
        public AbstractPlane(string name)
        {
            _name = name;   
        }

        public ControlTower ControlTower { get; set; }
        public string Name
        {
            get { return _name; }
        }
        public abstract void Send(string to, string message);
        public abstract void Receive(string from, string message);
    }
}
