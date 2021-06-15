using Intrinio.Net.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

             var jsonResponse = await Get($"{allCompaniesBaseUrl}{GetQueryParameterString(queryParams)}")
                  .ConfigureAwait(false);
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
                  jsonResponse = await Get($"{allCompaniesBaseUrl}{GetQueryParameterString(queryParams)}")
                       .ConfigureAwait(false);
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
         
         public async Task<Company> LookupCompanyAsync(string identifier, bool expandAbbreviations = false)
         {
              var jsonResponse = await Get(String.Format(lookupCompanyBaseUrl, identifier))
                   .ConfigureAwait(false);
              var company = JsonConvert.DeserializeObject<Company>(jsonResponse);
             
              if (!expandAbbreviations) return company;

              company = Mapper.Map<Company>(company);

              return company;

         }
    }
}