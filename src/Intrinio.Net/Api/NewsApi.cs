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

        return await GetData(queryParams);
    }

    public async Task<ApiResponseNews> GetNewsByCompanyAsync(string identifier, int? page_size = null, string next_page = null)
    {
        var queryParams = new Dictionary<string, string>
        {
            { nameof(identifier), identifier },
            { nameof(page_size), page_size.ToString() },
            { nameof(next_page), next_page }
        };

        return await GetData(queryParams, identifier);

    }

    private async Task<ApiResponseNews> GetData(Dictionary<string, string> queryParams, string identifier = null)
    {
        var apiResponse = "";

        if (identifier is not null)
        {
            apiResponse = await GetAsync($"{string.Format(RestApiUrls.News.NewsByCompany, identifier)}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
        }
        else
        {
            apiResponse = await GetAsync($"{RestApiUrls.News.AllsNews}{GetQueryParameterString(queryParams)}").ConfigureAwait(false);
        }
       
        var jsonResponse = JsonConvert.DeserializeObject<ApiResponseNews>(apiResponse);

        if (apiResponse == null)
        {
            throw new IntrinioNetException("API Response is Null");
        }

        var news = jsonResponse.News;
        news = _mapper.Map<List<CompanyNews>>(news);

        return new ApiResponseNews(news, jsonResponse.NextPage);
    }



}
