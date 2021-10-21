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
        private const string DATE = "2021-10-21";

        [TestMethod]
        public async Task GetStockPriceAdjustmentsByExchangeAsync()
        {
            var stockPriceAdjustmentResponse = await IntrinioTestClient.GetStockPriceAdjustmentsByExchangeAsync(USCOMP, DATE);

            Assert.IsNotNull(stockPriceAdjustmentResponse);
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.Any());
            Assert.IsNotNull(stockPriceAdjustmentResponse.StockPriceAdjustments.FirstOrDefault().Security);
        }
    }
}