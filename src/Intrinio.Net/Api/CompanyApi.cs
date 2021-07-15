using Intrinio.Net.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intrinio.Net.Api
{
    public partial class IntrinioClient
    {
        public async Task<IEnumerable<CompanySummary>> GetAllCompanySummariesAsync(
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
            bool expandAbbreviations = false)
        {
            var queryParams = new Dictionary<string, string>
             {
                  { nameof(latest_filing_date), latest_filing_date?.ToString() },
                  { nameof(sic), sic },
                  { nameof(template), template },
                  { nameof(sector), sector },
                  { nameof(industry_category), industry_category },
                  { nameof(industry_group), industry_group },
                  { nameof(has_fundamentals), has_fundamentals?.ToString() },
                  { nameof(has_stock_prices), has_stock_prices?.ToString() },
                  { nameof(page_size), page_size.ToString() },
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