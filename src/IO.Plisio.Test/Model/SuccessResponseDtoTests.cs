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
    ///  Class for testing SuccessResponseDto
    /// </summary>
    [TestFixture]
    public class SuccessResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for SuccessResponseDto
        //private SuccessResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SuccessResponseDto
            //instance = new SuccessResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SuccessResponseDto
        /// </summary>
        [Test]
        public void SuccessResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SuccessResponseDto
            //Assert.IsInstanceOfType<SuccessResponseDto> (instance, "variable 'instance' is a SuccessResponseDto");
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

    }

}
