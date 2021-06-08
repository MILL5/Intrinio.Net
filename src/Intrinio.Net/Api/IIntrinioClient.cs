using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Intrinio.Net.Client;
using Intrinio.Net.Model;

namespace Intrinio.Net.Api
{
    public interface IIntrinioClient
    {
        IIntrinioDependencies Dependencies { get; }
        HttpClient Client { get; }

        string GetQueryParameterString(Dictionary<string, string> queryParams);

        Task<string> Get(string requestUrl);

        string FormatDateString(string inputDateString);

        Task<IEnumerable<CompanySummary>> GetAllCompaniesAsync(
            DateTime? latestFilingDate = null,
            string sic = null,
            string template = null,
            string sector = null,
            string industryCategory = null,
            string industryGroup = null,
            bool? hasFundamentals = null,
            bool? hasStockPrices = null,
            int? pageSize = null,
            string next_page = null,
            bool expandAbbreviations = false);

        Task<Company> GetCompanyAsync(string identifier, bool expandAbbreviations = false);

        Task<IEnumerable<StockPrice>> GetStockPricesByExchangeAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
            int? page_size = null,
            string date = null,
            string next_page = null);

        Task<IEnumerable<StockPriceSummary>> GetStockPricesBySecurityAsync(
            string identifier,
            StockPriceSummary.FrequencyEnum? frequency = null,
            int? page_size = null,
            string start_date = null,
            string end_date = null,
            string next_page = null);

        Task<IEnumerable<SecuritySummary>> LookupSecurityAsync(string identifier);

        Task<IEnumerable<SecuritySummary>> GetAllSecuritiesByExchangeAsync(
            string identifier,
            int? page_size = null,
            string next_page = null);

        Task<IEnumerable<SecuritySummary>> GetAllSecuritiesAsync(
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

        Task<IEnumerable<StockExchange>> GetAllExchangesAsync(
            string city = null,
            string country = null,
            string country_code = null,
            int? page_size = null);

        Task<StockExchange> LookupExchangeAsync(string identifier);

    }
}