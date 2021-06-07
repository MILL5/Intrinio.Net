using Intrinio.Net.Client;
using Intrinio.Net.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using M5.FinancialDataSanitizer;
using Newtonsoft.Json;


namespace Intrinio.Net.Api
{
     public partial class IntrinioClient
    {
         public async Task<IEnumerable<CompanySummary>> GetAllCompaniesAsync (
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
             bool expandAbbreviations = false)
        {
             var queryParams = new Dictionary<string, string>
             {
                  { nameof(latestFilingDate), latestFilingDate?.ToString() },
                  { nameof(sic), sic },
                  { nameof(template), template },
                  { nameof(sector), sector },
                  { nameof(industryCategory), industryCategory },
                  { nameof(industryGroup), industryGroup },
                  { nameof(hasFundamentals), hasFundamentals?.ToString() },
                  { nameof(hasStockPrices), hasStockPrices?.ToString() },
                  { nameof(pageSize), pageSize.ToString() },
                  { nameof(next_page), next_page }
             };

             var result = new List<CompanySummary>();
             
             var jsonResponse = await Get($"{allCompaniesBaseUrl}{GetQueryParameterString(queryParams)}");
             var apiResponse = JsonConvert.DeserializeObject<ApiResponseCompanies>(jsonResponse);
             
             if (apiResponse == null)
             {
                  throw new Exception("API Response is Null");
             }
             
             var companies = apiResponse.Companies;

             if (expandAbbreviations)
             {
                  companies = Mapper.Map<List<CompanySummary>>(companies);
             }

             result.AddRange(companies);

             while (apiResponse.NextPage != null)
             {
                  queryParams[nameof(next_page)] = apiResponse.NextPage;
                  jsonResponse = await Get($"{allCompaniesBaseUrl}{GetQueryParameterString(queryParams)}");
                  apiResponse = JsonConvert.DeserializeObject<ApiResponseCompanies>(jsonResponse);
                  if (apiResponse == null)
                  {
                       throw new Exception("API Response is Null");
                  }
                  companies = apiResponse.Companies;
                  result.AddRange(companies);
             }
             
             return result;
        }
         
         public async Task<Company> GetCompanyAsync (string identifier, bool expandAbbreviations = false)
         {
              var jsonResponse = await Get(String.Format(lookupCompanyBaseUrl, identifier));
              var company = JsonConvert.DeserializeObject<Company>(jsonResponse);
             
              if (!expandAbbreviations) return company;

              company = Mapper.Map<Company>(company);

              return company;

         }

        // public async System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (int? pageSize = null, string nextPage = null)
        // {
        //      ApiResponse<ApiResponseNews> localVarResponse = await GetAllCompanyNewsAsyncWithHttpInfo(pageSize, nextPage);
        //      return localVarResponse.Data;
        //
        // }
        //
        
        //
        // public async System.Threading.Tasks.Task<decimal?> GetCompanyDataPointNumberAsync (string identifier, string tag)
        // {
        //      ApiResponse<decimal?> localVarResponse = await GetCompanyDataPointNumberAsyncWithHttpInfo(identifier, tag);
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<string> GetCompanyDataPointTextAsync (string identifier, string tag)
        // {
        //      ApiResponse<string> localVarResponse = await GetCompanyDataPointTextAsyncWithHttpInfo(identifier, tag);
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        // {
        //      ApiResponse<ApiResponseCompanyFilings> localVarResponse = await GetCompanyFilingsAsyncWithHttpInfo(identifier, reportType, startDate, endDate, pageSize, nextPage);
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        // {
        //      ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = await GetCompanyFundamentalsAsyncWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        // {
        //      ApiResponse<ApiResponseCompanyHistoricalData> localVarResponse = await GetCompanyHistoricalDataAsyncWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
        //      
        //      if (!expandAbbreviations) return localVarResponse.Data;
        //
        //      localVarResponse.Data.Company.Name = _parser.ExpandAllAbbreviationsFromString(localVarResponse.Data.Company.Name);
        //
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseInitialPublicOfferings> GetCompanyIposAsync (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null, bool expandAbbreviations = false)
        // {
        //      ApiResponse<ApiResponseInitialPublicOfferings> localVarResponse = await GetCompanyIposAsyncWithHttpInfo(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
        //      
        //      if (!expandAbbreviations) return localVarResponse.Data;
        //      
        //      foreach (var ipo in localVarResponse.Data.InitialPublicOfferings)
        //      {
        //          ipo.Company.Name =
        //              _parser.ExpandAllAbbreviationsFromString(ipo.Company.Name);
        //      }
        //
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, int? pageSize = null, string nextPage = null)
        // {
        //      ApiResponse<ApiResponseCompanyNews> localVarResponse = await GetCompanyNewsAsyncWithHttpInfo(identifier, pageSize, nextPage);
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompanySecurities> GetCompanySecuritiesAsync (string identifier, string nextPage = null, bool expandAbbreviations = false)
        // {
        //      ApiResponse<ApiResponseCompanySecurities> localVarResponse = await GetCompanySecuritiesAsyncWithHttpInfo(identifier, nextPage);
        //      if (!expandAbbreviations) return localVarResponse.Data;
        //
        //      foreach (var security in localVarResponse.Data.Securities)
        //      {
        //          security.Name = _parser.ExpandAbbreviation(security.Name);
        //      }
        //
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<Fundamental> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear, bool expandAbbreviations = false)
        // {
        //      ApiResponse<Fundamental> localVarResponse = await LookupCompanyFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
        //      if (!expandAbbreviations) return localVarResponse.Data;
        //
        //      localVarResponse.Data.Company.Name =
        //          _parser.ExpandAllAbbreviationsFromString(localVarResponse.Data.Company.Name);
        //
        //      return localVarResponse.Data;
        //
        // }
        //
        // public async System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, bool? active = null, int? pageSize = null, bool expandAbbreviations = false)
        // {
        //      ApiResponse<ApiResponseCompaniesSearch> localVarResponse = await SearchCompaniesAsyncWithHttpInfo(query, active, pageSize);
        //      if (!expandAbbreviations) return localVarResponse.Data;
        //
        //      foreach (var company in localVarResponse.Data.Companies)
        //      {
        //          company.Name =
        //              _parser.ExpandAllAbbreviationsFromString(company.Name);
        //      }
        //
        //      return localVarResponse.Data;
        // }
    }
}