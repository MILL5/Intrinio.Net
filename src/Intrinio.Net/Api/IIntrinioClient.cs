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

        Task<IEnumerable<Company>> GetAllCompaniesAsync(
            DateTime? latestFilingDate = null,
            string sic = null,
            string template = null,
            string sector = null,
            string industryCategory = null,
            string industryGroup = null,
            bool? hasFundamentals = null,
            bool? hasStockPrices = null,
            int? pageSize = null,
            string nextPage = null,
            bool expandAbbreviations = false);
    }
}