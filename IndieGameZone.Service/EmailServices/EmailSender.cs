using IndieGameZone.Domain.Utils;
using Microsoft.Extensions.Configuration;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.EmailServices
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;

        public EmailSender(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void SendEmail(Mail mail)
        {
            var mailMessage = CreateMailMessage(mail);
            Send(mailMessage);
        }

        private MailMessage CreateMailMessage(Mail mail)
        {
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(configuration.GetSection("Email").Value!);
            mailMessage.Subject = mail.Subject;
            mailMessage.To.Add(mail.To);
            mailMessage.Body = mail.Body;
            mailMessage.IsBodyHtml = true;
            return mailMessage;
        }

        private void Send(MailMessage mailMessage)
        {
            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(configuration.GetSection("Email").Value!, configuration.GetSection("Password").Value!);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
        }
    }
}
