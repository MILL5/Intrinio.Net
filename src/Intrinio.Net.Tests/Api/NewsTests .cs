using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class NewsTest
    {
        private const string NEXT_PAGE = "MjAyMi0wMy0yMiAxODo0NDozMyBVVEN8NzQwOTc3Nw==";


        [TestMethod]
        public async Task GetNewsSucceedsdAsync()
        {
            var newsResponse = await IntrinioTestClient.GetNewsAsync(5, NEXT_PAGE);

            Assert.IsNotNull(newsResponse);
            Assert.IsNotEmpty(newsResponse.News);
        }

        [TestMethod]
        public async Task GetNewsSucceedsPaginationAsync()
        {
            var newsResponse = await IntrinioTestClient.GetNewsAsync(10);

            Assert.IsNotNull(newsResponse);
            Assert.IsNotEmpty(newsResponse.News);
        }

    }
}
