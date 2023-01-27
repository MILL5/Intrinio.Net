using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class DataPointTests
    {
        private const string APPLE_TICKER = "AAPL";
        private const string BAD_TICKER = "CRZYC";
        private const string MARKET_CAP_TAG = "marketcap";

        [TestMethod]
        public async Task GetDataPointNumberSucceedAsync()
        {
            var companiesResponse = await IntrinioTestClient.GetDataPointNumberAsync(APPLE_TICKER, MARKET_CAP_TAG);
            Assert.IsNotNull(companiesResponse);
        }

        [TestMethod]
        public async Task GetDataPointNumberBadTickerAsync()
        {
            try
            {
                _ = await IntrinioTestClient.GetDataPointNumberAsync(BAD_TICKER, MARKET_CAP_TAG);
            }
            catch (IntrinioNetException ie)
            {
                Assert.IsTrue(ie.StatusCode == System.Net.HttpStatusCode.NotFound);
            }
        }
    }
}
