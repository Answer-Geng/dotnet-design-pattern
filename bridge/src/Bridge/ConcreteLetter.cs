using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class B : Letter
    {
        public override void Write()
        {
            color.Paint("B");
        }
    }

    class D : Letter
    {
        public override void Write()
        {
            color.Paint("D");
        }
    }

    class E : Letter
    {
        public override void Write()
        {
            color.Paint("E");
        }
    }

    class G : Letter
    {
        public override void Write()
        {
            color.Paint("G");
        }
    }

    class I : Letter
    {
        public override void Write()
        {
            color.Paint("I");
        }
    }

    class R : Letter
    {
        public override void Write()
        {
            color.Paint("R");
        }
    }
    
}
