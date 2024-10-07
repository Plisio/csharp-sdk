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
    ///  Class for testing FeePlanDto
    /// </summary>
    [TestFixture]
    public class FeePlanDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanDto
        //private FeePlanDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanDto
            //instance = new FeePlanDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanDto
        /// </summary>
        [Test]
        public void FeePlanDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanDto
            //Assert.IsInstanceOfType<FeePlanDto> (instance, "variable 'instance' is a FeePlanDto");
        }


        /// <summary>
        /// Test the property 'Economy'
        /// </summary>
        [Test]
        public void EconomyTest()
        {
            // TODO unit test for the property 'Economy'
        }
        /// <summary>
        /// Test the property 'Normal'
        /// </summary>
        [Test]
        public void NormalTest()
        {
            // TODO unit test for the property 'Normal'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }

    }

}
