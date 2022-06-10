using System.Net.Http;
using AutoMapper;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net
{
    public interface IIntrinioDependencies
    {
        IntrinioSettings Settings { get; set; }
        IHttpClientFactory HttpClientFactory { get; set; }
        IMapper Mapper { get; set; }
    }

    internal class IntrinioDependencies : IIntrinioDependencies
    {
        public IntrinioSettings Settings { get; set; }
        public IHttpClientFactory HttpClientFactory { get; set; }
        public IMapper Mapper { get; set; }

        public IntrinioDependencies(IntrinioSettings settings, IHttpClientFactory clientFactory, IMapper mapper)
        {
            CheckIsNotNull(nameof(settings), settings);
            CheckIsNotNull(nameof(clientFactory), clientFactory);

            Settings = settings;
            HttpClientFactory = clientFactory;
            Mapper = mapper;
        }
    }
}