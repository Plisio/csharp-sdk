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
    ///  Class for testing InvoiceSimpleResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceSimpleResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceSimpleResponseDto
        //private InvoiceSimpleResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceSimpleResponseDto
            //instance = new InvoiceSimpleResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceSimpleResponseDto
        /// </summary>
        [Test]
        public void InvoiceSimpleResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceSimpleResponseDto
            //Assert.IsInstanceOfType<InvoiceSimpleResponseDto> (instance, "variable 'instance' is a InvoiceSimpleResponseDto");
        }


        /// <summary>
        /// Test the property 'TxnId'
        /// </summary>
        [Test]
        public void TxnIdTest()
        {
            // TODO unit test for the property 'TxnId'
        }
        /// <summary>
        /// Test the property 'InvoiceUrl'
        /// </summary>
        [Test]
        public void InvoiceUrlTest()
        {
            // TODO unit test for the property 'InvoiceUrl'
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
