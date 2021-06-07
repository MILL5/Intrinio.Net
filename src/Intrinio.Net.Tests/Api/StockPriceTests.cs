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

        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        public async Task GetStockPricesBySecuritySucceedsAsync(string identifier)
        {
            var result = await IntrinioTestClient.GetStockPricesBySecurityAsync(identifier);
            
            Assert.IsNotNull(result);
            AssertAllPropertiesNotNull(result.First());
        }
        
        [DataTestMethod]
        [DataRow(USCOMP)]
        public async Task GetStockPricesByExchangeSucceedsAsync(string identifier)
        {
            var result = await IntrinioTestClient.GetStockPricesByExchangeAsync(identifier);
            
            Assert.IsNotNull(result);
            AssertAllPropertiesNotNull(result.First());
        }
    }
}