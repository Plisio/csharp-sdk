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
    ///  Class for testing OperationApiResponseDto
    /// </summary>
    [TestFixture]
    public class OperationApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for OperationApiResponseDto
        //private OperationApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OperationApiResponseDto
            //instance = new OperationApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationApiResponseDto
        /// </summary>
        [Test]
        public void OperationApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OperationApiResponseDto
            //Assert.IsInstanceOfType<OperationApiResponseDto> (instance, "variable 'instance' is a OperationApiResponseDto");
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
