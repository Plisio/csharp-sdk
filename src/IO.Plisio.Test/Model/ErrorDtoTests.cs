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
    ///  Class for testing ErrorDto
    /// </summary>
    [TestFixture]
    public class ErrorDtoTests
    {
        // TODO uncomment below to declare an instance variable for ErrorDto
        //private ErrorDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ErrorDto
            //instance = new ErrorDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ErrorDto
        /// </summary>
        [Test]
        public void ErrorDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ErrorDto
            //Assert.IsInstanceOfType<ErrorDto> (instance, "variable 'instance' is a ErrorDto");
        }


        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

    }

}
