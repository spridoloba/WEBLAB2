using System;

namespace WEBLAB1.Services
{
    public interface IEmailSender
    {
        void SendEmail(string to, string subject, string body);
    }
}
