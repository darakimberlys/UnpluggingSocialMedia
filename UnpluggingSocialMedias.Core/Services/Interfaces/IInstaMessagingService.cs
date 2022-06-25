using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;

namespace UnpluggingSocialMedias.Core.Services.Interfaces;

public interface IInstaMessagingService : IMessagingProcessor
{
    Task<IResult<bool>> ApproveDirectPendingRequestAsync(params string[] threadIds);
}