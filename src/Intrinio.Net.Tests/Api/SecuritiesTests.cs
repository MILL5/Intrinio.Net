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

        [TestMethod]
        public async Task GetAllSecuritiesSucceedsAsync()
        {
            var securities = await IntrinioTestClient.GetAllSecuritiesAsync();
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Count() > 1);
        }

        [TestMethod]
        public async Task GetAllSecuritiesByExchangeSucceedsAsync()
        {
            {
                var securities = await IntrinioTestClient.GetAllSecuritiesByExchangeAsync(USCOMP);
            
                Assert.IsNotNull(securities);
                Assert.IsTrue(securities.Count() > 1);
            }
        }

        [TestMethod]
        public async Task LookupSecuritySuceedsAsync()
        {
            var securities = await IntrinioTestClient.LookupSecurityAsync(APPLE_TICKER);
            
            Assert.IsNotNull(securities);
            Assert.IsTrue(securities.Any());
        }
    }
}