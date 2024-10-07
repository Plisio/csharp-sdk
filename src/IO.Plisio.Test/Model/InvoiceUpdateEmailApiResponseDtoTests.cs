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
    ///  Class for testing InvoiceUpdateEmailApiResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceUpdateEmailApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceUpdateEmailApiResponseDto
        //private InvoiceUpdateEmailApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceUpdateEmailApiResponseDto
            //instance = new InvoiceUpdateEmailApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceUpdateEmailApiResponseDto
        /// </summary>
        [Test]
        public void InvoiceUpdateEmailApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceUpdateEmailApiResponseDto
            //Assert.IsInstanceOfType<InvoiceUpdateEmailApiResponseDto> (instance, "variable 'instance' is a InvoiceUpdateEmailApiResponseDto");
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
