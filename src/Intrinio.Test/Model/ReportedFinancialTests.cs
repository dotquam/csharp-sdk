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
    ///  Class for testing ReportedFinancial
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReportedFinancialTests
    {
        // TODO uncomment below to declare an instance variable for ReportedFinancial
        //private ReportedFinancial instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReportedFinancial
            //instance = new ReportedFinancial();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportedFinancial
        /// </summary>
        [Test]
        public void ReportedFinancialInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReportedFinancial
            //Assert.IsInstanceOfType<ReportedFinancial> (instance, "variable 'instance' is a ReportedFinancial");
        }


        /// <summary>
        /// Test the property 'XbrlTag'
        /// </summary>
        [Test]
        public void XbrlTagTest()
        {
            // TODO unit test for the property 'XbrlTag'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}
