using BookStore.Core.Domain.Contracts;
using BookStore.Infrastructure.Communication.Services;

using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure.Persistence
{
    public static class CommunicationServiceRegistration
    {
        public static IServiceCollection AddCommunicationServices(this IServiceCollection services)
        {
            //services.AddScoped<ISmsSender, SmsSender>();
            return services;
        }
    }
}
