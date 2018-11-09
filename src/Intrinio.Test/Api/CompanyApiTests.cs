

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Intrinio.Client;
using Intrinio.Api;
using Intrinio.Model;

namespace Intrinio.Test
{
    /// <summary>
    ///  Class for testing CompanyApi
    /// </summary>
    [TestFixture]
    public class CompanyApiTests
    {
        private CompanyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompanyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompanyApi
            //Assert.IsInstanceOfType(typeof(CompanyApi), instance, "instance is a CompanyApi");
        }

        
        /// <summary>
        /// Test FilterCompanies
        /// </summary>
        [Test]
        public void FilterCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? lastFilingDate = null;
            //string sic = null;
            //string template = null;
            //string sector = null;
            //string industryCategory = null;
            //string industryGroup = null;
            //string nextPage = null;
            //var response = instance.FilterCompanies(lastFilingDate, sic, template, sector, industryCategory, industryGroup, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanies> (response, "response is ApiResponseCompanies");
        }
        
        /// <summary>
        /// Test FilterCompanyFundamentals
        /// </summary>
        [Test]
        public void FilterCompanyFundamentalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? filedAfter = null;
            //DateTime? filedBefore = null;
            //bool? reportedOnly = null;
            //int? fiscalYear = null;
            //string statementCode = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string nextPage = null;
            //var response = instance.FilterCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyFundamentals> (response, "response is ApiResponseCompanyFundamentals");
        }
        
        /// <summary>
        /// Test GetAllCompanies
        /// </summary>
        [Test]
        public void GetAllCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllCompanies(nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanies> (response, "response is ApiResponseCompanies");
        }
        
        /// <summary>
        /// Test GetAllCompanyNews
        /// </summary>
        [Test]
        public void GetAllCompanyNewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllCompanyNews(nextPage);
            //Assert.IsInstanceOf<ApiResponseNews> (response, "response is ApiResponseNews");
        }
        
        /// <summary>
        /// Test GetCompany
        /// </summary>
        [Test]
        public void GetCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetCompany(identifier);
            //Assert.IsInstanceOf<Company> (response, "response is Company");
        }
        
        /// <summary>
        /// Test GetCompanyDataPointNumber
        /// </summary>
        [Test]
        public void GetCompanyDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetCompanyDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetCompanyDataPointText
        /// </summary>
        [Test]
        public void GetCompanyDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetCompanyDataPointText(identifier, tag);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
        /// <summary>
        /// Test GetCompanyFilings
        /// </summary>
        [Test]
        public void GetCompanyFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetCompanyFilings(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyFilings> (response, "response is ApiResponseCompanyFilings");
        }
        
        /// <summary>
        /// Test GetCompanyFundamentals
        /// </summary>
        [Test]
        public void GetCompanyFundamentalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetCompanyFundamentals(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyFundamentals> (response, "response is ApiResponseCompanyFundamentals");
        }
        
        /// <summary>
        /// Test GetCompanyHistoricalData
        /// </summary>
        [Test]
        public void GetCompanyHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //string nextPage = null;
            //var response = instance.GetCompanyHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyHistoricalData> (response, "response is ApiResponseCompanyHistoricalData");
        }
        
        /// <summary>
        /// Test GetCompanyNews
        /// </summary>
        [Test]
        public void GetCompanyNewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetCompanyNews(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyNews> (response, "response is ApiResponseCompanyNews");
        }
        
        /// <summary>
        /// Test GetCompanySecurities
        /// </summary>
        [Test]
        public void GetCompanySecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetCompanySecurities(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanySecurities> (response, "response is ApiResponseCompanySecurities");
        }
        
        /// <summary>
        /// Test LookupCompanyFundamental
        /// </summary>
        [Test]
        public void LookupCompanyFundamentalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string statementCode = null;
            //string fiscalPeriod = null;
            //int? fiscalYear = null;
            //var response = instance.LookupCompanyFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
            //Assert.IsInstanceOf<List<Fundamental>> (response, "response is List<Fundamental>");
        }
        
        /// <summary>
        /// Test SearchCompanies
        /// </summary>
        [Test]
        public void SearchCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //var response = instance.SearchCompanies(query);
            //Assert.IsInstanceOf<ApiResponseCompanies> (response, "response is ApiResponseCompanies");
        }
        
    }

}
