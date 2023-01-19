using System.Net.Http;
using AutoMapper;
using Microsoft.Extensions.Logging;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net;

public interface IIntrinioDependencies
{
    IntrinioSettings Settings { get; set; }
    IHttpClientFactory HttpClientFactory { get; set; }
    IMapper Mapper { get; set; }
    ILogger Logger { get; set; }
}

internal class IntrinioDependencies : IIntrinioDependencies
{
    public IntrinioSettings Settings { get; set; }
    public IHttpClientFactory HttpClientFactory { get; set; }
    public IMapper Mapper { get; set; }
    public ILogger Logger { get; set; }

    public IntrinioDependencies(
        IntrinioSettings settings,
        IHttpClientFactory clientFactory,
        IMapper mapper,
        ILogger<IntrinioDependencies> logger)
    {
        CheckIsNotNull(nameof(settings), settings);
        CheckIsNotNull(nameof(clientFactory), clientFactory);

        Settings = settings;
        HttpClientFactory = clientFactory;
        Mapper = mapper;
        Logger = logger;
    }
}
