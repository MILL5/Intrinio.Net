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
}
