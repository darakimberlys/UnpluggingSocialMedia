using Polly;
using Polly.Retry;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedias.Core.Services;

public class PollyPolicyService : IPollyPolicyService
{
    public AsyncRetryPolicy GetRetryPolicy()
    {
        return Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
        (exception, timeSpan, retryAttempt, context) => { });
    }
}