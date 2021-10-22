using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class StockPriceAdjustmentsTests
    {
        private const string USCOMP = "USCOMP";
        private const string DATE = "2021-10-18";

        [TestMethod]
        public async Task GetStockPriceAdjustmentsByExchangeAsync()
        {
            var stockPriceAdjustmentResponse = await IntrinioTestClient.GetStockPriceAdjustmentsByExchangeAsync(USCOMP, DATE);

            Assert.IsNotNull(stockPriceAdjustmentResponse);
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.Any());
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.FirstOrDefault().Security);
        }

        [TestMethod]
        public async Task GetStockPriceAdjustmentsByExchangeWithPageAsync()
        {
            var stockPriceAdjustmentResponse = await IntrinioTestClient.GetStockPriceAdjustmentsByExchangeAsync(USCOMP, DATE, 1000);

            Assert.IsNotNull(stockPriceAdjustmentResponse);
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.Any());
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.FirstOrDefault().Security);
        }

        [TestMethod]
        public async Task GetStockPriceAdjustmentsByExchangeWithNextPageAsync()
        {
            var stockPriceAdjustmentResponse = await IntrinioTestClient.GetStockPriceAdjustmentsByExchangeAsync(USCOMP, DATE, 10);

            Assert.IsNotNull(stockPriceAdjustmentResponse);
            Assert.IsNotNull(stockPriceAdjustmentResponse.NextPage);

            stockPriceAdjustmentResponse = await IntrinioTestClient.GetStockPriceAdjustmentsByExchangeAsync(USCOMP, DATE, 10, stockPriceAdjustmentResponse.NextPage);

            Assert.IsNotNull(stockPriceAdjustmentResponse);
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.FirstOrDefault().Security);
        }
    }
}