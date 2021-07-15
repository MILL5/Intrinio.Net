using Intrinio.Net.Client;
using Intrinio.Net.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Intrinio.Net.Api
{
    public interface IIntrinioClient
    {
        IIntrinioDependencies Dependencies { get; }
        HttpClient Client { get; }

        string GetQueryParameterString(Dictionary<string, string> queryParams);

        Task<string> Get(string requestUrl);

        string FormatDateString(string inputDateString);

        Task<IEnumerable<CompanySummary>> GetAllCompanySummariesAsync(
            DateTime? latest_filing_date = null,
            string sic = null,
            string template = null,
            string sector = null,
            string industry_category = null,
            string industry_group = null,
            bool? has_fundamentals = null,
            bool? has_stock_prices = null,
            int? page_size = null,
            string next_page = null,
            bool expandAbbreviations = false);

        Task<Company> LookupCompanyAsync(string identifier, bool expandAbbreviations = false);

        Task<IEnumerable<StockPrice>> GetStockPricesByExchangeAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
            int? page_size = null,
            string date = null,
            string next_page = null);

        Task<ApiResponseSecurityStockPrices> GetStockPriceSummariesBySecurityAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
            int? page_size = null,
            string start_date = null,
            string end_date = null,
            string next_page = null);

        Task<IEnumerable<Security>> LookupSecurityAsync(string identifier);

        Task<ApiResponseStockExchangeSecurities> GetAllSecuritySummariesByExchangeAsync(
            string identifier,
            int? page_size = null,
            string next_page = null);

        Task<IEnumerable<SecuritySummary>> GetAllSecuritySummariesAsync(
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
            string next_page = null);

        Task<IEnumerable<SecuritySummary>> GetSecuritiesByCompanyAsync(string identifier);

        Task<IEnumerable<StockExchange>> GetAllExchangesAsync(
            string city = null,
            string country = null,
            string country_code = null,
            int? page_size = null);

        Task<StockExchange> LookupExchangeAsync(string identifier);
    }
}