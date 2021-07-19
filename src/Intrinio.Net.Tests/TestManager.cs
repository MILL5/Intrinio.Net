using System.Diagnostics.CodeAnalysis;
using System.IO;
using Intrinio.Net.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Pineapple.Common.Preconditions;

namespace Intrinio.Net.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public static class TestManager
    {
        public static ILogger Logger { get; private set; }

        public static IConfiguration Configuration { get; private set; }

        public static IIntrinioClient IntrinioTestClient { get; private set; }

        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .AddJsonFile("appsettings.local.json", true)
                .AddEnvironmentVariables()
                .Build();

            var services = new ServiceCollection();

            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            services.AddLogging(loggingBuilder => loggingBuilder
                .AddConsole()
                .AddDebug()
                .SetMinimumLevel(LogLevel.Debug));

            services.AddSingleton(Configuration);
            services.AddApplication(Configuration);

            var serviceProvider = services.BuildServiceProvider();

            Logger = serviceProvider
                .GetRequiredService<ILoggerFactory>()
                .CreateLogger(nameof(TestManager));

            IntrinioTestClient = serviceProvider.GetService<IIntrinioClient>();
            
            CheckIsNotNull(nameof(IntrinioTestClient), IntrinioTestClient);
        }

        [AssemblyCleanup]
        public static void Cleanup()
        {
            // No clean up needed
        }

        public static void AssertAllPropertiesNotNull<T>(T obj)
        {
            foreach(var prop in obj.GetType().GetProperties())
            {
                var value = prop.GetValue(obj);

                Assert.IsNotNull(value);

                if (value is string)
                {
                    Assert.AreNotEqual(string.Empty, value);
                }
            }
        }
    }
}
