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
    ///  Class for testing FeePlanCommonDto
    /// </summary>
    [TestFixture]
    public class FeePlanCommonDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanCommonDto
        //private FeePlanCommonDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanCommonDto
            //instance = new FeePlanCommonDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanCommonDto
        /// </summary>
        [Test]
        public void FeePlanCommonDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanCommonDto
            //Assert.IsInstanceOfType<FeePlanCommonDto> (instance, "variable 'instance' is a FeePlanCommonDto");
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

    }

}
