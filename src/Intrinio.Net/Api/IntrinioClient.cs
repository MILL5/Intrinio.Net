using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Polly;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient : IIntrinioClient
    {
        public readonly IIntrinioDependencies Dependencies;
        public readonly HttpClient Client;
        public readonly IMapper _mapper;

        public IntrinioClient(IIntrinioDependencies dependencies)
        {
            Dependencies = dependencies;
            Client = dependencies.HttpClientFactory.CreateClient(IntrinioSettings.HttpClientName);
            _mapper = dependencies.Mapper;
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
                .RetryAsync(3)
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

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public static string GetQueryParameterString(Dictionary<string, string> parameters)
        {
            CheckIsNotNull(nameof(parameters), parameters);

            var nonEmptyParameters = parameters.Where(x => !string.IsNullOrEmpty(x.Value));
            return nonEmptyParameters.Any() ? $"?{string.Join("&", nonEmptyParameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}" : string.Empty;
        }
    }
}
