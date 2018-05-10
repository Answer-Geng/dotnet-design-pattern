using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSample
{
    public class MailBuilder
    {
        private string host = "xxxx.xxx.com";
        private string subject;
        private string body;
        private bool isBodyHtml;
        private string from;
        private List<string> to;
        private List<string> cc;
        private List<Attachment> attachment;
        private MailPriority priority;

        public MailBuilder Subject(string subject)
        {
            this.subject = subject;
            return this;
        }

        public MailBuilder Body(string body)
        {
            this.body = body;
            return this;
        }

        public MailBuilder IsBodyHtml(bool isBodyHtml)
        {
            this.isBodyHtml = isBodyHtml;
            return this;
        }

        public MailBuilder MailFrom(string mailFrom)
        {
            this.from = mailFrom;
            return this;
        }

        public MailBuilder MailTo(List<string> mailTo)
        {
            this.to = mailTo;
            return this;
        }

        public MailBuilder MailCc(List<string> mailCc)
        {
            this.cc = mailCc;
            return this;
        }

        public MailBuilder Attachment(List<Attachment> attachment)
        {
            this.attachment = attachment;
            return this;
        }

        public MailBuilder MailPriority(MailPriority mailpriority)
        {
            this.priority = mailpriority;
            return this;
        }

        public void Send()
        {
            SmtpClient client = new SmtpClient(host);
            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            MailMessage msg = new MailMessage();
            msg.Subject = this.subject;
            msg.Body = this.body;
            msg.IsBodyHtml = this.isBodyHtml;
            msg.From = new MailAddress(this.from);
            if (this.to != null)
            {
                this.to.ForEach(p => msg.To.Add(p));
            }

            if (this.cc != null)
            {
                this.cc.ForEach(p => msg.CC.Add(p));
            }

            if (this.attachment != null)
            {
                this.attachment.ForEach(p => msg.Attachments.Add(p));
            }
            msg.Priority = this.priority;
            client.Send(msg);
        }

    }
}
