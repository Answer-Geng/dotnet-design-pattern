using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Sample
{
    public class ControlTower
    {
        private Dictionary<string, AbstractPlane> _planes = new Dictionary<string, AbstractPlane>();

        public void Register(AbstractPlane plane)
        {
            if (!_planes.ContainsValue(plane))
            {
                _planes[plane.Name] = plane;
            }

            plane.ControlTower = this;
        }

        public void SendMessage(string from, string to, string message)
        {
            if (_planes.ContainsKey(to))
            {
                _planes[to].Receive(from, message);
            }
        }
    }
}
