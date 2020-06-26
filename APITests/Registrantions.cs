using ApiServices;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;


namespace APITests
{
    public static class Registrantions
    {
        /// <summary>
        /// Adds the API services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="config">The configuration.</param>
        /// <returns>return service dependices for request resouce</returns>
        public static IServiceCollection AddApiServices(this IServiceCollection services, ClientConfig config)
        {
            services.AddRefitClient<IApiClientResource>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(config.BaseUrl));
            return services;
        }
    }
}
