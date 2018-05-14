using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> to = new List<string> { "xxx@xxx.com" };
            MailBuilder mail = new MailBuilder();
            mail.Subject($"{DateTime.Now}")
                .Body("Test")
                .MailFrom("xxxx@xxxx.com")
                .MailTo(to)
                .Send();
        }
    }
}
