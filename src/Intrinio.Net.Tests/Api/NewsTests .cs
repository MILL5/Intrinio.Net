using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class NewsTest
    {
        private const string NEXT_PAGE  = "MjAyMi0wMy0yMiAxODo0NDozMyBVVEN8NzQwOTc3Nw==";
        private const int    PAGE_SIZE  = 10;
        private const string IDENFITIER = "com_4zraRX";
        private const string STATUS_OK  = "OK";


        [TestMethod]
        public async Task GetNewsSucceedsdAsync()
        {
            var newsResponse = await IntrinioTestClient.GetNewsAsync(PAGE_SIZE, NEXT_PAGE);

            Assert.IsNotNull(newsResponse);
            Assert.IsNotEmpty(newsResponse.News);
            Assert.IsInstanceOf<List<CompanyNews>>(newsResponse.News);
        }

        [TestMethod]
        public async Task GetNewsSucceedsPaginationAsync()
        {
            var newsResponse = await IntrinioTestClient.GetNewsAsync(PAGE_SIZE);

            Assert.IsNotNull(newsResponse);
            Assert.IsNotEmpty(newsResponse.News);
            Assert.IsInstanceOf<List<CompanyNews>>(newsResponse.News);
        }

        [TestMethod]
        public async Task GetNewsByCompanySucceedsAsync()
        {
            var newsResponse = await IntrinioTestClient.GetNewsByCompanyAsync(IDENFITIER, PAGE_SIZE, NEXT_PAGE);

            Assert.IsNotNull(newsResponse);
            Assert.IsNotEmpty(newsResponse.News);
            Assert.IsInstanceOf<List<CompanyNews>>(newsResponse.News);

        }

    }
}
