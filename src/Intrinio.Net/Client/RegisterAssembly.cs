using System;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pineapple.Networking;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Client
{
    public class RegisterAssembly
    {
        private const string INTRINIO_API_KEY_NAME = "IntrinioApiKey";
        
        public static void AddServices(IServiceCollection services, IConfiguration config)
        {
            CheckIsNotNull(nameof(services), services);
            CheckIsNotNull(nameof(config), config);

            CheckIsNotNull(INTRINIO_API_KEY_NAME, config[INTRINIO_API_KEY_NAME]);
            
            var settings = new IntrinioSettings()
            {
                ApiKey = config[INTRINIO_API_KEY_NAME],
            };

            services.AddSingleton(settings);
            services.AddTransient<IIntrinioDependencies, IntrinioDependencies>();
            services.AddTransient<ApiClient>();

            AddHttpClient(services, settings);
        }
        private static void AddHttpClient(IServiceCollection services, IntrinioSettings settings)
        {
            services.AddTransient<BrotliCompressionHandler>();
            services.AddHttpClient(settings.HttpClientName, client =>
            {
                client.BaseAddress = new Uri(settings.ApiBaseUrl);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip

            }).AddHttpMessageHandler<BrotliCompressionHandler>();
        }
    }
}