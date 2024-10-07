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
    ///  Class for testing TransactionApi
    /// </summary>
    [TestFixture]
    public class TransactionApiTests
    {
        private TransactionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransactionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransactionApi
            //Assert.IsInstanceOfType(typeof(TransactionApi), instance, "instance is a TransactionApi");
        }

        /// <summary>
        /// Test OperationsCommissionPsysCidGet
        /// </summary>
        [Test]
        public void OperationsCommissionPsysCidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string psysCid = null;
            //string addresses = null;
            //string amounts = null;
            //string type = null;
            //string feePlan = null;
            //var response = instance.OperationsCommissionPsysCidGet(psysCid, addresses, amounts, type, feePlan);
            //Assert.IsInstanceOf<CommissionApiResponseDto> (response, "response is CommissionApiResponseDto");
        }
        /// <summary>
        /// Test OperationsFeePlanPsysCidGet
        /// </summary>
        [Test]
        public void OperationsFeePlanPsysCidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string psysCid = null;
            //var response = instance.OperationsFeePlanPsysCidGet(psysCid);
            //Assert.IsInstanceOf<FeePlanApiResponseDto> (response, "response is FeePlanApiResponseDto");
        }
        /// <summary>
        /// Test OperationsFeePsysCidGet
        /// </summary>
        [Test]
        public void OperationsFeePsysCidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string psysCid = null;
            //string addresses = null;
            //string amounts = null;
            //string feePlan = null;
            //var response = instance.OperationsFeePsysCidGet(psysCid, addresses, amounts, feePlan);
            //Assert.IsInstanceOf<FeeApiResponseDto> (response, "response is FeeApiResponseDto");
        }
        /// <summary>
        /// Test OperationsGet
        /// </summary>
        [Test]
        public void OperationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //string shopId = null;
            //string type = null;
            //string status = null;
            //string currency = null;
            //string search = null;
            //var response = instance.OperationsGet(page, limit, shopId, type, status, currency, search);
            //Assert.IsInstanceOf<OperationsApiResponseDto> (response, "response is OperationsApiResponseDto");
        }
        /// <summary>
        /// Test OperationsIdGet
        /// </summary>
        [Test]
        public void OperationsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.OperationsIdGet(id);
            //Assert.IsInstanceOf<OperationApiResponseDto> (response, "response is OperationApiResponseDto");
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
