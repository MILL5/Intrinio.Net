using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api
{
    [TestClass]
    public class DataTagTests
    {
        private const string TAG_ID = "tag_Dzomng";
        private const string TAG_NAME = "Amortization Expense";
        private const string TAG = "amortizationexpense";
        private const string TYPE = "cash_flow_statement_metric";
        private const string PARENT = "netcashfromcontinuingoperatingactivities";
        private const string STATEMENT_CODE = "cash_flow_statement";
        private const string FS_TEMPLATE = "industrial";
        private const string TAG_QUERY = "amortization";

        [TestMethod]
        public async Task GetAllDataTagSucceedsAsync()
        {
            var dataTagResponse = await IntrinioTestClient.GetAllDataTagsAsync();

            Assert.IsNotNull(dataTagResponse);
            Assert.IsNotEmpty(dataTagResponse.Tags);
        }

        [TestMethod]
        public async Task GetAllDataTagPaginationSucceedsAsync()
        {
            var dataTagsResponse1 = await IntrinioTestClient.GetAllDataTagsAsync();

            Assert.IsNotNull(dataTagsResponse1);
            Assert.IsNotEmpty(dataTagsResponse1.Tags);

            var dataTagsResponse2 = await IntrinioTestClient.GetAllDataTagsAsync(next_page: dataTagsResponse1.NextPage);

            Assert.IsNotNull(dataTagsResponse2);
            Assert.IsNotEmpty(dataTagsResponse2.Tags);

            Assert.AreNotEqual(dataTagsResponse1.Tags.First().Id, dataTagsResponse2.Tags.First().Id);
        }

        [DataTestMethod]
        [DataRow(TAG, null, null , null, null)]
        [DataRow(null, TYPE, null, null, null)]
        [DataRow(null, null, PARENT, null, null)]
        [DataRow(null, null,null, STATEMENT_CODE, null)]
        [DataRow(null, null,null, null, FS_TEMPLATE)]
        public async Task GetAllDataTagsWithParamsSucceedsAsync(
            string tag,
            string type,
            string parent,
            string statementCode,
            string fsTemplate
            )
        {
            var dataTagsResponse = await IntrinioTestClient.GetAllDataTagsAsync(tag, type, parent, statementCode, fsTemplate);

            Assert.IsNotNull(dataTagsResponse);
            Assert.IsTrue(dataTagsResponse.Tags.Count > 0);

            var testTag = dataTagsResponse.Tags
                .First(c => c.Id == TAG_ID);

            Assert.IsNotNull(testTag);
            Assert.IsTrue(testTag.Name == TAG_NAME);
            Assert.IsTrue(testTag.Tag == TAG);
            Assert.IsTrue(testTag.Type == TYPE);
            Assert.IsTrue(testTag.Parent == PARENT);
            Assert.IsTrue(testTag.StatementCode == STATEMENT_CODE);
            Assert.IsTrue(testTag.StatementType == Model.DataTag.FinancialStatementType.Industrial);
        }

        [DataTestMethod]
        [DataRow(TAG_ID)]
        [DataRow(TAG)]
        public async Task LookupDataTagSucceedsAsync(string identifier)
        {
            var testTag = await IntrinioTestClient.LookupDataTagAsync(identifier);

            Assert.IsNotNull(testTag);
            Assert.IsTrue(testTag.Name == TAG_NAME);
        }

        [DataTestMethod]
        [DataRow(TAG_QUERY)]
        public async Task SearchDataTagSucceedsAsync(string query)
        {
            var dataTagsResponse = await IntrinioTestClient.SearchDataTagsAsync(query);

            Assert.IsTrue(dataTagsResponse.Tags.Count > 0);

            var testTag = dataTagsResponse.Tags
                .First(c => c.Id == TAG_ID);

            Assert.IsNotNull(testTag);
            Assert.IsTrue(testTag.Tag == TAG);
        }

    }
}
