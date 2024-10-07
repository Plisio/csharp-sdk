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
    ///  Class for testing FeeApiResponseDto
    /// </summary>
    [TestFixture]
    public class FeeApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeeApiResponseDto
        //private FeeApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeeApiResponseDto
            //instance = new FeeApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeeApiResponseDto
        /// </summary>
        [Test]
        public void FeeApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeeApiResponseDto
            //Assert.IsInstanceOfType<FeeApiResponseDto> (instance, "variable 'instance' is a FeeApiResponseDto");
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
