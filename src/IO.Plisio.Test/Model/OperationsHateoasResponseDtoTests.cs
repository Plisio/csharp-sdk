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
    ///  Class for testing OperationsHateoasResponseDto
    /// </summary>
    [TestFixture]
    public class OperationsHateoasResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for OperationsHateoasResponseDto
        //private OperationsHateoasResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OperationsHateoasResponseDto
            //instance = new OperationsHateoasResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationsHateoasResponseDto
        /// </summary>
        [Test]
        public void OperationsHateoasResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OperationsHateoasResponseDto
            //Assert.IsInstanceOfType<OperationsHateoasResponseDto> (instance, "variable 'instance' is a OperationsHateoasResponseDto");
        }


        /// <summary>
        /// Test the property 'Operations'
        /// </summary>
        [Test]
        public void OperationsTest()
        {
            // TODO unit test for the property 'Operations'
        }
        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }
        /// <summary>
        /// Test the property 'Meta'
        /// </summary>
        [Test]
        public void MetaTest()
        {
            // TODO unit test for the property 'Meta'
        }

    }

}
