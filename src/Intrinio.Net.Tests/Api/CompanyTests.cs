using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;


namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class CompanyTests
    {
        private const string APPLE_TICKER = "AAPL";
        private const string APPLE_NAME = "Apple Incorporated";
        private const string APPLE_LEI = "HWUPKR0MPOU8FGXBT394";
        private const string APPLE_CIK = "0000320193";
        
        [TestMethod]
        public async Task GetAllCompanySummariesSucceedsAsync()
        {
            var companies = await IntrinioTestClient.GetAllCompanySummariesAsync();
            
            Assert.IsNotNull(companies);
            Assert.IsTrue(companies.Count() > 1);
        }
        
        [TestMethod]
        public async Task GetAllCompanySummariesWithExpansionSucceedsAsync()
        {
            var companies = await IntrinioTestClient.GetAllCompanySummariesAsync(expandAbbreviations: true);
            
            Assert.IsNotNull(companies);
            Assert.IsTrue(companies.Count() > 1);

            var apple = companies
                .First(c => c.Ticker == APPLE_TICKER);

            Assert.IsNotNull(apple);
            Assert.IsTrue(apple.Name == APPLE_NAME);
        }
        
        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        [DataRow(APPLE_CIK)]
        [DataRow(APPLE_LEI)]
        public async Task LookupCompanySucceedsAsync(string identifier)
        {
            var apple = await IntrinioTestClient.LookupCompanyAsync(identifier);
            
            Assert.IsNotNull(apple);
            Assert.IsTrue(apple.Ticker == APPLE_TICKER);
        }
        
        [DataTestMethod]
        [DataRow(APPLE_TICKER)]
        [DataRow(APPLE_CIK)]
        [DataRow(APPLE_LEI)]
        public async Task LookupCompanyWithExpansionSucceedsAsync(string identifier)
        {
            var apple = await IntrinioTestClient.LookupCompanyAsync(identifier, true);
            
            Assert.IsNotNull(apple);
            Assert.IsTrue(apple.Ticker == APPLE_TICKER);
            Assert.IsTrue(apple.Name == APPLE_NAME);
        }
    }
}