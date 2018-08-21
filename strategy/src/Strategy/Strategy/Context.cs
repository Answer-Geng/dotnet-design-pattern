using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
