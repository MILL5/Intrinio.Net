using System.Threading.Tasks;
using Intrinio.Net.Model;
using Newtonsoft.Json;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api;

public partial class IntrinioClient
{
    /// <summary>
    /// Standardized Financials
    /// </summary>
    /// <remarks>
    /// Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
    /// Valid options: income_statement, balance_sheet_statement, cash_flow_statement, calculations
    /// </remarks>
    /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
    /// <returns>ApiResponseStandardizedFinancials</returns>

    public async Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancials(string id)
    {
        CheckIsNotNullOrWhitespace(nameof(id), id);

        var requestUrl = string.Format(RestApiUrls.Fundamentals.Standardized, id);
        var jsonResponse = await GetAsync(requestUrl).ConfigureAwait(false);

        return JsonConvert.DeserializeObject<ApiResponseStandardizedFinancials>(jsonResponse);
    }
}
