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
    ///  Class for testing InvoiceWhiteLabelResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceWhiteLabelResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceWhiteLabelResponseDto
        //private InvoiceWhiteLabelResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceWhiteLabelResponseDto
            //instance = new InvoiceWhiteLabelResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceWhiteLabelResponseDto
        /// </summary>
        [Test]
        public void InvoiceWhiteLabelResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceWhiteLabelResponseDto
            //Assert.IsInstanceOfType<InvoiceWhiteLabelResponseDto> (instance, "variable 'instance' is a InvoiceWhiteLabelResponseDto");
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
