using UnpluggingSocialMedias.Core.Domain;

namespace UnpluggingSocialMedias.Core.Services.Interfaces;

public interface IEmailService
{
    Task CreateMessage(MessageData messageData);
}