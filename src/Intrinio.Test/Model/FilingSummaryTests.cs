/* 
 * Intrinio API
 *
 * Welcome to the Intrinio API! Through our Marketplace, we offer a wide selection of financial data feeds sourced by our own proprietary processes as well as from many data vendors. The primary application of the Intrinio API is for use in third-party applications and integrations or for end-users utilizing the Excel add-in and Google Sheets add-on. The Intrinio API uses HTTPS verbs and a RESTful endpoint structure, which makes it easy to request data from Intrinio. Responses are delivered in JSON format. If you need additional help in using the API, go to our home page (https://intrinio.com) and click on the chat icon in the lower right corner.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Intrinio.Api;
using Intrinio.Model;
using Intrinio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Intrinio.Test
{
    /// <summary>
    ///  Class for testing FilingSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FilingSummaryTests
    {
        // TODO uncomment below to declare an instance variable for FilingSummary
        //private FilingSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FilingSummary
            //instance = new FilingSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FilingSummary
        /// </summary>
        [Test]
        public void FilingSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FilingSummary
            //Assert.IsInstanceOfType<FilingSummary> (instance, "variable 'instance' is a FilingSummary");
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
        /// Test the property 'FilingDate'
        /// </summary>
        [Test]
        public void FilingDateTest()
        {
            // TODO unit test for the property 'FilingDate'
        }
        /// <summary>
        /// Test the property 'AcceptedDate'
        /// </summary>
        [Test]
        public void AcceptedDateTest()
        {
            // TODO unit test for the property 'AcceptedDate'
        }
        /// <summary>
        /// Test the property 'PeriodEndDate'
        /// </summary>
        [Test]
        public void PeriodEndDateTest()
        {
            // TODO unit test for the property 'PeriodEndDate'
        }
        /// <summary>
        /// Test the property 'ReportType'
        /// </summary>
        [Test]
        public void ReportTypeTest()
        {
            // TODO unit test for the property 'ReportType'
        }
        /// <summary>
        /// Test the property 'SecUniqueId'
        /// </summary>
        [Test]
        public void SecUniqueIdTest()
        {
            // TODO unit test for the property 'SecUniqueId'
        }
        /// <summary>
        /// Test the property 'FilingUrl'
        /// </summary>
        [Test]
        public void FilingUrlTest()
        {
            // TODO unit test for the property 'FilingUrl'
        }
        /// <summary>
        /// Test the property 'ReportUrl'
        /// </summary>
        [Test]
        public void ReportUrlTest()
        {
            // TODO unit test for the property 'ReportUrl'
        }
        /// <summary>
        /// Test the property 'InstanceUrl'
        /// </summary>
        [Test]
        public void InstanceUrlTest()
        {
            // TODO unit test for the property 'InstanceUrl'
        }

    }

}
