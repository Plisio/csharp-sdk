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
    ///  Class for testing InvoiceCallbackExtendedResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceCallbackExtendedResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceCallbackExtendedResponseDto
        //private InvoiceCallbackExtendedResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceCallbackExtendedResponseDto
            //instance = new InvoiceCallbackExtendedResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceCallbackExtendedResponseDto
        /// </summary>
        [Test]
        public void InvoiceCallbackExtendedResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceCallbackExtendedResponseDto
            //Assert.IsInstanceOfType<InvoiceCallbackExtendedResponseDto> (instance, "variable 'instance' is a InvoiceCallbackExtendedResponseDto");
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
        /// Test the property 'PendingAmount'
        /// </summary>
        [Test]
        public void PendingAmountTest()
        {
            // TODO unit test for the property 'PendingAmount'
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
        /// Test the property 'ExpectedConfirmations'
        /// </summary>
        [Test]
        public void ExpectedConfirmationsTest()
        {
            // TODO unit test for the property 'ExpectedConfirmations'
        }
        /// <summary>
        /// Test the property 'QrCode'
        /// </summary>
        [Test]
        public void QrCodeTest()
        {
            // TODO unit test for the property 'QrCode'
        }
        /// <summary>
        /// Test the property 'VerifyHash'
        /// </summary>
        [Test]
        public void VerifyHashTest()
        {
            // TODO unit test for the property 'VerifyHash'
        }
        /// <summary>
        /// Test the property 'InvoiceCommission'
        /// </summary>
        [Test]
        public void InvoiceCommissionTest()
        {
            // TODO unit test for the property 'InvoiceCommission'
        }
        /// <summary>
        /// Test the property 'InvoiceSum'
        /// </summary>
        [Test]
        public void InvoiceSumTest()
        {
            // TODO unit test for the property 'InvoiceSum'
        }
        /// <summary>
        /// Test the property 'InvoiceTotalSum'
        /// </summary>
        [Test]
        public void InvoiceTotalSumTest()
        {
            // TODO unit test for the property 'InvoiceTotalSum'
        }

    }

}
