using Intrinio.Net.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pineapple.Networking;
using System;
using System.Net;
using System.Net.Http;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net
{
    public static class RegisterAssembly
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
            services.AddTransient<IIntrinioClient, IntrinioClient>();

            services.AddAutoMapper(typeof(RegisterAssembly));

            AddHttpClient(services);
        }

        private static void AddHttpClient(IServiceCollection services)
        {
            services.AddTransient<BrotliCompressionHandler>();
            services.AddHttpClient(IntrinioSettings.HttpClientName, client =>
            {
                client.BaseAddress = new Uri(RestApiUrls.BASE_URL);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            }).AddHttpMessageHandler<BrotliCompressionHandler>();
        }
    }
}