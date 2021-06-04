using System.Net.Http;
using M5.FinancialDataSanitizer;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Client
{
    public interface IIntrinioDependencies
    {
        IntrinioSettings Settings { get; }
        IHttpClientFactory HttpClientFactory { get; }
        AbbreviationParser AbbreviationParser { get; }

    }

    internal class SwaggerDateConverter
    {
        
    }

    internal class IntrinioDependencies : IIntrinioDependencies
    {
        public IntrinioSettings Settings { get; }
        public IHttpClientFactory HttpClientFactory { get; }
        public AbbreviationParser AbbreviationParser { get; }


        public IntrinioDependencies(IntrinioSettings settings, IHttpClientFactory clientFactory)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
            AbbreviationParser = new AbbreviationParser();
        }
    }
}