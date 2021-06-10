using Intrinio.Net.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<IEnumerable<StockExchange>> GetAllExchangesAsync(
            string city = null,
            string country = null,
            string country_code = null,
            int? page_size = null)
        {
            var queryParams = new Dictionary<string, string>
            {
                { nameof(city), city },
                { nameof(page_size), page_size.ToString() },
                { nameof(country), country },
                { nameof(country_code), country_code }
            };
            
            var result = new List<StockExchange>();
            
            var jsonResponse = await Get($"{exchangesBaseUrl}{GetQueryParameterString(queryParams)}")
                .ConfigureAwait(false);
            var apiResponse = JsonConvert.DeserializeObject<ApiResponseStockExchanges>(jsonResponse);
            
            if (apiResponse == null)
            {
                throw new Exception("API Response is Null");
            }

            return apiResponse.StockExchanges;
        }

        public async Task<StockExchange> LookupExchangeAsync(string identifier)
        {
            var jsonResponse = await Get($"{exchangesBaseUrl}/{identifier}")
                .ConfigureAwait(false);
            var exchange = JsonConvert.DeserializeObject<StockExchange>(jsonResponse);

            if (exchange == null)
            {
                throw new Exception("API Response is Null");
            }

            return exchange;
        }
    }
}
