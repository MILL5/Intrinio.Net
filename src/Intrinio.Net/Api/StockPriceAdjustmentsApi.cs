using System.Collections.Generic;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Newtonsoft.Json;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockPriceAdjustmentsByExchangeAsync(
            string identifier,
            string date,
            int? page_size = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
            {
                { nameof(date), date },
                { nameof(page_size), page_size.ToString() },
                { nameof(next_page), next_page }
            };

            var jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.PriceAdjustmentsByExchange, identifier)}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);

            return JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPriceAdjustments>(jsonResponse);
        }
    }
}