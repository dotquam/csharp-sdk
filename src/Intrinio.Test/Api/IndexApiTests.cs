/* 
 * Intrinio API
 *
 * Welcome to the Intrinio API! Through our Marketplace, we offer a wide selection of financial data feeds sourced by our own proprietary processes as well as from many data vendors. The primary application of the Intrinio API is for use in third-party applications and integrations or for end-users utilizing the Excel add-in and Google Sheets add-on. The Intrinio API uses HTTPS verbs and a RESTful endpoint structure, which makes it easy to request data from Intrinio. Responses are delivered in JSON format. If you need additional help in using the API, go to our home page (https://intrinio.com) and click on the chat icon in the lower right corner.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    ///  Class for testing IndexApi
    /// </summary>
    [TestFixture]
    public class IndexApiTests
    {
        private IndexApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IndexApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IndexApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IndexApi
            //Assert.IsInstanceOfType(typeof(IndexApi), instance, "instance is a IndexApi");
        }

        
        /// <summary>
        /// Test GetAllEconomicIndices
        /// </summary>
        [Test]
        public void GetAllEconomicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllEconomicIndices(nextPage);
            //Assert.IsInstanceOf<List<EconomicIndexSummary>> (response, "response is List<EconomicIndexSummary>");
        }
        
        /// <summary>
        /// Test GetAllSicIndices
        /// </summary>
        [Test]
        public void GetAllSicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllSicIndices(nextPage);
            //Assert.IsInstanceOf<List<SICIndex>> (response, "response is List<SICIndex>");
        }
        
        /// <summary>
        /// Test GetAllStockMarketIndices
        /// </summary>
        [Test]
        public void GetAllStockMarketIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllStockMarketIndices(nextPage);
            //Assert.IsInstanceOf<List<StockMarketIndexSummary>> (response, "response is List<StockMarketIndexSummary>");
        }
        
        /// <summary>
        /// Test GetEconomicIndexById
        /// </summary>
        [Test]
        public void GetEconomicIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetEconomicIndexById(identifier);
            //Assert.IsInstanceOf<EconomicIndex> (response, "response is EconomicIndex");
        }
        
        /// <summary>
        /// Test GetEconomicIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetEconomicIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetEconomicIndexDataPointNumber(identifier, item);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetEconomicIndexDataPointText
        /// </summary>
        [Test]
        public void GetEconomicIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetEconomicIndexDataPointText(identifier, item);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
        /// <summary>
        /// Test GetEconomicIndexHistoricalData
        /// </summary>
        [Test]
        public void GetEconomicIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //var response = instance.GetEconomicIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
            //Assert.IsInstanceOf<List<HistoricalData>> (response, "response is List<HistoricalData>");
        }
        
        /// <summary>
        /// Test GetSicIndexById
        /// </summary>
        [Test]
        public void GetSicIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSicIndexById(identifier);
            //Assert.IsInstanceOf<SICIndex> (response, "response is SICIndex");
        }
        
        /// <summary>
        /// Test GetSicIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetSicIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetSicIndexDataPointNumber(identifier, item);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetSicIndexDataPointText
        /// </summary>
        [Test]
        public void GetSicIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetSicIndexDataPointText(identifier, item);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
        /// <summary>
        /// Test GetSicIndexHistoricalData
        /// </summary>
        [Test]
        public void GetSicIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //var response = instance.GetSicIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
            //Assert.IsInstanceOf<List<HistoricalData>> (response, "response is List<HistoricalData>");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexById
        /// </summary>
        [Test]
        public void GetStockMarketIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetStockMarketIndexById(identifier);
            //Assert.IsInstanceOf<StockMarketIndex> (response, "response is StockMarketIndex");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetStockMarketIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetStockMarketIndexDataPointNumber(identifier, item);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexDataPointText
        /// </summary>
        [Test]
        public void GetStockMarketIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //var response = instance.GetStockMarketIndexDataPointText(identifier, item);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexHistoricalData
        /// </summary>
        [Test]
        public void GetStockMarketIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //var response = instance.GetStockMarketIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
            //Assert.IsInstanceOf<List<HistoricalData>> (response, "response is List<HistoricalData>");
        }
        
        /// <summary>
        /// Test SearchEconomicIndices
        /// </summary>
        [Test]
        public void SearchEconomicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string nextPage = null;
            //var response = instance.SearchEconomicIndices(query, nextPage);
            //Assert.IsInstanceOf<List<EconomicIndexSummary>> (response, "response is List<EconomicIndexSummary>");
        }
        
        /// <summary>
        /// Test SearchSicIndices
        /// </summary>
        [Test]
        public void SearchSicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string nextPage = null;
            //var response = instance.SearchSicIndices(query, nextPage);
            //Assert.IsInstanceOf<List<SICIndex>> (response, "response is List<SICIndex>");
        }
        
        /// <summary>
        /// Test SearchStockMarketsIndices
        /// </summary>
        [Test]
        public void SearchStockMarketsIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string nextPage = null;
            //var response = instance.SearchStockMarketsIndices(query, nextPage);
            //Assert.IsInstanceOf<List<StockMarketIndexSummary>> (response, "response is List<StockMarketIndexSummary>");
        }
        
    }

}
