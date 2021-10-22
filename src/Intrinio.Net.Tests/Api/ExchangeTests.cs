using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;


namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class ExchangeTests
    {
        private const string USCOMP = "USCOMP";
        private const string SEOUL_CITY = "SEOUL";
        private const string KOREA_COUNTRY_CODE = "KR";
        private const string USA_NAME = "UNITED STATES OF AMERICA";

        [TestMethod]
        public async Task GetAllExchangesSucceedsAsync()
        {
            var exchangeResponse = await IntrinioTestClient.GetAllExchangesAsync();

            Assert.IsNotNull(exchangeResponse);
            Assert.IsNotEmpty(exchangeResponse.StockExchanges);
        }

        [TestMethod]
        // Intrinio accepts page_size as a valid query parameter but it doesn't do anything.
        public async Task GetAllExchangesPageSizeSucceedsAsync()
        {
            var exchangeResponse = await IntrinioTestClient.GetAllExchangesAsync(page_size: 50);

            Assert.IsNotNull(exchangeResponse);
            Assert.IsNotEmpty(exchangeResponse.StockExchanges);

            Assert.AreNotEqual(17, exchangeResponse.StockExchanges.Count);
        }

        [TestMethod]
        public async Task LookupExchangeSucceedsAsync()
        {
            var uscomp = await IntrinioTestClient.LookupExchangeAsync(USCOMP);

            Assert.IsNotNull(uscomp);
            Assert.IsTrue(uscomp.Mic == USCOMP);
        }

        [DataTestMethod]
        [DataRow(SEOUL_CITY, null, KOREA_COUNTRY_CODE)]
        [DataRow(SEOUL_CITY, null, null)]
        [DataRow(null, USA_NAME, null)]
        [DataRow(null, null, KOREA_COUNTRY_CODE)]
        public async Task GetAllExchangesByCountrySucceedsAsync(string city, string country, string countryCode)
        {
            var exchangeResponse = await IntrinioTestClient.GetAllExchangesAsync(city, country, countryCode);

            Assert.IsNotNull(exchangeResponse);
            Assert.IsNotEmpty(exchangeResponse.StockExchanges);
        }
    }
}