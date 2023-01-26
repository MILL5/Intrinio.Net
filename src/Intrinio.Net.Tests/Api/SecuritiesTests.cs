using System.Linq;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class SecuritiesTests
    {
        private const string APPLE_TICKER = "AAPL";
        private const string USCOMP = "USCOMP";
        private const string XNAS = "XNAS";

        [TestMethod]
        public async Task GetAllSecuritySummariesSucceedsAsync()
        {
            var securitiesResposne = await IntrinioTestClient.GetAllSecuritySummariesAsync(page_size: 5000);

            Assert.IsNotNull(securitiesResposne);
            Assert.IsTrue(securitiesResposne.Securities.Count == 5000);
        }

        [TestMethod]
        public async Task GetAllSecuritySummariesPaginationSucceedsAsync()
        {
            var securitiesResposne1 = await IntrinioTestClient.GetAllSecuritySummariesAsync(page_size: 100);

            Assert.IsNotNull(securitiesResposne1);
            Assert.IsTrue(securitiesResposne1.Securities.Count == 100);

            var securitiesResposne2 = await IntrinioTestClient.GetAllSecuritySummariesAsync(page_size: 100, next_page: securitiesResposne1.NextPage);

            Assert.IsNotNull(securitiesResposne2);
            Assert.IsTrue(securitiesResposne2.Securities.Count == 100);

            Assert.AreNotEqual(securitiesResposne1.Securities.First().Ticker, securitiesResposne2.Securities.First().Ticker);
        }

        [TestMethod]
        public async Task GetSecuritiesByCompanySucceedsAsync()
        {
            var sercurities = await IntrinioTestClient.GetSecuritiesByCompanyAsync(APPLE_TICKER);

            Assert.IsNotNull(sercurities);
            Assert.IsNotEmpty(sercurities);
        }

        [TestMethod]
        public async Task GetAllSecuritySummariesByExchangeSucceedsAsync()
        {
            var exchSecResponse = await IntrinioTestClient.GetAllSecuritySummariesByExchangeAsync(USCOMP);

            Assert.IsNotNull(exchSecResponse);
            Assert.IsNotEmpty(exchSecResponse.Securities);
            Assert.IsNotNull(exchSecResponse.StockExchange);
        }

        [TestMethod]
        public async Task GetAllSecuritySummariesByExchangePaginationSucceedsAsync()
        {
            var reexchSecResponsesult1 = await IntrinioTestClient.GetAllSecuritySummariesByExchangeAsync(USCOMP);

            Assert.IsNotNull(reexchSecResponsesult1);
            Assert.IsNotEmpty(reexchSecResponsesult1.Securities);
            Assert.IsNotNull(reexchSecResponsesult1.StockExchange);

            var reexchSecResponsesult2 = await IntrinioTestClient.GetAllSecuritySummariesByExchangeAsync(USCOMP, next_page: reexchSecResponsesult1.NextPage);

            Assert.IsNotNull(reexchSecResponsesult2);
            Assert.IsNotEmpty(reexchSecResponsesult2.Securities);
            Assert.IsNotNull(reexchSecResponsesult2.StockExchange);

            Assert.AreNotEqual(reexchSecResponsesult1.Securities.First().Ticker, reexchSecResponsesult2.Securities.First().Ticker);
        }

        [TestMethod]
        public async Task LookupSecuritySuceedsAsync()
        {
            var securities = await IntrinioTestClient.LookupSecurityAsync(APPLE_TICKER);

            Assert.IsNotNull(securities);
        }

        [DataTestMethod]
        [DataRow(true, null)]
        [DataRow(null, true)]
        public async Task GetAllSecuritySummariesWithActiveStatusParamsSucceedsAsync(bool active, bool delisted)
        {
            var securitiesResponse = await IntrinioTestClient.GetAllSecuritySummariesAsync(active, delisted);

            Assert.IsNotNull(securitiesResponse);
            Assert.IsNotEmpty(securitiesResponse.Securities);
        }

        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        public async Task GetAllSecuritySummariesWithTickerParamsSucceedsAsync(string ticker)
        {
            var securitiesResponse = await IntrinioTestClient.GetAllSecuritySummariesAsync(ticker: ticker);

            Assert.IsNotNull(securitiesResponse);
            Assert.IsNotEmpty(securitiesResponse.Securities);
        }

        [DataTestMethod]
        [DataRow(XNAS)]
        public async Task GetAllSecuritySummariesWithMicParamsSucceedsAsync(string mic)
        {
            var securitiesResponse = await IntrinioTestClient.GetAllSecuritySummariesAsync(exchange_mic: mic);

            Assert.IsNotNull(securitiesResponse);
            Assert.IsNotEmpty(securitiesResponse.Securities);
        }

        [TestMethod]
        public async Task GetSecurityTypesSuceedsAsync()
        {
            var securities = await IntrinioTestClient.GetSecurityTypesAsync();

            Assert.IsNotNull(securities);
            Assert.IsNotEmpty(securities);
            Assert.GreaterOrEqual(securities.Count(), 60);

            var eqsType = new SecurityType() { Code = "EQS", Name = "Equity Shares" };
            Assert.Contains(eqsType, securities.ToList());
        }
    }
}
