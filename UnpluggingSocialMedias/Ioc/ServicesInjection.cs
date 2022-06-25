using UnpluggingSocialMedias.Core.Services.Email;
using UnpluggingSocialMedias.Core.Services.Insta;
using UnpluggingSocialMedias.Core.Services.Interfaces;

namespace UnpluggingSocialMedias.Ioc;

public static class ServicesInjection
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IInstaMessagingService, InstaMessagingService>();
        serviceCollection.AddSingleton<IEmailService, EmailService>();
    }

    //public static void AddCredencials(this IServiceCollection serviceCollection)
    //{
    //    serviceCollection.AddAuthentication(
    //        opt => opt.);
    //}
}