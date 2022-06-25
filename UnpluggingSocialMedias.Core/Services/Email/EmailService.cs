using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedias.Core.Services.Email;

public class EmailService : IEmailService
{
    public EmailService()
    {
    }

    public void CreateMessage()
    {
        var msg = new MailMessage()
        {
            From = new MailAddress(Environment.GetEnvironmentVariable("EMAIL_SENDER")),
            To = { Environment.GetEnvironmentVariable("EMAIL_RECEIVER") }
        };

        var smtp = new SmtpClient()
        {
            Host = "smtp.gmail.com",
            Port = 587,
            Credentials = new NetworkCredential(
                Environment.GetEnvironmentVariable("EMAIL_SENDER"),
                Environment.GetEnvironmentVariable("EMAIL_PASSWORD")),
            EnableSsl = true
        };


        msg.Subject = "Test Application";
        msg.Body = "Testing application";

        smtp.Send(msg);
    }

}