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
    ///  Class for testing FeePlanXmrDto
    /// </summary>
    [TestFixture]
    public class FeePlanXmrDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanXmrDto
        //private FeePlanXmrDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanXmrDto
            //instance = new FeePlanXmrDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanXmrDto
        /// </summary>
        [Test]
        public void FeePlanXmrDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanXmrDto
            //Assert.IsInstanceOfType<FeePlanXmrDto> (instance, "variable 'instance' is a FeePlanXmrDto");
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
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'FeeUnit'
        /// </summary>
        [Test]
        public void FeeUnitTest()
        {
            // TODO unit test for the property 'FeeUnit'
        }

    }

}
