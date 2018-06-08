using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Group : IEmail
    {
        private List<IEmail> emailList = new List<IEmail>();
        private string groupName;
        public Group(string groupName)
        {
            this.groupName = groupName;
        }
        
        public void Add(params IEmail[] mails)
        {
            foreach (var mail in mails)
            {
                emailList.Add(mail);
            }
        }

        public void Remove(IEmail mail)
        {
            emailList.Remove(mail);
        }

        public IEmail GetChild(int index)
        {
            return emailList[index];
        }

        public void Print()
        {
            foreach (var mail in emailList)
            {
                mail.Print();
            }
        }
    }
}
