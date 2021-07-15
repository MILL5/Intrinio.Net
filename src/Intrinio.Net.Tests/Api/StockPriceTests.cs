using System;
using System.Linq;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        public async Task GetStockPriceSummariesBySecuritySucceedsAsync(string identifier)
        {
            var result = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier);
            
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Security);
            Assert.IsNotNull(result.StockPrices);
            Assert.IsTrue(result.StockPrices.Count > 1);

        }
        
        [DataTestMethod]
        [DataRow(USCOMP)]
        [DataRow("sxg_2gB0zb")]
        public async Task GetStockPricesByExchangeSucceedsAsync(string identifier)
        {
            var result = await IntrinioTestClient.GetStockPricesByExchangeAsync(identifier);
            
            Assert.IsNotNull(result);
            AssertAllPropertiesNotNull(result.First());
        }

        [DataTestMethod]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01)]

        public async Task GetStockPriceSummariesBySecurityDateRangeSucceedsAsync(string start, string end)
        {
            var result = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier: APPLE_TICKER, start_date: start, end_date: end);
            
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Security);
            Assert.IsNotNull(result.StockPrices);
            Assert.IsTrue(result.StockPrices.Count > 1);
        }
        
        [DataTestMethod]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.FrequencyEnum.Daily)]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.FrequencyEnum.Weekly)]
        [DataRow(JAN_FIRST_00, JAN_FIRST_01, StockPriceSummary.FrequencyEnum.Monthly)]
        public async Task GetStockPriceSummariesBySecurityDateRangeWithFreqSucceedsAsync(string start, string end, StockPriceSummary.FrequencyEnum freq)
        {
            var result = await IntrinioTestClient.GetStockPriceSummariesBySecurityAsync(identifier: APPLE_TICKER, start_date: start, end_date: end, frequency: freq);
            
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Security);
            Assert.IsNotNull(result.StockPrices);
            Assert.IsTrue(result.StockPrices.Count > 1);
        }
        
        [DataTestMethod]
        [DataRow(USCOMP, JAN_FIRST_01)]
        public async Task GetStockPricesByExchangeWithDateSucceedsAsync(string identifier, string date)
        {
            var result = await IntrinioTestClient.GetStockPricesByExchangeAsync(identifier, date: date);
            
            Assert.IsNotNull(result);
            AssertAllPropertiesNotNull(result.First());
        }
    }
}