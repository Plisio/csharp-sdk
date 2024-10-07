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
    ///  Class for testing FeePlanBtcDto
    /// </summary>
    [TestFixture]
    public class FeePlanBtcDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanBtcDto
        //private FeePlanBtcDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanBtcDto
            //instance = new FeePlanBtcDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanBtcDto
        /// </summary>
        [Test]
        public void FeePlanBtcDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanBtcDto
            //Assert.IsInstanceOfType<FeePlanBtcDto> (instance, "variable 'instance' is a FeePlanBtcDto");
        }


        /// <summary>
        /// Test the property 'ConfTarget'
        /// </summary>
        [Test]
        public void ConfTargetTest()
        {
            // TODO unit test for the property 'ConfTarget'
        }
        /// <summary>
        /// Test the property 'FeeRate'
        /// </summary>
        [Test]
        public void FeeRateTest()
        {
            // TODO unit test for the property 'FeeRate'
        }
        /// <summary>
        /// Test the property 'FeeRateUnit'
        /// </summary>
        [Test]
        public void FeeRateUnitTest()
        {
            // TODO unit test for the property 'FeeRateUnit'
        }

    }

}
