﻿using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using static Intrinio.Net.Tests.TestManager;
using Assert = NUnit.Framework.Assert;

namespace Intrinio.Net.Tests.Api;

[TestClass]
public class FundamentalsTests
{
    [DataTestMethod]
    [DataRow("AAPL-income_statement-2018-Q1")]
    [DataRow("AAPL-balance_sheet_statement-2018-Q1")]
    [DataRow("AAPL-cash_flow_statement-2018-Q1")]
    [DataRow("AAPL-calculations-2018-Q1")]
    public async Task GetDifferentStatementsInStandardizedFinancialsAsync(string id)
    {
        var standardizedFinancials = await IntrinioTestClient.GetFundamentalStandardizedFinancials(id);
        Assert.IsNotNull(standardizedFinancials);
    }

    [DataTestMethod]
    [DataRow("AAPL-income_statement-2018-Q1")]
    [DataRow("AAPL-income_statement-2018-Q2")]
    [DataRow("AAPL-income_statement-2018-Q3")]
    [DataRow("AAPL-income_statement-2018-Q4")]
    public async Task GetQuatersStandardizedFinancialsAsync(string id)
    {
        var standardizedFinancials = await IntrinioTestClient.GetFundamentalStandardizedFinancials(id);
        Assert.AreEqual(id.Split('-')[3], standardizedFinancials.Fundamental.FiscalPeriod);
        Assert.AreEqual(id.Split('-')[2], standardizedFinancials.Fundamental.FiscalYear);
        Assert.AreEqual(id.Split('-')[1], standardizedFinancials.Fundamental.StatementCode);
        Assert.AreEqual(id.Split('-')[1], standardizedFinancials.Fundamental.Company.Ticker);
    }

    [DataTestMethod]
    [DataRow("AAPL-income_statement-2018-FY")]
    public async Task GetYearsStandardizedFinancialsAsync(string id)
    {
        var standardizedFinancials = await IntrinioTestClient.GetFundamentalStandardizedFinancials(id);
        Assert.AreEqual(id.Split('-')[3], standardizedFinancials.Fundamental.FiscalPeriod);
    }

    [DataTestMethod]
    [DataRow("AAPL-income_statements-2018-Q1")]
    public void GetBadStatementCode(string id)
    {
        IntrinioNetException ex = Assert.ThrowsAsync<IntrinioNetException>(async () => await IntrinioTestClient.GetFundamentalStandardizedFinancials(id));

        Assert.That(ex.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        Assert.That(ex.Message, Is.EqualTo("statement_code is not a valid option. Must be one of income_statement, balance_sheet_statement, cash_flow_statement, calculations"));
    }
}
