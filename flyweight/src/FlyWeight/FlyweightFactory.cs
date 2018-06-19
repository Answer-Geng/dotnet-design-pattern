using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();
        public Flyweight GetFlyweight(string key)
        {
            Flyweight flyweight;
            if (_flyweights.ContainsKey(key))
            {
                Console.WriteLine("Already in the pool , use the exist one.");
                flyweight = _flyweights[key];
            }
            else
            {
                switch (key)
                {
                    case "A":
                        flyweight = new ConcreteFlyweightA();
                        break;
                    case "B":
                        flyweight = new ConcreteFlyweightB();
                        break;
                    default:
                        throw new Exception("Don't support this key");
                }

                _flyweights.Add(key, flyweight);
            }
            return _flyweights[key];
        }
    }
}
