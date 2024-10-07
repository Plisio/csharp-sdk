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
    ///  Class for testing InvoiceUpdateEmailResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceUpdateEmailResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceUpdateEmailResponseDto
        //private InvoiceUpdateEmailResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceUpdateEmailResponseDto
            //instance = new InvoiceUpdateEmailResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceUpdateEmailResponseDto
        /// </summary>
        [Test]
        public void InvoiceUpdateEmailResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceUpdateEmailResponseDto
            //Assert.IsInstanceOfType<InvoiceUpdateEmailResponseDto> (instance, "variable 'instance' is a InvoiceUpdateEmailResponseDto");
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

    }

}
