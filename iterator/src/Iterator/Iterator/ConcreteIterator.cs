using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count - 1;
        }

        public override object Next()
        {
            object next = null;
            if (_current < _aggregate.Count - 1)
            {
                next = _aggregate[++_current];
            }
            return next;
        }
    }
}
