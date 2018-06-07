using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Group : AbstractEmail
    {
        private List<AbstractEmail> EmailList = new List<AbstractEmail>();
        private string groupName;
        public Group(string groupName)
        {
            this.groupName = groupName;
        }
        
        public void Add(params AbstractEmail[] mails)
        {
            foreach (var mail in mails)
            {
                EmailList.Add(mail);
            }
        }

        public void Remove(AbstractEmail mail)
        {
            EmailList.Remove(mail);
        }

        public AbstractEmail GetChild(int index)
        {
            return EmailList[index];
        }

        public override void Print()
        {
            foreach (var mail in EmailList)
            {
                mail.Print();
            }
        }
    }
}
