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
    ///  Class for testing FeePlanTonDto
    /// </summary>
    [TestFixture]
    public class FeePlanTonDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanTonDto
        //private FeePlanTonDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanTonDto
            //instance = new FeePlanTonDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanTonDto
        /// </summary>
        [Test]
        public void FeePlanTonDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanTonDto
            //Assert.IsInstanceOfType<FeePlanTonDto> (instance, "variable 'instance' is a FeePlanTonDto");
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
