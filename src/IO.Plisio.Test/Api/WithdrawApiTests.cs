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
    ///  Class for testing WithdrawApi
    /// </summary>
    [TestFixture]
    public class WithdrawApiTests
    {
        private WithdrawApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WithdrawApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WithdrawApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WithdrawApi
            //Assert.IsInstanceOfType(typeof(WithdrawApi), instance, "instance is a WithdrawApi");
        }

        /// <summary>
        /// Test OperationsWithdrawGet
        /// </summary>
        [Test]
        public void OperationsWithdrawGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string psysCid = null;
            //string to = null;
            //string amount = null;
            //string type = null;
            //string feePlan = null;
            //var response = instance.OperationsWithdrawGet(psysCid, to, amount, type, feePlan);
            //Assert.IsInstanceOf<WithdrawApiResponseDto> (response, "response is WithdrawApiResponseDto");
        }
    }

}
