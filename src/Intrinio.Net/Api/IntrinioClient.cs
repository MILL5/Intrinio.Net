using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Intrinio.Net.Client;
using M5.FinancialDataSanitizer;
using Polly;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient : IIntrinioClient
    {
        public IIntrinioDependencies Dependencies { get; }
        public HttpClient Client { get; }
        
        public IMapper Mapper { get; }
        
        private readonly AbbreviationParser _parser;
        private readonly string allCompaniesBaseUrl;
        private readonly string searchCompaniesBaseUrl;
        private readonly string allSecuritiesByCompanyBaseUrl;
        private readonly string lookupCompanyBaseUrl;
        private readonly string stockPricesBySecurityBaseUrl;
        private readonly string exchangesBaseUrl;
        private readonly string stockPricesByExchangeBaseUrl;
        private readonly string securitiesByExchangeBaseUrl;

        private readonly string securitiesBaseUrl;

        public IntrinioClient(IIntrinioDependencies dependencies)
        {
            Dependencies = dependencies;
            Client = dependencies.HttpClientFactory.CreateClient(dependencies.Settings.HttpClientName);
            _parser = Dependencies.AbbreviationParser;
            Mapper = dependencies.Mapper;
            
            // Company Routes
            allCompaniesBaseUrl =  $"{Dependencies.Settings.ApiBaseUrl}/companies";
            searchCompaniesBaseUrl = $"{allCompaniesBaseUrl}/search";
            allSecuritiesByCompanyBaseUrl = allCompaniesBaseUrl + "/{0}/securities";
            lookupCompanyBaseUrl = allCompaniesBaseUrl + "/{0}";
            
            // Exchanges Routes
            exchangesBaseUrl = $"{Dependencies.Settings.ApiBaseUrl}/stock_exchanges";
            
            // Securities Routes
            securitiesBaseUrl = $"{Dependencies.Settings.ApiBaseUrl}/securities";
            securitiesByExchangeBaseUrl = exchangesBaseUrl + "/{0}/securities";

            
            // Stock Price Routes
            stockPricesBySecurityBaseUrl = securitiesBaseUrl + "/{0}/prices";
            stockPricesByExchangeBaseUrl = exchangesBaseUrl + "/{0}/prices";
        }

        public async Task<string> Get(string requestUrl)
        {
            requestUrl = $"{ requestUrl }{ (requestUrl.Contains("?") ? "&" : "?") }api_key={ Dependencies.Settings.ApiKey }";

            var lockObj = new object();

            HttpResponseMessage response = null;

            await Policy
                .Handle<Exception>()
                .RetryAsync(3)
                .ExecuteAsync(async () =>
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    var tryResponse = await Client.SendAsync(request)
                        .ConfigureAwait(false);
                    if (!tryResponse.IsSuccessStatusCode)
                    {
                        if (string.Equals(tryResponse.ReasonPhrase, "Too Many Requests", StringComparison.OrdinalIgnoreCase))
                        {
                            Thread.Sleep(10000);
                        }
                        throw new HttpRequestException(tryResponse.ReasonPhrase);
                    }

                    lock (lockObj)
                    {
                        response = tryResponse;
                    }
                }).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
        }

        public string GetQueryParameterString(Dictionary<string, string> queryParams)
        {
            var sb = new StringBuilder();

            foreach(var qp in queryParams)
            {
                if(!string.IsNullOrEmpty(qp.Value))
                {
                    sb.Append($"&{ qp.Key }={ qp.Value }");
                }
            }

            if(sb.Length == 0)
            {
                return string.Empty;
            }

            sb.Remove(0, 1);
            sb.Insert(0, "?");

            return sb.ToString();
        }

        public string FormatDateString(string inputDateString)
        {
            if (inputDateString == null)
                return null;

            var dateIsParsed = DateTime.TryParse(inputDateString, out DateTime outTime);

            if (!dateIsParsed)
            {
                try
                {
                    outTime = DateTimeOffset.FromUnixTimeMilliseconds(Int64.Parse(inputDateString)).UtcDateTime;
                }
                catch
                {
                    throw new Exception("Invalid date input.");
                }
            }

            return outTime.ToString("yyyy-MM-dd");
        }
    }
}