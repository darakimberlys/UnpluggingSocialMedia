using System.Net;
using System.Net.Mail;
using UnpluggingSocialMedias.Core.Domain;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedias.Core.Services.Email;

public class EmailService : IEmailService
{
    private readonly IPollyPolicyService _pollyPolicyService;
    private readonly string _emailSender;
    private readonly string _emailPassword;
    private readonly string _emailReceiver;

    public EmailService(IPollyPolicyService policyService)
    {
        _pollyPolicyService = policyService;
        _emailSender = Environment.GetEnvironmentVariable("EMAIL_SENDER");
        _emailPassword = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");
        _emailReceiver = Environment.GetEnvironmentVariable("EMAIL_RECEIVER");
    }

    public async Task CreateMessage(MessageData messageData)
    {
        var retryPolicy = _pollyPolicyService.GetRetryPolicy();

        try
        {
            var msg = new MailMessage
            {
                From = new MailAddress(_emailSender),
                To = { _emailReceiver }
            };

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_emailSender, _emailPassword),
                EnableSsl = true
            };
            
            msg.Subject = $"{messageData.SocialMedia} - {messageData.UserSender}: {messageData.Subject}";
            msg.Body = messageData.Message;

            await retryPolicy.ExecuteAsync(async () =>
            {
                smtp.Send(msg);
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}