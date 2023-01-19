using Intrinio.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Models;

[TestClass]
public class SecurityTypeTests
{
    [TestMethod]
    public void SecurityTypeEqualsSucceed()
    {
        var actual = new SecurityType() { Code = "EQS", Name = "Equity Shares" };
        var expected = new SecurityType() { Code = "EQS", Name = "Equity Shares" };

        Assert.IsTrue(actual.Equals(expected));
    }

    [TestMethod]
    public void SecurityTypeNotEqualsSucceed()
    {
        var actual = new SecurityType() { Code = "EQS", Name = "Equity Shares" };
        var expected = new SecurityType() { Code = "BND", Name = "Bonds" };

        Assert.IsFalse(actual.Equals(expected));
    }
}
