using AutoMapper;
using M5.FinancialDataSanitizer;
using System.Net.Http;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net
{
    public interface IIntrinioDependencies
    {
        IntrinioSettings Settings { get; }
        IHttpClientFactory HttpClientFactory { get; }
        AbbreviationParser AbbreviationParser { get; }
        IMapper Mapper { get; }
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