/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 * Contact: lead@plisio.net
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Plisio.Api;
using IO.Plisio.Model;
using IO.Plisio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Plisio.Test
{
    /// <summary>
    ///  Class for testing OperationDto
    /// </summary>
    [TestFixture]
    public class OperationDtoTests
    {
        // TODO uncomment below to declare an instance variable for OperationDto
        //private OperationDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OperationDto
            //instance = new OperationDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationDto
        /// </summary>
        [Test]
        public void OperationDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OperationDto
            //Assert.IsInstanceOfType<OperationDto> (instance, "variable 'instance' is a OperationDto");
        }


        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'ShopId'
        /// </summary>
        [Test]
        public void ShopIdTest()
        {
            // TODO unit test for the property 'ShopId'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'PendingSum'
        /// </summary>
        [Test]
        public void PendingSumTest()
        {
            // TODO unit test for the property 'PendingSum'
        }
        /// <summary>
        /// Test the property 'PsysCid'
        /// </summary>
        [Test]
        public void PsysCidTest()
        {
            // TODO unit test for the property 'PsysCid'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'SourceCurrency'
        /// </summary>
        [Test]
        public void SourceCurrencyTest()
        {
            // TODO unit test for the property 'SourceCurrency'
        }
        /// <summary>
        /// Test the property 'SourceRate'
        /// </summary>
        [Test]
        public void SourceRateTest()
        {
            // TODO unit test for the property 'SourceRate'
        }
        /// <summary>
        /// Test the property 'Fee'
        /// </summary>
        [Test]
        public void FeeTest()
        {
            // TODO unit test for the property 'Fee'
        }
        /// <summary>
        /// Test the property 'WalletHash'
        /// </summary>
        [Test]
        public void WalletHashTest()
        {
            // TODO unit test for the property 'WalletHash'
        }
        /// <summary>
        /// Test the property 'Sendmany'
        /// </summary>
        [Test]
        public void SendmanyTest()
        {
            // TODO unit test for the property 'Sendmany'
        }
        /// <summary>
        /// Test the property '_Params'
        /// </summary>
        [Test]
        public void _ParamsTest()
        {
            // TODO unit test for the property '_Params'
        }
        /// <summary>
        /// Test the property 'ExpireAtUtc'
        /// </summary>
        [Test]
        public void ExpireAtUtcTest()
        {
            // TODO unit test for the property 'ExpireAtUtc'
        }
        /// <summary>
        /// Test the property 'CreatedAtUtc'
        /// </summary>
        [Test]
        public void CreatedAtUtcTest()
        {
            // TODO unit test for the property 'CreatedAtUtc'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'Sum'
        /// </summary>
        [Test]
        public void SumTest()
        {
            // TODO unit test for the property 'Sum'
        }
        /// <summary>
        /// Test the property 'Commission'
        /// </summary>
        [Test]
        public void CommissionTest()
        {
            // TODO unit test for the property 'Commission'
        }
        /// <summary>
        /// Test the property 'TxUrl'
        /// </summary>
        [Test]
        public void TxUrlTest()
        {
            // TODO unit test for the property 'TxUrl'
        }
        /// <summary>
        /// Test the property 'TxId'
        /// </summary>
        [Test]
        public void TxIdTest()
        {
            // TODO unit test for the property 'TxId'
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
        /// Test the property 'ActualSum'
        /// </summary>
        [Test]
        public void ActualSumTest()
        {
            // TODO unit test for the property 'ActualSum'
        }
        /// <summary>
        /// Test the property 'ActualCommission'
        /// </summary>
        [Test]
        public void ActualCommissionTest()
        {
            // TODO unit test for the property 'ActualCommission'
        }
        /// <summary>
        /// Test the property 'ActualFee'
        /// </summary>
        [Test]
        public void ActualFeeTest()
        {
            // TODO unit test for the property 'ActualFee'
        }
        /// <summary>
        /// Test the property 'ActualInvoiceSum'
        /// </summary>
        [Test]
        public void ActualInvoiceSumTest()
        {
            // TODO unit test for the property 'ActualInvoiceSum'
        }
        /// <summary>
        /// Test the property 'Tx'
        /// </summary>
        [Test]
        public void TxTest()
        {
            // TODO unit test for the property 'Tx'
        }
        /// <summary>
        /// Test the property 'Confirmations'
        /// </summary>
        [Test]
        public void ConfirmationsTest()
        {
            // TODO unit test for the property 'Confirmations'
        }
        /// <summary>
        /// Test the property 'StatusCode'
        /// </summary>
        [Test]
        public void StatusCodeTest()
        {
            // TODO unit test for the property 'StatusCode'
        }
        /// <summary>
        /// Test the property 'ParentId'
        /// </summary>
        [Test]
        public void ParentIdTest()
        {
            // TODO unit test for the property 'ParentId'
        }

    }

}
