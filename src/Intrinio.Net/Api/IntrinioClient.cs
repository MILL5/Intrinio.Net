using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Polly;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient : IIntrinioClient
    {
        public readonly IIntrinioDependencies Dependencies;
        public readonly HttpClient Client;
        public readonly IMapper _mapper;
        public readonly ILogger _logger;

        public IntrinioClient(IIntrinioDependencies dependencies)
        {
            Dependencies = dependencies;
            Client = dependencies.HttpClientFactory.CreateClient(IntrinioSettings.HttpClientName);
            _mapper = dependencies.Mapper;
            _logger = dependencies.Logger;
        }

        public async Task<string> GetAsync(string requestUrl)
        {
            CheckIsNotNullOrWhitespace(nameof(requestUrl), requestUrl);

            var url = new Uri($"{requestUrl}{(requestUrl.Contains('?') ? "&" : "?")}api_key={Dependencies.Settings.ApiKey}");

            HttpResponseMessage response = null;

            await Policy
                .Handle<ArgumentNullException>()
                .Or<InvalidOperationException>()
                .Or<HttpRequestException>()
                .Or<TaskCanceledException>()
                .WaitAndRetryAsync(
                    IntrinioSettings.NumberOfRetries,
                    retryAttempt => TimeSpan.FromSeconds(Math.Pow(4, retryAttempt)),
                    (exception, timeSpan, retryCount, context) =>
                    {
                        _logger.LogInformation("Retrying due to {message}. Try {count} of {total}.",
                            exception.Message,
                            retryCount,
                            IntrinioSettings.NumberOfRetries);
                    })
                .ExecuteAsync(async () =>
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, url);
                    response = await Client.SendAsync(request).ConfigureAwait(false);

                    if (!response.IsSuccessStatusCode)
                    {
                        var errorContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new IntrinioNetException($"{response.StatusCode} - {errorContent}");
                    }
                }).ConfigureAwait(false);

            return await response!.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public static string GetQueryParameterString(Dictionary<string, string> parameters)
        {
            CheckIsNotNull(nameof(parameters), parameters);

            var nonEmptyParameters = parameters.Where(x => !string.IsNullOrEmpty(x.Value));
            return nonEmptyParameters.Any() ? $"?{string.Join("&", nonEmptyParameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}" : string.Empty;
        }
    }
}
