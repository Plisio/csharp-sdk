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
    ///  Class for testing InvoiceSwitchApiResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceSwitchApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceSwitchApiResponseDto
        //private InvoiceSwitchApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceSwitchApiResponseDto
            //instance = new InvoiceSwitchApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceSwitchApiResponseDto
        /// </summary>
        [Test]
        public void InvoiceSwitchApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceSwitchApiResponseDto
            //Assert.IsInstanceOfType<InvoiceSwitchApiResponseDto> (instance, "variable 'instance' is a InvoiceSwitchApiResponseDto");
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
