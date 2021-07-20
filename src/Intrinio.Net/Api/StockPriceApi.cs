using Intrinio.Net.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<ApiResponseSecurityStockPrices> GetStockPriceSummariesBySecurityAsync(
            string identifier,
            StockPriceSummary.PeriodFrequency? frequency = null,
            int? page_size = null,
            string start_date = null,
            string end_date = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
            {
                { nameof(frequency), frequency.ToString().ToLower() },
                { nameof(page_size), page_size.ToString().ToLower() },
                { nameof(start_date), start_date },
                { nameof(end_date), end_date },
                { nameof(next_page), next_page }
            };

            var jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Prices.BySecurity, identifier)}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
            
            return JsonConvert.DeserializeObject<ApiResponseSecurityStockPrices>(jsonResponse);
        }

        public async Task<ApiResponseStockExchangeStockPrices> GetStockPricesByExchangeAsync(
            string identifier,
            StockPriceSummary.PeriodFrequency? frequency = null,
            int? page_size = null,
            string date = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
            {
                { nameof(frequency), frequency.ToString().ToLower() },
                { nameof(page_size), page_size.ToString().ToLower() },
                { nameof(date), date },
                { nameof(next_page), next_page }
            };

            var jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.PricesByExchange, identifier)}{GetQueryParameterString(queryParams)}")
                .ConfigureAwait(false);
            
            return JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPrices>(jsonResponse);
        }
    }
}