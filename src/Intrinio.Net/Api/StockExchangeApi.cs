using Intrinio.Net.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<ApiResponseStockExchanges> GetAllExchangesAsync(
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

            var jsonResponse = await GetAsync($"{RestApiUrls.Exchanges.Default}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
            
            return JsonConvert.DeserializeObject<ApiResponseStockExchanges>(jsonResponse);
        }

        public async Task<StockExchange> LookupExchangeAsync(string identifier)
        {
            var jsonResponse = await GetAsync($"{RestApiUrls.Exchanges.Default}/{identifier}").ConfigureAwait(false);
            
            var exchange = JsonConvert.DeserializeObject<StockExchange>(jsonResponse);

            if (exchange == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            return exchange;
        }
    }
}