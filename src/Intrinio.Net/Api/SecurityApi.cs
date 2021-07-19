using Intrinio.Net.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<IEnumerable<SecuritySummary>> GetAllSecuritySummariesAsync(
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

            var jsonResponse = await GetAsync($"{RestApiUrls.Securities.Default}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
            var securities = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);

            if (securities == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            result.AddRange(securities.Securities);

            while (securities.NextPage != null)
            {
                queryParams[nameof(next_page)] = securities.NextPage;
                jsonResponse = await GetAsync($"{RestApiUrls.Securities.Default}{GetQueryParameterString(queryParams)}")
                    .ConfigureAwait(false);
                securities = JsonConvert.DeserializeObject<ApiResponseSecurities>(jsonResponse);

                if (securities == null)
                {
                    throw new IntrinioNetException("API Response is Null");
                }

                result.AddRange(securities.Securities);
            }

            return result;
        }

        public async Task<ApiResponseStockExchangeSecurities> GetAllSecuritySummariesByExchangeAsync(
            string identifier,
            int? page_size = null,
            string next_page = null)
        {
            var queryParams = new Dictionary<string, string>
             {
                  { nameof(page_size), page_size.ToString() },
                  { nameof(next_page), next_page }
             };

            var jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.SecuritiesByExchange, identifier)}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
            var stockExchangeSecurities = JsonConvert.DeserializeObject<ApiResponseStockExchangeSecurities>(jsonResponse);

            if (stockExchangeSecurities == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            var result = stockExchangeSecurities;

            while (stockExchangeSecurities.NextPage != null)
            {
                queryParams[nameof(next_page)] = stockExchangeSecurities.NextPage;
                jsonResponse = await GetAsync($"{string.Format(RestApiUrls.Exchanges.SecuritiesByExchange, identifier)}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
                stockExchangeSecurities = JsonConvert.DeserializeObject<ApiResponseStockExchangeSecurities>(jsonResponse);

                if (stockExchangeSecurities == null)
                {
                    throw new IntrinioNetException("API Response is Null");
                }

                result.Securities.AddRange(stockExchangeSecurities.Securities);
                result.NextPage = stockExchangeSecurities.NextPage;
            }

            return result;
        }

        public async Task<IEnumerable<Security>> LookupSecurityAsync(string identifier)
        {
            var jsonResponse = await GetAsync($"{RestApiUrls.Securities.Default}/{identifier}").ConfigureAwait(false);
            var security = JsonConvert.DeserializeObject<Security>(jsonResponse);

            if (security == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            return new List<Security>() { security };
        }

        public async Task<IEnumerable<SecuritySummary>> GetSecuritiesByCompanyAsync(string identifier)
        {
            var jsonResponse = await GetAsync($"{RestApiUrls.Securities.Default}/{identifier}").ConfigureAwait(false);
            var securitySummary = JsonConvert.DeserializeObject<SecuritySummary>(jsonResponse);

            if (securitySummary == null)
            {
                throw new IntrinioNetException("API Response is Null");
            }

            return new List<SecuritySummary>() { securitySummary };
        }
    }
}