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
    ///  Class for testing InvoiceDetailsApiResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceDetailsApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceDetailsApiResponseDto
        //private InvoiceDetailsApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceDetailsApiResponseDto
            //instance = new InvoiceDetailsApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceDetailsApiResponseDto
        /// </summary>
        [Test]
        public void InvoiceDetailsApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceDetailsApiResponseDto
            //Assert.IsInstanceOfType<InvoiceDetailsApiResponseDto> (instance, "variable 'instance' is a InvoiceDetailsApiResponseDto");
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
