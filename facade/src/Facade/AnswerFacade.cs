using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class AnswerFacade
    {
        private Refrigerator refrigerator = new Refrigerator();
        private Elephant elephant = new Elephant();

        public void Answer()
        {
            refrigerator.OpenTheDoor();
            elephant.PutIntoTheRefrigerator();
            refrigerator.CloseTheDoor();
        }
    }
}
