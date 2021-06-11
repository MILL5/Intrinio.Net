using System.Net.Http;
using AutoMapper;
using M5.FinancialDataSanitizer;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Client
{
    public interface IIntrinioDependencies
    {
        IntrinioSettings Settings { get; }
        IHttpClientFactory HttpClientFactory { get; }
        AbbreviationParser AbbreviationParser { get; }
        IMapper Mapper { get; }

    }

    internal class SwaggerDateConverter
    {
        
    }

    internal class IntrinioDependencies : IIntrinioDependencies
    {
        public IntrinioSettings Settings { get; }
        public IHttpClientFactory HttpClientFactory { get; }
        public AbbreviationParser AbbreviationParser { get; }

        public IMapper Mapper { get; }

        public IntrinioDependencies(IntrinioSettings settings, IHttpClientFactory clientFactory, IMapper mapper)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
            AbbreviationParser = new AbbreviationParser();
            Mapper = mapper;
        }
    }
}