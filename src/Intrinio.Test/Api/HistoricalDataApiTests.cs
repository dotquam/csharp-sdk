

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
            //string tag = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //string nextPage = null;
            //var response = instance.GetHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<ApiResponseHistoricalData> (response, "response is ApiResponseHistoricalData");
        }
        
    }

}
