/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 * Contact: lead@plisio.net
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Plisio.Client;
using IO.Plisio.Api;
using IO.Plisio.Model;

namespace IO.Plisio.Test
{
    /// <summary>
    ///  Class for testing InvoiceApi
    /// </summary>
    [TestFixture]
    public class InvoiceApiTests
    {
        private InvoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceApi
            //Assert.IsInstanceOfType(typeof(InvoiceApi), instance, "instance is a InvoiceApi");
        }

        /// <summary>
        /// Test InvoicesEmailIdGet
        /// </summary>
        [Test]
        public void InvoicesEmailIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string email = null;
            //var response = instance.InvoicesEmailIdGet(id, email);
            //Assert.IsInstanceOf<InvoiceDetailsApiResponseDto> (response, "response is InvoiceDetailsApiResponseDto");
        }
        /// <summary>
        /// Test InvoicesIdGet
        /// </summary>
        [Test]
        public void InvoicesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.InvoicesIdGet(id);
            //Assert.IsInstanceOf<InvoiceDetailsApiResponseDto> (response, "response is InvoiceDetailsApiResponseDto");
        }
        /// <summary>
        /// Test InvoicesNewGet
        /// </summary>
        [Test]
        public void InvoicesNewGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //string orderName = null;
            //string orderNumber = null;
            //string amount = null;
            //string sourceCurrency = null;
            //string sourceAmount = null;
            //string allowedPsysCids = null;
            //string description = null;
            //string callbackUrl = null;
            //string email = null;
            //string language = null;
            //string plugin = null;
            //string version = null;
            //bool? redirectToInvoice = null;
            //string expireMin = null;
            //var response = instance.InvoicesNewGet(currency, orderName, orderNumber, amount, sourceCurrency, sourceAmount, allowedPsysCids, description, callbackUrl, email, language, plugin, version, redirectToInvoice, expireMin);
            //Assert.IsInstanceOf<InvoiceWhiteLabelResponseDto> (response, "response is InvoiceWhiteLabelResponseDto");
        }
        /// <summary>
        /// Test InvoicesSwitchIdGet
        /// </summary>
        [Test]
        public void InvoicesSwitchIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string psysCid = null;
            //var response = instance.InvoicesSwitchIdGet(id, psysCid);
            //Assert.IsInstanceOf<InvoiceDetailsApiResponseDto> (response, "response is InvoiceDetailsApiResponseDto");
        }
    }

}
