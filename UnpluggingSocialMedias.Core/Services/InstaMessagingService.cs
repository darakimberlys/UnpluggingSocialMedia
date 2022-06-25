using InstagramApiSharp;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace UnpluggingSocialMedias.Core.Services;

public class InstaMessagingService : IMessagingProcessor
{
    public Task<IResult<InstaDirectInboxThread>> AddUserToGroupThreadAsync(string threadId, params long[] userIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> ApproveDirectPendingRequestAsync(params string[] threadIds)
    {
        //review by email and implement bool 
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> DeclineAllDirectPendingRequestsAsync()
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> DeclineDirectPendingRequestsAsync(params string[] threadIds)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> DeleteDirectThreadAsync(string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> DeleteSelfMessageAsync(string threadId, string itemId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<InstaDirectInboxContainer>> GetDirectInboxAsync(PaginationParameters paginationParameters)
    {
        //receive and send to email
        throw new NotImplementedException();
    }

    public Task<IResult<InstaDirectInboxThread>> GetDirectInboxThreadAsync(string threadId, PaginationParameters paginationParameters)
    {
        //receive and send to email
        throw new NotImplementedException();
    }

    public Task<IResult<InstaDirectInboxContainer>> GetPendingDirectAsync(PaginationParameters paginationParameters)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<InstaRecipients>> GetRankedRecipientsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IResult<InstaRecipients>> GetRankedRecipientsByUsernameAsync(string username)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<InstaRecipients>> GetRecentRecipientsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IResult<InstaUserPresenceList>> GetUsersPresenceAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> LeaveGroupThreadAsync(string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> LikeThreadMessageAsync(string threadId, string itemId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> MarkDirectThreadAsSeenAsync(string threadId, string itemId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> MuteDirectThreadAsync(string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectDisappearingPhotoAsync(InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectDisappearingPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable,
        params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectDisappearingVideoAsync(InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable,
        params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectDisappearingVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable,
        params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, string[] threadIds, string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectHashtagToRecipientsAsync(string text, string hashtag, params string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectLinkAsync(string text, string link, params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectLinkAsync(string text, string link, string[] threadIds, string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectLinkToRecipientsAsync(string text, string link, params string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectLocationAsync(string externalId, params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectPhotoAsync(InstaImage image, string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(InstaImage image, params string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaImage image, params string[] recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectProfileAsync(long userIdToSend, params string[] threadIds)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectProfileToRecipientsAsync(long userIdToSend, string recipients)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<InstaDirectInboxThreadList>> SendDirectTextAsync(string recipients, string threadIds, string text)
    {
        //send message received by email
        throw new NotImplementedException();

    }

    public Task<IResult<bool>> SendDirectVideoAsync(InstaVideoUpload video, string threadId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> SendDirectVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string threadId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> SendDirectVideoToRecipientsAsync(InstaVideoUpload video, params string[] recipients)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> SendDirectVideoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, params string[] recipients)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> ShareMediaToThreadAsync(string mediaId, InstaMediaType mediaType, string text, params string[] threadIds)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> ShareMediaToUserAsync(string mediaId, InstaMediaType mediaType, string text, params long[] userIds)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<InstaSharing>> ShareUserAsync(string userIdToSend, string threadId)
    {
        throw new NotImplementedException();//not needed
    }

    public Task<IResult<bool>> UnLikeThreadMessageAsync(string threadId, string itemId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> UnMuteDirectThreadAsync(string threadId)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> UpdateDirectThreadTitleAsync(string threadId, string title)
    {
        throw new NotImplementedException();
    }

    public Task<IResult<bool>> SendDirectLikeAsync(string threadId)
    {
        throw new NotImplementedException();
    }
}