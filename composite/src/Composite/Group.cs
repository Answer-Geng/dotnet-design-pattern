using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Group : AbstractEmail
    {
        private List<AbstractEmail> EmailGroup = new List<AbstractEmail>();
        private string groupName;
        public Group(string groupName)
        {
            this.groupName = groupName;
        }
        
        public void Add(params AbstractEmail[] mails)
        {
            foreach (var mail in mails)
            {
                EmailGroup.Add(mail);
            }
        }

        public AbstractEmail GetChild(int index)
        {
            return EmailGroup[index];
        }

        public override void Print()
        {
            foreach (var mail in EmailGroup)
            {
                mail.Print();
            }
        }
    }
}
