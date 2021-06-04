using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Intrinio.Net.Client;
using M5.FinancialDataSanitizer;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient : IIntrinioClient
    {
        public IIntrinioDependencies Dependencies { get; }
        public HttpClient Client { get; }
        
        private readonly AbbreviationParser _parser;
        private readonly string allCompaniesBaseUrl;
        private readonly string searchCompaniesBaseUrl;
        private readonly string allSecuritiesByCompanyBaseUrl;
        private readonly string lookupCompanyBaseUrl;
        
        public IntrinioClient(IIntrinioDependencies dependencies)
        {
            Dependencies = dependencies;
            Client = dependencies.HttpClientFactory.CreateClient(dependencies.Settings.HttpClientName);
            _parser = Dependencies.AbbreviationParser;
            allCompaniesBaseUrl =  $"{Dependencies.Settings.ApiBaseUrl}/companies";
            searchCompaniesBaseUrl = $"{allCompaniesBaseUrl}/search";
            allSecuritiesByCompanyBaseUrl = $"{allCompaniesBaseUrl}/{0}/securities";
            lookupCompanyBaseUrl = $"{allCompaniesBaseUrl}/{0}";
        }

        public async Task<string> Get(string requestUrl)
        {
            requestUrl = $"{ requestUrl }{ (requestUrl.Contains("?") ? "&" : "?") }api_key={ Dependencies.Settings.ApiKey }";

            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var response = await Client.SendAsync(request);

            if(!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            
            return await response.Content.ReadAsStringAsync();
        }

        public string GetQueryParameterString(Dictionary<string, string> queryParams)
        {
            var sb = new StringBuilder();

            foreach(var qp in queryParams)
            {
                if(qp.Value != null)
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