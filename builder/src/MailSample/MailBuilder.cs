using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace MailSample
{
    public class MailBuilder
    {
        private string host = "xxx.xxx.com";
        private SmtpClient client;
        private MailMessage msg;
        public MailBuilder()
        {
            client = new SmtpClient(host);
            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            msg = new MailMessage();
        }

        public MailBuilder Subject(string subject)
        {
            msg.Subject = subject;
            return this;
        }

        public MailBuilder Body(string body)
        {
            msg.Body = body;
            return this;
        }

        public MailBuilder IsBodyHtml(bool isBodyHtml)
        {
            msg.IsBodyHtml = isBodyHtml;
            return this;
        }

        public MailBuilder MailFrom(string mailFrom)
        {
            msg.From = new MailAddress(mailFrom);
            return this;
        }

        public MailBuilder MailTo(List<string> mailTo)
        {
            mailTo.ForEach(p => msg.To.Add(p));
            return this;
        }

        public MailBuilder MailCc(List<string> mailCc)
        {
            mailCc.ForEach(p => msg.CC.Add(p));
            return this;
        }

        public MailBuilder Attachment(List<Attachment> attachment)
        {
            attachment.ForEach(p => msg.Attachments.Add(p));
            return this;
        }

        public MailBuilder MailPriority(MailPriority mailpriority)
        {
            msg.Priority = mailpriority;
            return this;
        }

        public void Send()
        {
            client.Send(msg);
        }

    }
}
