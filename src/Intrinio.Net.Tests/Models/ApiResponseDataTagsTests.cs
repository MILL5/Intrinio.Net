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
    public void ApiResponseDataTagsToJsonSucceed()
    {
        var dataTags1 = new List<DataTag> { DataTags[0] };

        var actual = new ApiResponseDataTags() { Tags = dataTags1 };

        var expected = "{\r\n  \"tags\": [\r\n    {\r\n      \"statement_type\": \"industrial\",\r\n      \"id\": \"tag_PypZX3\",\r\n      \"name\": \"Amortization Expense\",\r\n      \"tag\": \"amortizationexpense\",\r\n      \"statement_code\": \"income_statement\",\r\n      \"parent\": \"totaloperatingexpenses\",\r\n      \"sequence\": 13.0,\r\n      \"factor\": \"+\",\r\n      \"balance\": \"debit\",\r\n      \"type\": \"income_statement_metric\",\r\n      \"unit\": \"usd\"\r\n    }\r\n  ]\r\n}";

        Assert.AreEqual(expected, actual.ToJson());
    }
}
