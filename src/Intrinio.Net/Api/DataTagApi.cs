using System.Collections.Generic;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api;
public partial class IntrinioClient
{
    public async Task<ApiResponseDataTags> GetAllDataTagsAsync(
            string tag = null,
            string type = null,
            string parent = null,
            string statement_code = null,
            string fs_template = null,
            int? page_size = null,
            string next_page = null)
    {

        var queryParams = new Dictionary<string, string>
             {
                  { nameof(tag), tag },
                  { nameof(type), type },
                  { nameof(parent), parent },
                  { nameof(statement_code), statement_code },
                  { nameof(fs_template), fs_template },
                  { nameof(page_size), page_size.ToString() },
                  { nameof(next_page), next_page }
             };

        var jsonResponse = await GetAsync($"{RestApiUrls.DataTags.Default}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
        var apiResponse = JsonConvert.DeserializeObject<ApiResponseDataTags>(jsonResponse);

        if (apiResponse == null)
        {
            throw new IntrinioNetException("API Response is Null");
        }

        return apiResponse;
    }

    public async Task<ApiResponseDataTags> SearchDataTagsAsync(
            string query = null,
            int? page_size = null)
    {

        var queryParams = new Dictionary<string, string>
             {
                  { nameof(query), query },
                  { nameof(page_size), page_size.ToString() }
             };

        var jsonResponse = await GetAsync($"{RestApiUrls.DataTags.Search}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
        var apiResponse = JsonConvert.DeserializeObject<ApiResponseDataTags>(jsonResponse);

        if (apiResponse == null)
        {
            throw new IntrinioNetException("API Response is Null");
        }

        return apiResponse;
    }

    public async Task<DataTag> LookupDataTagAsync(string identifier)
    {
        CheckIsNotNullOrWhitespace(nameof(identifier), identifier);
        Dependencies.Logger.LogTrace("Lookup dataTag {id}", identifier);

        var requestUrl = string.Format(RestApiUrls.DataTags.Lookup, identifier);

        var jsonResponse = await GetAsync(requestUrl).ConfigureAwait(false);
        var dataTag = JsonConvert.DeserializeObject<DataTag>(jsonResponse);

        return dataTag;
    }
}
