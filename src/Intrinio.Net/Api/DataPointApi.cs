using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api;
public partial class IntrinioClient
{
    public async Task<decimal?> GetDataPointNumberAsync(string identifier, string tag)
    {
        CheckIsNotNullOrWhitespace(nameof(identifier), identifier);
        Dependencies.Logger.LogTrace("Lookup data point {tag} for {identifier}", tag, identifier);

        var requestUrl = string.Format(RestApiUrls.DataPoint.Number, identifier, tag);

        var jsonResponse = await GetAsync(requestUrl).ConfigureAwait(false);
        decimal.TryParse(jsonResponse, out decimal number);              

        return number;
    }
}
