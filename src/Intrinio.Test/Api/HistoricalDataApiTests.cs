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
    ///  Class for testing HistoricalDataApi
    /// </summary>
    [TestFixture]
    public class HistoricalDataApiTests
    {
        private HistoricalDataApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HistoricalDataApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HistoricalDataApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HistoricalDataApi
            //Assert.IsInstanceOfType(typeof(HistoricalDataApi), instance, "instance is a HistoricalDataApi");
        }

        
        /// <summary>
        /// Test GetHistoricalData
        /// </summary>
        [Test]
        public void GetHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string item = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //string nextPage = null;
            //var response = instance.GetHistoricalData(identifier, item, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<List<HistoricalData>> (response, "response is List<HistoricalData>");
        }
        
    }

}
