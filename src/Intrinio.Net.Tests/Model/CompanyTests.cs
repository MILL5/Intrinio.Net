


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Intrinio.Net.Api;
using Intrinio.Net.Model;
using Intrinio.Net.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Intrinio.Net.Tests
{
    /// <summary>
    ///  Class for testing Company
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CompanyTests
    {
        // TODO uncomment below to declare an instance variable for Company
        //private Company instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Company
            //instance = new Company();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Company
        /// </summary>
        [Test]
        public void CompanyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Company
            //Assert.IsInstanceOfType<Company> (instance, "variable 'instance' is a Company");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Ticker'
        /// </summary>
        [Test]
        public void TickerTest()
        {
            // TODO unit test for the property 'Ticker'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Lei'
        /// </summary>
        [Test]
        public void LeiTest()
        {
            // TODO unit test for the property 'Lei'
        }
        /// <summary>
        /// Test the property 'LegalName'
        /// </summary>
        [Test]
        public void LegalNameTest()
        {
            // TODO unit test for the property 'LegalName'
        }
        /// <summary>
        /// Test the property 'StockExchange'
        /// </summary>
        [Test]
        public void StockExchangeTest()
        {
            // TODO unit test for the property 'StockExchange'
        }
        /// <summary>
        /// Test the property 'Sic'
        /// </summary>
        [Test]
        public void SicTest()
        {
            // TODO unit test for the property 'Sic'
        }
        /// <summary>
        /// Test the property 'ShortDescription'
        /// </summary>
        [Test]
        public void ShortDescriptionTest()
        {
            // TODO unit test for the property 'ShortDescription'
        }
        /// <summary>
        /// Test the property 'LongDescription'
        /// </summary>
        [Test]
        public void LongDescriptionTest()
        {
            // TODO unit test for the property 'LongDescription'
        }
        /// <summary>
        /// Test the property 'Ceo'
        /// </summary>
        [Test]
        public void CeoTest()
        {
            // TODO unit test for the property 'Ceo'
        }
        /// <summary>
        /// Test the property 'CompanyUrl'
        /// </summary>
        [Test]
        public void CompanyUrlTest()
        {
            // TODO unit test for the property 'CompanyUrl'
        }
        /// <summary>
        /// Test the property 'BusinessAddress'
        /// </summary>
        [Test]
        public void BusinessAddressTest()
        {
            // TODO unit test for the property 'BusinessAddress'
        }
        /// <summary>
        /// Test the property 'MailingAddress'
        /// </summary>
        [Test]
        public void MailingAddressTest()
        {
            // TODO unit test for the property 'MailingAddress'
        }
        /// <summary>
        /// Test the property 'BusinessPhoneNo'
        /// </summary>
        [Test]
        public void BusinessPhoneNoTest()
        {
            // TODO unit test for the property 'BusinessPhoneNo'
        }
        /// <summary>
        /// Test the property 'HqAddress1'
        /// </summary>
        [Test]
        public void HqAddress1Test()
        {
            // TODO unit test for the property 'HqAddress1'
        }
        /// <summary>
        /// Test the property 'HqAddress2'
        /// </summary>
        [Test]
        public void HqAddress2Test()
        {
            // TODO unit test for the property 'HqAddress2'
        }
        /// <summary>
        /// Test the property 'HqAddressCity'
        /// </summary>
        [Test]
        public void HqAddressCityTest()
        {
            // TODO unit test for the property 'HqAddressCity'
        }
        /// <summary>
        /// Test the property 'HqAddressPostalCode'
        /// </summary>
        [Test]
        public void HqAddressPostalCodeTest()
        {
            // TODO unit test for the property 'HqAddressPostalCode'
        }
        /// <summary>
        /// Test the property 'EntityLegalForm'
        /// </summary>
        [Test]
        public void EntityLegalFormTest()
        {
            // TODO unit test for the property 'EntityLegalForm'
        }
        /// <summary>
        /// Test the property 'Cik'
        /// </summary>
        [Test]
        public void CikTest()
        {
            // TODO unit test for the property 'Cik'
        }
        /// <summary>
        /// Test the property 'LatestFilingDate'
        /// </summary>
        [Test]
        public void LatestFilingDateTest()
        {
            // TODO unit test for the property 'LatestFilingDate'
        }
        /// <summary>
        /// Test the property 'HqState'
        /// </summary>
        [Test]
        public void HqStateTest()
        {
            // TODO unit test for the property 'HqState'
        }
        /// <summary>
        /// Test the property 'HqCountry'
        /// </summary>
        [Test]
        public void HqCountryTest()
        {
            // TODO unit test for the property 'HqCountry'
        }
        /// <summary>
        /// Test the property 'IncState'
        /// </summary>
        [Test]
        public void IncStateTest()
        {
            // TODO unit test for the property 'IncState'
        }
        /// <summary>
        /// Test the property 'IncCountry'
        /// </summary>
        [Test]
        public void IncCountryTest()
        {
            // TODO unit test for the property 'IncCountry'
        }
        /// <summary>
        /// Test the property 'Employees'
        /// </summary>
        [Test]
        public void EmployeesTest()
        {
            // TODO unit test for the property 'Employees'
        }
        /// <summary>
        /// Test the property 'EntityStatus'
        /// </summary>
        [Test]
        public void EntityStatusTest()
        {
            // TODO unit test for the property 'EntityStatus'
        }
        /// <summary>
        /// Test the property 'Sector'
        /// </summary>
        [Test]
        public void SectorTest()
        {
            // TODO unit test for the property 'Sector'
        }
        /// <summary>
        /// Test the property 'IndustryCategory'
        /// </summary>
        [Test]
        public void IndustryCategoryTest()
        {
            // TODO unit test for the property 'IndustryCategory'
        }
        /// <summary>
        /// Test the property 'IndustryGroup'
        /// </summary>
        [Test]
        public void IndustryGroupTest()
        {
            // TODO unit test for the property 'IndustryGroup'
        }
        /// <summary>
        /// Test the property 'Template'
        /// </summary>
        [Test]
        public void TemplateTest()
        {
            // TODO unit test for the property 'Template'
        }
        /// <summary>
        /// Test the property 'StandardizedActive'
        /// </summary>
        [Test]
        public void StandardizedActiveTest()
        {
            // TODO unit test for the property 'StandardizedActive'
        }
        /// <summary>
        /// Test the property 'FirstFundamentalDate'
        /// </summary>
        [Test]
        public void FirstFundamentalDateTest()
        {
            // TODO unit test for the property 'FirstFundamentalDate'
        }
        /// <summary>
        /// Test the property 'LastFundamentalDate'
        /// </summary>
        [Test]
        public void LastFundamentalDateTest()
        {
            // TODO unit test for the property 'LastFundamentalDate'
        }
        /// <summary>
        /// Test the property 'FirstStockPriceDate'
        /// </summary>
        [Test]
        public void FirstStockPriceDateTest()
        {
            // TODO unit test for the property 'FirstStockPriceDate'
        }
        /// <summary>
        /// Test the property 'LastStockPriceDate'
        /// </summary>
        [Test]
        public void LastStockPriceDateTest()
        {
            // TODO unit test for the property 'LastStockPriceDate'
        }

    }

}
