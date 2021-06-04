using Intrinio.Net.Client;
using Intrinio.Net.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using M5.FinancialDataSanitizer;


namespace Intrinio.Net.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    // public interface ICompanyApi : IApiAccessor
    // {
    //     #region Synchronous Operations
    //     /// <summary>
    //     /// All Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Companies. When parameters are specified, returns matching companies.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
    //     /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
    //     /// <param name="template">Return companies with the given financial statement template (optional)</param>
    //     /// <param name="sector">Return companies in the given industry sector (optional)</param>
    //     /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
    //     /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
    //     /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
    //     /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanies</returns>
    //     ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Companies. When parameters are specified, returns matching companies.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
    //     /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
    //     /// <param name="template">Return companies with the given financial statement template (optional)</param>
    //     /// <param name="sector">Return companies in the given industry sector (optional)</param>
    //     /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
    //     /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
    //     /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
    //     /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanies</returns>
    //     ApiResponse<ApiResponseCompanies> GetAllCompaniesWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// All News
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all News for all Companies
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseNews</returns>
    //     ApiResponseNews GetAllCompanyNews (int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All News
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all News for all Companies
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseNews</returns>
    //     ApiResponse<ApiResponseNews> GetAllCompanyNewsWithHttpInfo (int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// Lookup Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <returns>Company</returns>
    //     Company GetCompany (string identifier, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Lookup Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <returns>ApiResponse of Company</returns>
    //     ApiResponse<Company> GetCompanyWithHttpInfo (string identifier, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Data Point (Number) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>decimal?</returns>
    //     decimal? GetCompanyDataPointNumber (string identifier, string tag);
    //
    //     /// <summary>
    //     /// Data Point (Number) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>ApiResponse of decimal?</returns>
    //     ApiResponse<decimal?> GetCompanyDataPointNumberWithHttpInfo (string identifier, string tag);
    //     /// <summary>
    //     /// Data Point (Text) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>string</returns>
    //     string GetCompanyDataPointText (string identifier, string tag);
    //
    //     /// <summary>
    //     /// Data Point (Text) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>ApiResponse of string</returns>
    //     ApiResponse<string> GetCompanyDataPointTextWithHttpInfo (string identifier, string tag);
    //     /// <summary>
    //     /// All Filings by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
    //     /// <param name="startDate">Filed on or after the given date (optional)</param>
    //     /// <param name="endDate">Filed before or after the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanyFilings</returns>
    //     ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All Filings by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
    //     /// <param name="startDate">Filed on or after the given date (optional)</param>
    //     /// <param name="endDate">Filed before or after the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanyFilings</returns>
    //     ApiResponse<ApiResponseCompanyFilings> GetCompanyFilingsWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// All Fundamentals by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="filedAfter">Filed on or after this date (optional)</param>
    //     /// <param name="filedBefore">Filed on or before this date (optional)</param>
    //     /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
    //     /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
    //     /// <param name="statementCode">Only of the given statement code (optional)</param>
    //     /// <param name="type">Only of the given type (optional)</param>
    //     /// <param name="startDate">Only on or after the given date (optional)</param>
    //     /// <param name="endDate">Only on or before the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanyFundamentals</returns>
    //     ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Fundamentals by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="filedAfter">Filed on or after this date (optional)</param>
    //     /// <param name="filedBefore">Filed on or before this date (optional)</param>
    //     /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
    //     /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
    //     /// <param name="statementCode">Only of the given statement code (optional)</param>
    //     /// <param name="type">Only of the given type (optional)</param>
    //     /// <param name="startDate">Only on or after the given date (optional)</param>
    //     /// <param name="endDate">Only on or before the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanyFundamentals</returns>
    //     ApiResponse<ApiResponseCompanyFundamentals> GetCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Historical Data for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
    //     /// <param name="type">Return historical data for given fiscal period type (optional)</param>
    //     /// <param name="startDate">Return historical data on or after this date (optional)</param>
    //     /// <param name="endDate">Return historical data on or before this date (optional)</param>
    //     /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanyHistoricalData</returns>
    //     ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Historical Data for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
    //     /// <param name="type">Return historical data for given fiscal period type (optional)</param>
    //     /// <param name="startDate">Return historical data on or after this date (optional)</param>
    //     /// <param name="endDate">Return historical data on or before this date (optional)</param>
    //     /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanyHistoricalData</returns>
    //     ApiResponse<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// IPOs
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns initial public offerings (IPOs). An IPO is a public offering of private company stock. The act of \&quot;going public\&quot; is initiated by an IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ). Intrinio covers all upcoming and recent IPOs for US exchanges.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
    //     /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
    //     /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
    //     /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
    //     /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
    //     /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseInitialPublicOfferings</returns>
    //     ApiResponseInitialPublicOfferings GetCompanyIpos (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// IPOs
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns initial public offerings (IPOs). An IPO is a public offering of private company stock. The act of \&quot;going public\&quot; is initiated by an IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ). Intrinio covers all upcoming and recent IPOs for US exchanges.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
    //     /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
    //     /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
    //     /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
    //     /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
    //     /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseInitialPublicOfferings</returns>
    //     ApiResponse<ApiResponseInitialPublicOfferings> GetCompanyIposWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// All News by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns news for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanyNews</returns>
    //     ApiResponseCompanyNews GetCompanyNews (string identifier, int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All News by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns news for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanyNews</returns>
    //     ApiResponse<ApiResponseCompanyNews> GetCompanyNewsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// All Securities by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns Securities for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponseCompanySecurities</returns>
    //     ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Securities by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns Securities for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>ApiResponse of ApiResponseCompanySecurities</returns>
    //     ApiResponse<ApiResponseCompanySecurities> GetCompanySecuritiesWithHttpInfo (string identifier, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Lookup Fundamental by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="statementCode">The statement code</param>
    //     /// <param name="fiscalPeriod">The fiscal period</param>
    //     /// <param name="fiscalYear">The fiscal year</param>
    //     /// <returns>Fundamental</returns>
    //     Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Lookup Fundamental by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="statementCode">The statement code</param>
    //     /// <param name="fiscalPeriod">The fiscal period</param>
    //     /// <param name="fiscalYear">The fiscal year</param>
    //     /// <returns>ApiResponse of Fundamental</returns>
    //     ApiResponse<Fundamental> LookupCompanyFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Search Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Searches for Companies matching the text &#x60;query&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="query">Search parameters</param>
    //     /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <returns>ApiResponseCompaniesSearch</returns>
    //     ApiResponseCompaniesSearch SearchCompanies (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Search Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Searches for Companies matching the text &#x60;query&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="query">Search parameters</param>
    //     /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <returns>ApiResponse of ApiResponseCompaniesSearch</returns>
    //     ApiResponse<ApiResponseCompaniesSearch> SearchCompaniesWithHttpInfo (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false);
    //     #endregion Synchronous Operations
    //     #region Asynchronous Operations
    //     /// <summary>
    //     /// All Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Companies. When parameters are specified, returns matching companies.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
    //     /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
    //     /// <param name="template">Return companies with the given financial statement template (optional)</param>
    //     /// <param name="sector">Return companies in the given industry sector (optional)</param>
    //     /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
    //     /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
    //     /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
    //     /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanies</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Companies. When parameters are specified, returns matching companies.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
    //     /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
    //     /// <param name="template">Return companies with the given financial statement template (optional)</param>
    //     /// <param name="sector">Return companies in the given industry sector (optional)</param>
    //     /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
    //     /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
    //     /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
    //     /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanies)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanies>> GetAllCompaniesAsyncWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// All News
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all News for all Companies
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseNews</returns>
    //     System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All News
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all News for all Companies
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseNews)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseNews>> GetAllCompanyNewsAsyncWithHttpInfo (int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// Lookup Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <returns>Task of Company</returns>
    //     System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Lookup Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <returns>Task of ApiResponse (Company)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Data Point (Number) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>Task of decimal?</returns>
    //     System.Threading.Tasks.Task<decimal?> GetCompanyDataPointNumberAsync (string identifier, string tag);
    //
    //     /// <summary>
    //     /// Data Point (Number) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>Task of ApiResponse (decimal?)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<decimal?>> GetCompanyDataPointNumberAsyncWithHttpInfo (string identifier, string tag);
    //     /// <summary>
    //     /// Data Point (Text) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>Task of string</returns>
    //     System.Threading.Tasks.Task<string> GetCompanyDataPointTextAsync (string identifier, string tag);
    //
    //     /// <summary>
    //     /// Data Point (Text) for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <returns>Task of ApiResponse (string)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<string>> GetCompanyDataPointTextAsyncWithHttpInfo (string identifier, string tag);
    //     /// <summary>
    //     /// All Filings by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
    //     /// <param name="startDate">Filed on or after the given date (optional)</param>
    //     /// <param name="endDate">Filed before or after the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanyFilings</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All Filings by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
    //     /// <param name="startDate">Filed on or after the given date (optional)</param>
    //     /// <param name="endDate">Filed before or after the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanyFilings)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFilings>> GetCompanyFilingsAsyncWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// All Fundamentals by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="filedAfter">Filed on or after this date (optional)</param>
    //     /// <param name="filedBefore">Filed on or before this date (optional)</param>
    //     /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
    //     /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
    //     /// <param name="statementCode">Only of the given statement code (optional)</param>
    //     /// <param name="type">Only of the given type (optional)</param>
    //     /// <param name="startDate">Only on or after the given date (optional)</param>
    //     /// <param name="endDate">Only on or before the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanyFundamentals</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Fundamentals by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="filedAfter">Filed on or after this date (optional)</param>
    //     /// <param name="filedBefore">Filed on or before this date (optional)</param>
    //     /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
    //     /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
    //     /// <param name="statementCode">Only of the given statement code (optional)</param>
    //     /// <param name="type">Only of the given type (optional)</param>
    //     /// <param name="startDate">Only on or after the given date (optional)</param>
    //     /// <param name="endDate">Only on or before the given date (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanyFundamentals)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFundamentals>> GetCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Historical Data for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
    //     /// <param name="type">Return historical data for given fiscal period type (optional)</param>
    //     /// <param name="startDate">Return historical data on or after this date (optional)</param>
    //     /// <param name="endDate">Return historical data on or before this date (optional)</param>
    //     /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanyHistoricalData</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Historical Data for Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
    //     /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
    //     /// <param name="type">Return historical data for given fiscal period type (optional)</param>
    //     /// <param name="startDate">Return historical data on or after this date (optional)</param>
    //     /// <param name="endDate">Return historical data on or before this date (optional)</param>
    //     /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanyHistoricalData)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyHistoricalData>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// IPOs
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns initial public offerings (IPOs). An IPO is a public offering of private company stock. The act of \&quot;going public\&quot; is initiated by an IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ). Intrinio covers all upcoming and recent IPOs for US exchanges.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
    //     /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
    //     /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
    //     /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
    //     /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
    //     /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseInitialPublicOfferings</returns>
    //     System.Threading.Tasks.Task<ApiResponseInitialPublicOfferings> GetCompanyIposAsync (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// IPOs
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns initial public offerings (IPOs). An IPO is a public offering of private company stock. The act of \&quot;going public\&quot; is initiated by an IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ). Intrinio covers all upcoming and recent IPOs for US exchanges.
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
    //     /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
    //     /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
    //     /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
    //     /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
    //     /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseInitialPublicOfferings)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseInitialPublicOfferings>> GetCompanyIposAsyncWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// All News by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns news for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanyNews</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, int? pageSize = null, string nextPage = null);
    //
    //     /// <summary>
    //     /// All News by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns news for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanyNews)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNews>> GetCompanyNewsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
    //     /// <summary>
    //     /// All Securities by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns Securities for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponseCompanySecurities</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompanySecurities> GetCompanySecuritiesAsync (string identifier, string nextPage = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// All Securities by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns Securities for the Company with the given &#x60;identifier&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompanySecurities)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySecurities>> GetCompanySecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Lookup Fundamental by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="statementCode">The statement code</param>
    //     /// <param name="fiscalPeriod">The fiscal period</param>
    //     /// <param name="fiscalYear">The fiscal year</param>
    //     /// <returns>Task of Fundamental</returns>
    //     System.Threading.Tasks.Task<Fundamental> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Lookup Fundamental by Company
    //     /// </summary>
    //     /// <remarks>
    //     /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
    //     /// <param name="statementCode">The statement code</param>
    //     /// <param name="fiscalPeriod">The fiscal period</param>
    //     /// <param name="fiscalYear">The fiscal year</param>
    //     /// <returns>Task of ApiResponse (Fundamental)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<Fundamental>> LookupCompanyFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false);
    //     /// <summary>
    //     /// Search Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Searches for Companies matching the text &#x60;query&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="query">Search parameters</param>
    //     /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <returns>Task of ApiResponseCompaniesSearch</returns>
    //     System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false);
    //
    //     /// <summary>
    //     /// Search Companies
    //     /// </summary>
    //     /// <remarks>
    //     /// Searches for Companies matching the text &#x60;query&#x60;
    //     /// </remarks>
    //     /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    //     /// <param name="query">Search parameters</param>
    //     /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. (optional)</param>
    //     /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
    //     /// <returns>Task of ApiResponse (ApiResponseCompaniesSearch)</returns>
    //     System.Threading.Tasks.Task<ApiResponse<ApiResponseCompaniesSearch>> SearchCompaniesAsyncWithHttpInfo (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false);
    //     #endregion Asynchronous Operations
    // }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompanyApi // : ICompanyApi
    {
        private readonly AbbreviationParser _expandString;
        public IIntrinioDependencies Dependencies { get; set; }
        public Configuration Configuration { get; set; }
        public ExceptionFactory ExceptionFactory { get; set; }

        private readonly HttpClient Client;

        public CompanyApi(IIntrinioDependencies dependencies)
        {
            Dependencies = dependencies;
            Configuration = new Configuration {BasePath = dependencies.Settings.ApiBaseUrl};
            ExceptionFactory = Configuration.DefaultExceptionFactory;
            Client = dependencies.HttpClientFactory.CreateClient(dependencies.Settings.HttpClientName);
        }


        public async System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseCompanies> localVarResponse = await GetAllCompaniesAsyncWithHttpInfo(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, pageSize, nextPage);
             if (!expandAbbreviations) return localVarResponse.Data;
             
             foreach (var company in localVarResponse.Data.Companies)
             {
                 company.Name =
                     _expandString.ExpandAllAbbreviationsFromString(company.Name);
             }

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseNews> localVarResponse = await GetAllCompanyNewsAsyncWithHttpInfo(pageSize, nextPage);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier, bool expandAbbreviations = false)
        {
             ApiResponse<Company> localVarResponse = await GetCompanyAsyncWithHttpInfo(identifier);
             
             if (!expandAbbreviations) return localVarResponse.Data;

             localVarResponse.Data.Name = _expandString.ExpandAllAbbreviationsFromString(localVarResponse.Data.Name);

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<decimal?> GetCompanyDataPointNumberAsync (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = await GetCompanyDataPointNumberAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<string> GetCompanyDataPointTextAsync (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = await GetCompanyDataPointTextAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFilings> localVarResponse = await GetCompanyFilingsAsyncWithHttpInfo(identifier, reportType, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = await GetCompanyFundamentalsAsyncWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseCompanyHistoricalData> localVarResponse = await GetCompanyHistoricalDataAsyncWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
             
             if (!expandAbbreviations) return localVarResponse.Data;

             localVarResponse.Data.Company.Name = _expandString.ExpandAllAbbreviationsFromString(localVarResponse.Data.Company.Name);

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseInitialPublicOfferings> GetCompanyIposAsync (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseInitialPublicOfferings> localVarResponse = await GetCompanyIposAsyncWithHttpInfo(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
             
             if (!expandAbbreviations) return localVarResponse.Data;
             
             foreach (var ipo in localVarResponse.Data.InitialPublicOfferings)
             {
                 ipo.Company.Name =
                     _expandString.ExpandAllAbbreviationsFromString(ipo.Company.Name);
             }

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNews> localVarResponse = await GetCompanyNewsAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompanySecurities> GetCompanySecuritiesAsync (string identifier, string nextPage = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseCompanySecurities> localVarResponse = await GetCompanySecuritiesAsyncWithHttpInfo(identifier, nextPage);
             if (!expandAbbreviations) return localVarResponse.Data;

             foreach (var security in localVarResponse.Data.Securities)
             {
                 security.Name = _expandString.ExpandAbbreviation(security.Name);
             }

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<Fundamental> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false)
        {
             ApiResponse<Fundamental> localVarResponse = await LookupCompanyFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             if (!expandAbbreviations) return localVarResponse.Data;

             localVarResponse.Data.Company.Name =
                 _expandString.ExpandAllAbbreviationsFromString(localVarResponse.Data.Company.Name);

             return localVarResponse.Data;

        }

        public async System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false)
        {
             ApiResponse<ApiResponseCompaniesSearch> localVarResponse = await SearchCompaniesAsyncWithHttpInfo(query, active, pageSize);
             if (!expandAbbreviations) return localVarResponse.Data;

             foreach (var company in localVarResponse.Data.Companies)
             {
                 company.Name =
                     _expandString.ExpandAllAbbreviationsFromString(company.Name);
             }

             return localVarResponse.Data;
        }
    }
}