using System.Collections.Generic;
using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Models;

[TestClass]
public class ApiResponseDataTagsTests
{
    private static DataTag[] DataTags = new DataTag[] {
            new DataTag(Tag: "amortizationexpense",  Id: "tag_PypZX3", Name: "Amortization Expense",
             StatementCode: "income_statement", StatementType:DataTag.FinancialStatementType.Industrial,
             Parent: "totaloperatingexpenses", Sequence: 13, Factor: "+", Balance: "debit",
             Type: "income_statement_metric", Unit: "usd"),

            new DataTag(Id: "tag_Dzomng", Name: "Amortization Expense", Tag: "amortizationexpense"),

            new DataTag(Tag: "amortizationexpense", Id: "tag_ByK1xX", Name: "Amortization Expense",
             StatementCode: "income_statement", StatementType: DataTag.FinancialStatementType.Industrial,
             Parent: "totaloperatingexpenses", Sequence: 13, Factor: "+", Balance: "debit",
             Type: "income_statement_metric", Unit: "usd")
    };

    [TestMethod]
    public void ApiResponseDataTagsEqualsSucceed()
    {
        var dataTags1 = new List<DataTag>() { DataTags[0], DataTags[1] };
        var dataTags2 = new List<DataTag>{ DataTags[0], DataTags[1] };
        var actual = new ApiResponseDataTags() { Tags = dataTags1 };
        var expected = new ApiResponseDataTags() { Tags = dataTags2 };

        Assert.IsTrue(actual.Equals(expected));
        Assert.IsTrue(actual.Equals((object)expected));
    }

    [TestMethod]
    public void ApiResponseDataTagsNotEqualsSucceed()
    {
        var dataTags1 = new List<DataTag>() { DataTags[0], DataTags[1] };
        var dataTags2 = new List<DataTag> { DataTags[2], DataTags[1] };
        var actual = new ApiResponseDataTags() { Tags = dataTags1 };
        var expected = new ApiResponseDataTags() { Tags = dataTags2 };

        Assert.IsFalse(actual.Equals(expected));
        Assert.IsFalse(actual.Equals(null));
    }

    [TestMethod]
    public void ApiResponseDataTagsHashCodeSucceed()
    {
        var dataTags1 = new List<DataTag>{ DataTags[0], DataTags[1] };
        var dataTags2 = new List<DataTag>{ DataTags[0], DataTags[1] };

        var actual1 = new ApiResponseDataTags() { Tags = dataTags1 };
        var actual2 = new ApiResponseDataTags() { Tags = dataTags2 };

        var expected = -2032572046;

        Assert.AreEqual(expected, actual1.GetHashCode());
        Assert.AreEqual(expected, actual2.GetHashCode());
    }

    [TestMethod]
    public void ApiResponseDataTagsToStringSucceed()
    {
        var dataTags = new List<DataTag> { DataTags[0], DataTags[1] };

        var apiResponseDataTags = new ApiResponseDataTags() { Tags = dataTags };

        var expected = "class ApiResponseDataTags {  Tags: System.Collections.Generic.List`1[Intrinio.Net.Model.DataTag]  NextPage: }";

        // server and local process \r\n differently some remove those before testing
        var actual = apiResponseDataTags.ToString().Replace("\r","").Replace("\n","");

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ApiResponseDataTagsToJsonSucceed()
    {
        var dataTags = new List<DataTag> { DataTags[0], DataTags[1] };

        var apiResponseDataTags = new ApiResponseDataTags() { Tags = dataTags };

        var expected = "{  \"tags\": [    {      \"statement_type\": \"industrial\"," +
            "      \"id\": \"tag_PypZX3\",      \"name\": \"Amortization Expense\"," +
            "      \"tag\": \"amortizationexpense\",      \"statement_code\": \"income_statement\"," +
            "      \"parent\": \"totaloperatingexpenses\",      \"sequence\": 13.0," +
            "      \"factor\": \"+\",      \"balance\": \"debit\",      \"type\": \"income_statement_metric\"," +
            "      \"unit\": \"usd\"    },    {      \"id\": \"tag_Dzomng\"," +
            "      \"name\": \"Amortization Expense\",      \"tag\": \"amortizationexpense\"    }  ]}";

        // server and local process \r\n differently some remove those before testing
        var actual = apiResponseDataTags.ToJson().Replace("\r", "").Replace("\n", "");

        Assert.AreEqual(expected, actual);
    }
}
