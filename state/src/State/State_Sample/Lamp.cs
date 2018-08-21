using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Sample
{
    class Lamp
    {
        private IState _state;
        public Lamp(IState state)
        {
            _state = state;
            Console.WriteLine($"Initialize state -> {state}");
        }
        public void SetState(IState state)
        {
            _state = state;
            Console.WriteLine($"Set State -> {state}");
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
