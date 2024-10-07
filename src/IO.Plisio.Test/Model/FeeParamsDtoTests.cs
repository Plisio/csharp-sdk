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
    ///  Class for testing FeeParamsDto
    /// </summary>
    [TestFixture]
    public class FeeParamsDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeeParamsDto
        //private FeeParamsDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeeParamsDto
            //instance = new FeeParamsDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeeParamsDto
        /// </summary>
        [Test]
        public void FeeParamsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeeParamsDto
            //Assert.IsInstanceOfType<FeeParamsDto> (instance, "variable 'instance' is a FeeParamsDto");
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
        /// Test the property 'Plan'
        /// </summary>
        [Test]
        public void PlanTest()
        {
            // TODO unit test for the property 'Plan'
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
