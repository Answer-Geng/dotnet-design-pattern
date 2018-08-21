using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Sample
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(string username,string password)
        {
            this.UserName = username;
            this.Password = password;
        }
        public Memento CreateMemento()
        {
            return new Memento(UserName, Password);
        }

        public void SetMemento(Memento memento)
        {
            this.UserName = memento.UserName;
            this.Password = memento.Password;
        }
    }
}
