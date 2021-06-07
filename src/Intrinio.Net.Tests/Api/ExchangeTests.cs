using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;


namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class ExchangeTests
    {
        private const string APPLE_TICKER = "AAPL";
        private const string USCOMP = "USCOMP";

        [TestMethod]
        public async Task GetAllExchangesSucceedsAsync()
        {
            var exchanges = await IntrinioTestClient.GetAllExchangesAsync();
            
            Assert.IsNotNull(exchanges);
            Assert.IsTrue(exchanges.Count() > 1);
        }

        [TestMethod]
        public async Task LookupExchangeSucceedsAsync()
        {
            var uscomp = await IntrinioTestClient.LookupExchangeAsync(USCOMP);
            
            Assert.IsNotNull(uscomp);
            Assert.IsTrue(uscomp.Mic == USCOMP);
        }
    }
}