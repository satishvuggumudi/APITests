using System;
using System.Linq;
using SolidToken.SpecFlow.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace APITests
{
    public static class Startup
    {
        /// <summary>
        /// Creates the service collection.
        /// </summary>
        /// <returns>Collection of service dependices</returns>
        [ScenarioDependencies]
        public static IServiceCollection CreateServiceCollection()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            var config = configurationBuilder.Build();

            var services = new ServiceCollection();

            var clientConfig = new ClientConfig();
            config.Bind("api", clientConfig);
            services.AddApiServices(clientConfig);

            //Required code to make specFlowWork
            foreach (var type in typeof(Startup).Assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))))
            {
                services.AddSingleton(type);
            }
            return services;

        }
    }


}
