using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intrinio.Net.Model;

namespace Intrinio.Net.Api
{
    public interface IIntrinioClient
    {
        Task<string> GetAsync(string requestUrl);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S107:Methods should not have too many parameters", Justification = "API params")]
        Task<ApiResponseCompanies> GetAllCompanySummariesAsync(
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

        Task<ApiResponseStockExchangeStockPrices> GetStockPricesByExchangeAsync(
            string identifier,
            StockPriceSummary.PeriodFrequency? frequency = null,
            int? page_size = null,
            string date = null,
            string next_page = null);

        Task<ApiResponseSecurityStockPrices> GetStockPriceSummariesBySecurityAsync(
            string identifier,
            StockPriceSummary.PeriodFrequency? frequency = null,
            int? page_size = null,
            string start_date = null,
            string end_date = null,
            string next_page = null);

        Task<Security> LookupSecurityAsync(string identifier);

        Task<ApiResponseStockExchangeSecurities> GetAllSecuritySummariesByExchangeAsync(
            string identifier,
            int? page_size = null,
            string next_page = null);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S107:Methods should not have too many parameters", Justification = "API params")]
        Task<ApiResponseSecurities> GetAllSecuritySummariesAsync(
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

        Task<ApiResponseStockExchanges> GetAllExchangesAsync(
            string city = null,
            string country = null,
            string country_code = null,
            int? page_size = null);

        Task<StockExchange> LookupExchangeAsync(string identifier);

        Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockPriceAdjustmentsByExchangeAsync(
            string identifier,
            string date,
            int? page_size = null,
            string next_page = null);

        Task<IEnumerable<SecurityType>> GetSecurityTypesAsync(string url = RestApiUrls.SECURITY_CODES_URL);

        Task<decimal?> GetDataPointNumberAsync(string identifier, string tag);

        Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancials(string id);

        Task<ApiResponseNews> GetNewsAsync(int? page_size = null, string next_page = null);

        Task<ApiResponseNews> GetNewsByCompanyAsync(string indentifier, int? page_size = null, string next_page = null);

        Task<ApiResponseDataTags> GetAllDataTagsAsync(
            string tag = null,
            string type = null,
            string parent = null,
            string statement_code = null,
            string fs_template = null,
            int? page_size = null,
            string next_page = null);

        Task<ApiResponseDataTags> SearchDataTagsAsync(
            string query = null,
            int? page_size = null);

        Task<DataTag> LookupDataTagAsync(string identifier);
    }
}
