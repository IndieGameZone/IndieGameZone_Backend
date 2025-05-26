using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.Utils
{
    public record Mail
    {
        public MailAddress To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Mail(string to, string subject, string body)
        {
            To = new MailAddress(to);
            Subject = subject;
            Body = body;
        }
    }
}
