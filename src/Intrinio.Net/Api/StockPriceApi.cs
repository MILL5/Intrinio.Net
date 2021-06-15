using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Newtonsoft.Json;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<ApiResponseSecurityStockPrices> GetStockPriceSummariesBySecurityAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
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
            
            var result = new ApiResponseSecurityStockPrices();
            
            var jsonResponse = await Get($"{string.Format(stockPricesBySecurityBaseUrl, identifier)}{GetQueryParameterString(queryParams)}")
                .ConfigureAwait(false);
            var apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurityStockPrices>(jsonResponse);
            
            if (apiResponse == null)
            {
                throw new Exception("API Response is Null");
            }

            result = apiResponse;

            while (apiResponse.NextPage != null)
            {
                queryParams[nameof(next_page)] = apiResponse.NextPage;
                jsonResponse = await Get($"{string.Format(stockPricesBySecurityBaseUrl, identifier)}{GetQueryParameterString(queryParams)}")
                    .ConfigureAwait(false);
                apiResponse = JsonConvert.DeserializeObject<ApiResponseSecurityStockPrices>(jsonResponse);
                if (apiResponse == null)
                {
                    throw new Exception("API Response is Null");
                }
                var newPrices = apiResponse.StockPrices;
                result.StockPrices.AddRange(newPrices);
                result.NextPage = apiResponse.NextPage;
            }
             
            return result;
        }

        public async Task<IEnumerable<StockPrice>> GetStockPricesByExchangeAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
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
            
            var jsonResponse = await Get($"{string.Format(stockPricesByExchangeBaseUrl, identifier)}{GetQueryParameterString(queryParams)}")
                .ConfigureAwait(false);
            var apiResponse = JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPrices>(jsonResponse);
            
            if (apiResponse == null)
            {
                throw new Exception("API Response is Null");
            }
             
            var prices = apiResponse.StockPrices;

            result.AddRange(prices);

            while (apiResponse.NextPage != null)
            {
                queryParams[nameof(next_page)] = apiResponse.NextPage;
                jsonResponse = await Get($"{string.Format(stockPricesByExchangeBaseUrl, identifier)}{GetQueryParameterString(queryParams)}")
                    .ConfigureAwait(false);
                apiResponse = JsonConvert.DeserializeObject<ApiResponseStockExchangeStockPrices>(jsonResponse);
                if (apiResponse == null)
                {
                    throw new Exception("API Response is Null");
                }
                prices = apiResponse.StockPrices;
                result.AddRange(prices);
            }
             
            return result;
        }
    }
}