using Polly.Retry;

namespace UnpluggingSocialMedias.Core.Services.Interfaces;

public interface IPollyPolicyService
{
    AsyncRetryPolicy GetRetryPolicy();
}