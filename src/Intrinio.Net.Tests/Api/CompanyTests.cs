using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;


namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class CompanyTests
    {
        [TestMethod]
        public async Task GetAllCompaniesSucceedsAsync()
        {
            var companies = await IntrinioTestClient.GetAllCompaniesAsync();
            
            Assert.IsNotNull(companies);
        }
    }
}