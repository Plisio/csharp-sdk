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
    ///  Class for testing FeePlanApiResponseDto
    /// </summary>
    [TestFixture]
    public class FeePlanApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanApiResponseDto
        //private FeePlanApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanApiResponseDto
            //instance = new FeePlanApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanApiResponseDto
        /// </summary>
        [Test]
        public void FeePlanApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanApiResponseDto
            //Assert.IsInstanceOfType<FeePlanApiResponseDto> (instance, "variable 'instance' is a FeePlanApiResponseDto");
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
