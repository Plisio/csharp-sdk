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
    ///  Class for testing OperationsApiResponseDto
    /// </summary>
    [TestFixture]
    public class OperationsApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for OperationsApiResponseDto
        //private OperationsApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OperationsApiResponseDto
            //instance = new OperationsApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationsApiResponseDto
        /// </summary>
        [Test]
        public void OperationsApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OperationsApiResponseDto
            //Assert.IsInstanceOfType<OperationsApiResponseDto> (instance, "variable 'instance' is a OperationsApiResponseDto");
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
