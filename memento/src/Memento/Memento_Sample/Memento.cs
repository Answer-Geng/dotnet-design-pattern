using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Sample
{
    public class Memento
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Memento(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
