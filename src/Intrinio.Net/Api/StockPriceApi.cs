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
            var securityStockPrices = JsonConvert.DeserializeObject<ApiResponseSecurityStockPrices>(jsonResponse);

            var result = securityStockPrices ?? throw new IntrinioNetException("API Response is Null");

            while (securityStockPrices.NextPage != null)
            {
                queryParams[nameof(next_page)] = securityStockPrices.NextPage;
                jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Prices.BySecurity, identifier)}{GetQueryParameterString(queryParams)}")
                    .ConfigureAwait(false);
                securityStockPrices = JsonConvert.DeserializeObject<ApiResponseSecurityStockPrices>(jsonResponse);
                if (securityStockPrices == null)
                {
                    throw new IntrinioNetException("API Response is Null");
                }

                var newPrices = securityStockPrices.StockPrices;
                result.StockPrices.AddRange(newPrices);
                result.NextPage = securityStockPrices.NextPage;
            }

            return result;
        }

        public async Task<IEnumerable<StockPrice>> GetStockPricesByExchangeAsync(
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

            var result = new List<StockPrice>();

            var jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.PricesByExchange, identifier)}{GetQueryParameterString(queryParams)}")
                .ConfigureAwait(false);
            var apiResponse = JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPrices>(jsonResponse);

            if (apiResponse == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            var prices = apiResponse.StockPrices;

            result.AddRange(prices);

            while (apiResponse.NextPage != null)
            {
                queryParams[nameof(next_page)] = apiResponse.NextPage;
                jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.PricesByExchange, identifier)}{GetQueryParameterString(queryParams)}")
                    .ConfigureAwait(false);
                apiResponse = JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPrices>(jsonResponse);
                if (apiResponse == null)
                {
                    throw new IntrinioNetException("API Response is Null");
                }
                prices = apiResponse.StockPrices;
                result.AddRange(prices);
            }

            return result;
        }
    }
}