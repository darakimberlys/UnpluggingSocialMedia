using InstagramApiSharp;
using Microsoft.AspNetCore.Mvc;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedias.Controller;

[Route("update")]
[ApiController]
public class RequesterController
{
    private readonly IInstaMessagingService _instaMessaging;
    private readonly IEmailService _emailService;

    public RequesterController(
        IInstaMessagingService instaMessaging, 
        IEmailService emailService)
    {
        _instaMessaging = instaMessaging;
        _emailService = emailService;
    }


    /// <summary>
    /// Get messages from instagram and send for email
    /// </summary>
    [HttpGet]
    public async Task<ActionResult> GetMessagesFromInstagramAsync()
    {
        //var message = await _instaMessaging.GetDirectInboxThreadAsync("", PaginationParameters.MaxPagesToLoad(220));

        //if (message.Succeeded)
        //{
        //    if (message.Value.Items.Count > 0)
        //    {

        //    }
        //}
        try
        {
            _emailService.CreateMessage();
            return new AcceptedResult();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}