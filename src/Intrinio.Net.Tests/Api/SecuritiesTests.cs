using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
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
            var securities = await IntrinioTestClient.GetAllSecuritySummariesAsync();
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Count() > 1);
        }

        [TestMethod]
        public async Task GetSecuritiesByCompanySucceedsAsync()
        {
            var securities = await IntrinioTestClient.GetSecuritiesByCompanyAsync((APPLE_TICKER));
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }

        [TestMethod]
        public async Task GetAllSecuritySummariesByExchangeSucceedsAsync()
        {
            {
                var result = await IntrinioTestClient.GetAllSecuritySummariesByExchangeAsync(USCOMP);
            
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.Securities);
                Assert.IsNotNull(result.StockExchange);
                Assert.IsTrue(result.Securities.Count > 1);
            }
        }

        [TestMethod]
        public async Task LookupSecuritySuceedsAsync()
        {
            var securities = await IntrinioTestClient.LookupSecurityAsync(APPLE_TICKER);
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }

        [DataTestMethod]
        [DataRow(true, null)]
        [DataRow(null, true)]
        public async Task GetAllSecuritySummariesWithActiveStatusParamsSucceedsAsync(bool active, bool delisted)
        {
            var securities = await IntrinioTestClient.GetAllSecuritySummariesAsync(active, delisted);
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }
        
        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        public async Task GetAllSecuritySummariesWithTickerParamsSucceedsAsync(string ticker)
        {
            var securities = await IntrinioTestClient.GetAllSecuritySummariesAsync(ticker: ticker);
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }
        
        [DataTestMethod]
        [DataRow(XNAS)]
        public async Task GetAllSecuritySummariesWithMicParamsSucceedsAsync(string mic)
        {
            var securities = await IntrinioTestClient.GetAllSecuritySummariesAsync(exchange_mic: mic);
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }
    }
}