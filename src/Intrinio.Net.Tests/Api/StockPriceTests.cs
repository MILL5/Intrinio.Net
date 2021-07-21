using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class StockPriceTests
    {
        private const string APPLE_TICKER = "AAPL";
        private const string USCOMP = "USCOMP";
        private const string JAN_FIRST_01 = "2021-01-01";
        private const string JAN_FIRST_00 = "2020-01-01";

        [TestMethod]
        public async Task GetStockPriceSummariesBySecuritySucceedsAsync()
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(APPLE_TICKER);

            Assert.IsNotNull(stockPriceResponse);
            Assert.IsNotNull(stockPriceResponse.Security);
            Assert.IsNotEmpty(stockPriceResponse.StockPrices);
        }

        [TestMethod]
        public async Task GetStockPriceSummariesPaginationSucceedsAsync()
        {
            var stockPriceResponse1 = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(APPLE_TICKER);

            Assert.IsNotNull(stockPriceResponse1);
            Assert.IsNotNull(stockPriceResponse1.Security);
            Assert.IsNotEmpty(stockPriceResponse1.StockPrices);

            var stockPriceResponse2 = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(APPLE_TICKER, next_page: stockPriceResponse1.NextPage);

            Assert.IsNotNull(stockPriceResponse2);
            Assert.IsNotNull(stockPriceResponse2.Security);
            Assert.IsNotEmpty(stockPriceResponse2.StockPrices);

            Assert.AreEqual(stockPriceResponse1.Security.Ticker, stockPriceResponse2.Security.Ticker);
        }

        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        public async Task GetStockPriceSummariesBySecuritySucceedsAsync(string identifier)
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier);

            Assert.IsNotNull(stockPriceResponse);
            Assert.IsNotNull(stockPriceResponse.Security);
            Assert.IsNotEmpty(stockPriceResponse.StockPrices);
        }

        [DataTestMethod]
        [DataRow(USCOMP)]
        [DataRow("sxg_ozMr9y")] // USCOMP intrinio internal id
        public async Task GetStockPricesByExchangeSucceedsAsync(string identifier)
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPricesByExchangeAsync(identifier);

            Assert.IsNotNull(stockPriceResponse);
            AssertAllPropertiesNotNull(stockPriceResponse.StockPrices.First());
        }

        [TestMethod]
        public async Task GetStockPricesByExchangePaginationSucceedsAsync()
        {
            var stockPriceResponse1 = await IntrinioTestClient.GetStockPricesByExchangeAsync(USCOMP);

            Assert.IsNotNull(stockPriceResponse1);
            AssertAllPropertiesNotNull(stockPriceResponse1.StockPrices.First());

            var stockPriceResponse2 = await IntrinioTestClient.GetStockPricesByExchangeAsync(USCOMP, next_page: stockPriceResponse1.NextPage);

            Assert.IsNotNull(stockPriceResponse2);
            AssertAllPropertiesNotNull(stockPriceResponse2.StockPrices.First());

            Assert.AreEqual(stockPriceResponse1.StockExchange, stockPriceResponse1.StockExchange);
        }

        [DataTestMethod]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01)]
        public async Task GetStockPriceSummariesBySecurityDateRangeSucceedsAsync(string start, string end)
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier: APPLE_TICKER, start_date: start, end_date: end);

            Assert.IsNotNull(stockPriceResponse);
            Assert.IsNotNull(stockPriceResponse.Security);
            Assert.IsNotNull(stockPriceResponse.StockPrices);
            Assert.IsNotEmpty(stockPriceResponse.StockPrices);
        }

        [DataTestMethod]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.PeriodFrequency.Daily)]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.PeriodFrequency.Weekly)]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.PeriodFrequency.Monthly)]
        public async Task GetStockPriceSummariesBySecurityDateRangeWithFreqSucceedsAsync(string start, string end, StockPriceSummary.PeriodFrequency freq)
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier: APPLE_TICKER, start_date: start, end_date: end, frequency: freq);

            Assert.IsNotNull(stockPriceResponse);
            Assert.IsNotNull(stockPriceResponse.Security);
            Assert.IsNotNull(stockPriceResponse.StockPrices);
            Assert.IsNotEmpty(stockPriceResponse.StockPrices);
        }

        [DataTestMethod]
        [DataRow(USCOMP, JAN_FIRST_01)]
        public async Task GetStockPricesByExchangeWithDateSucceedsAsync(string identifier, string date)
        {
            var stockPriceResponse = await IntrinioTestClient.GetStockPricesByExchangeAsync(identifier, date: date);

            Assert.IsNotNull(stockPriceResponse);
            AssertAllPropertiesNotNull(stockPriceResponse.StockPrices.First());
        }
    }
}