using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Newtonsoft.Json;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Api;
public partial class IntrinioClient
{
    public async Task<ApiResponseNews> GetNewsAsync(int? page_size = null, string next_page = null)
    {
        var queryParams = new Dictionary<string, string>
        {
            { nameof(page_size), page_size.ToString() },
            { nameof(next_page), next_page }
        };

        var apiResponse = await GetAsync($"{RestApiUrls.News.Default}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
        var jsonResponse = JsonConvert.DeserializeObject<ApiResponseNews>(apiResponse);

        if (apiResponse == null)
        {
            throw new IntrinioNetException("API Response is Null");
        }

        var news = jsonResponse.News;
        news     = _mapper.Map<List<CompanyNews>>(news);

        return new ApiResponseNews(news, jsonResponse.NextPage);
    }
}
