using Intrinio.Net.Model;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<IEnumerable<SecuritySummary>> GetAllSecuritiesAsync(
            bool? active = null,
            bool? delisted = null,
            string code = null,
            string currency = null,
            string ticker = null,
            string name = null,
            string composite_mic = null,
            string exchange_mic = null,
            string stock_prices_after = null,
            string stock_prices_before = null,
            string cik = null,
            string figi = null,
            string share_class_figi = null,
            string figi_unique_id = null,
            bool? include_non_figi = null,
            int? page_size = null,
            bool? primary_listing = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
             {
                  { nameof(active), active?.ToString() },
                  { nameof(delisted), delisted?.ToString() },
                  { nameof(code), code },
                  { nameof(currency), currency },
                  { nameof(ticker), ticker },
                  { nameof(name), name },
                  { nameof(composite_mic), composite_mic },
                  { nameof(exchange_mic), exchange_mic },
                  { nameof(stock_prices_after), stock_prices_after },
                  { nameof(stock_prices_before), stock_prices_before },
                  { nameof(cik), cik },
                  { nameof(figi), figi },
                  { nameof(figi_unique_id), figi_unique_id },
                  { nameof(include_non_figi), include_non_figi?.ToString() },
                  { nameof(page_size), page_size.ToString() },
                  { nameof(primary_listing), primary_listing?.ToString() },
                  { nameof(next_page), next_page }
             };

             var result = new List<SecuritySummary>();
             
             var jsonResponse = await Get($"{securitiesBaseUrl}{GetQueryParameterString(queryParams)}");
             var apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);
             
             if (apiResponse == null)
             {
                  throw new Exception("API Response is Null");
             }
             
             var securities = apiResponse.Securities;

             result.AddRange(securities);

             while (apiResponse.NextPage != null)
             {
                 queryParams[nameof(next_page)] = apiResponse.NextPage;
                 jsonResponse = await Get($"{securitiesBaseUrl}{GetQueryParameterString(queryParams)}");
                 apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);

                 if (apiResponse == null)
                 {
                     throw new Exception("API Response is Null");
                 }

                 securities = apiResponse.Securities; 
                 result.AddRange(securities);
             }
             
             return result;
        }

        public async Task<IEnumerable<SecuritySummary>> GetAllSecuritiesByExchangeAsync(
            string identifier,
            int? page_size = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
             {
                  { nameof(page_size), page_size.ToString() },
                  { nameof(next_page), next_page }
             };

             var result = new List<SecuritySummary>();
             
             var jsonResponse = await Get($"{string.Format(securitiesByExchangeBaseUrl, identifier)}{GetQueryParameterString(queryParams)}");
             var apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);
             
             if (apiResponse == null)
             {
                  throw new Exception("API Response is Null");
             }
             
             var securities = apiResponse.Securities;

             result.AddRange(securities);

             while (apiResponse.NextPage != null)
             {
                 queryParams[nameof(next_page)] = apiResponse.NextPage;
                 jsonResponse = await Get($"{string.Format(securitiesByExchangeBaseUrl, identifier)}{GetQueryParameterString(queryParams)}");
                 apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);

                 if (apiResponse == null)
                 {
                     throw new Exception("API Response is Null");
                 }

                 securities = apiResponse.Securities; 
                 result.AddRange(securities);
             }
             
             return result;
        }

        public async Task<IEnumerable<SecuritySummary>> LookupSecurityAsync(string identifier)
        {
            var jsonResponse = await Get($"{securitiesBaseUrl}/{identifier}");
            var security = new List<SecuritySummary>()
                {JsonConvert.DeserializeObject<SecuritySummary>(jsonResponse)};

            if (security == null)
            {
                throw new Exception("API Response is Null");
            }
            
            return security;
        }
    }
}