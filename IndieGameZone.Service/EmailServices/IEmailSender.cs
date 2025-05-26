using IndieGameZone.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.EmailServices
{
    public interface IEmailSender
    {
        void SendEmail(Mail mail);
    }
}
