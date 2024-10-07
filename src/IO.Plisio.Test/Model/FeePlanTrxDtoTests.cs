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
    ///  Class for testing FeePlanTrxDto
    /// </summary>
    [TestFixture]
    public class FeePlanTrxDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanTrxDto
        //private FeePlanTrxDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanTrxDto
            //instance = new FeePlanTrxDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanTrxDto
        /// </summary>
        [Test]
        public void FeePlanTrxDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanTrxDto
            //Assert.IsInstanceOfType<FeePlanTrxDto> (instance, "variable 'instance' is a FeePlanTrxDto");
        }


        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}
