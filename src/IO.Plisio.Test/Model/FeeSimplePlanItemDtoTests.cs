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
    ///  Class for testing FeeSimplePlanItemDto
    /// </summary>
    [TestFixture]
    public class FeeSimplePlanItemDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeeSimplePlanItemDto
        //private FeeSimplePlanItemDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeeSimplePlanItemDto
            //instance = new FeeSimplePlanItemDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeeSimplePlanItemDto
        /// </summary>
        [Test]
        public void FeeSimplePlanItemDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeeSimplePlanItemDto
            //Assert.IsInstanceOfType<FeeSimplePlanItemDto> (instance, "variable 'instance' is a FeeSimplePlanItemDto");
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
