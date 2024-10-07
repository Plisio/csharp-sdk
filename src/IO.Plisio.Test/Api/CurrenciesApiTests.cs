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
    ///  Class for testing CurrenciesApi
    /// </summary>
    [TestFixture]
    public class CurrenciesApiTests
    {
        private CurrenciesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CurrenciesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CurrenciesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CurrenciesApi
            //Assert.IsInstanceOfType(typeof(CurrenciesApi), instance, "instance is a CurrenciesApi");
        }

        /// <summary>
        /// Test CurrenciesFiatGet
        /// </summary>
        [Test]
        public void CurrenciesFiatGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fiat = null;
            //var response = instance.CurrenciesFiatGet(fiat);
            //Assert.IsInstanceOf<CryptocurrencyApiResponseDto> (response, "response is CryptocurrencyApiResponseDto");
        }
    }

}
