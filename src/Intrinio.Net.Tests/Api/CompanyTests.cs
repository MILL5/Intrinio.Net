using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
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
            var companiesResponse = await IntrinioTestClient.GetAllCompanySummariesAsync();

            Assert.IsNotNull(companiesResponse);
            Assert.IsNotEmpty(companiesResponse.Companies);
        }

        [TestMethod]
        public async Task GetAllCompanySummariesPaginationSucceedsAsync()
        {
            var companiesResponse1 = await IntrinioTestClient.GetAllCompanySummariesAsync();

            Assert.IsNotNull(companiesResponse1);
            Assert.IsNotEmpty(companiesResponse1.Companies);

            var companiesResponse2 = await IntrinioTestClient.GetAllCompanySummariesAsync(next_page: companiesResponse1.NextPage);

            Assert.IsNotNull(companiesResponse2);
            Assert.IsNotEmpty(companiesResponse2.Companies);

            Assert.AreNotEqual(companiesResponse1.Companies.First().Ticker, companiesResponse2.Companies.First().Ticker);
        }

        [TestMethod]
        public async Task GetAllCompanySummariesWithExpansionSucceedsAsync()
        {
            var companiesResponse = await IntrinioTestClient.GetAllCompanySummariesAsync(expandAbbreviations: true);

            Assert.IsNotNull(companiesResponse);
            Assert.IsTrue(companiesResponse.Companies.Count > 1);

            var apple = companiesResponse.Companies
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

        [TestMethod]
        public async Task GetAllCompanySummariesPageSizeSuccessfulAsync()
        {
            var companiesResponse = await IntrinioTestClient.GetAllCompanySummariesAsync(page_size: 10000, has_stock_prices: true);

            Assert.IsNotNull(companiesResponse);
            Assert.IsTrue(companiesResponse.Companies.Count == 10000);
        }
    }
}