using System.Net.Http;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Client
{
    public interface IIntrinioDependencies
    {
        IntrinioSettings Settings { get; set; }
        IHttpClientFactory HttpClientFactory { get; set; }
        ApiClient ApiClient { get; set; }
        // ExceptionFactory ExceptionFactory { get; set; }
        // Configuration Configuration { get; set; }
    }

    internal class IntrinioDependencies : IIntrinioDependencies
    {
        public IntrinioSettings Settings { get; set; }
        public IHttpClientFactory HttpClientFactory { get; set; }
        public ApiClient ApiClient { get; set; }
        // public ExceptionFactory ExceptionFactory { get; set; }
        // public Configuration Configuration { get; set; }


        public IntrinioDependencies(IntrinioSettings settings, IHttpClientFactory clientFactory)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
            // Configuration = new Configuration {BasePath = settings.ApiBaseUrl};
            // ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
    }
}