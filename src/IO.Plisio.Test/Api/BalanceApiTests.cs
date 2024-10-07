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
    ///  Class for testing BalanceApi
    /// </summary>
    [TestFixture]
    public class BalanceApiTests
    {
        private BalanceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BalanceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BalanceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BalanceApi
            //Assert.IsInstanceOfType(typeof(BalanceApi), instance, "instance is a BalanceApi");
        }

        /// <summary>
        /// Test BalancesPsysCidGet
        /// </summary>
        [Test]
        public void BalancesPsysCidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string psysCid = null;
            //var response = instance.BalancesPsysCidGet(psysCid);
            //Assert.IsInstanceOf<BalanceApiResponseDto> (response, "response is BalanceApiResponseDto");
        }
    }

}
