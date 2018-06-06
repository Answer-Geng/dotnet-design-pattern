using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Letter
    {
        protected IColor color;
        public void SetColor(IColor color)
        {
            this.color = color;
        }

        public abstract void Write();
    }
}
