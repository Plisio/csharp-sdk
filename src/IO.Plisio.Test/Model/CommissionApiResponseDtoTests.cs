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
    ///  Class for testing CommissionApiResponseDto
    /// </summary>
    [TestFixture]
    public class CommissionApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for CommissionApiResponseDto
        //private CommissionApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CommissionApiResponseDto
            //instance = new CommissionApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommissionApiResponseDto
        /// </summary>
        [Test]
        public void CommissionApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CommissionApiResponseDto
            //Assert.IsInstanceOfType<CommissionApiResponseDto> (instance, "variable 'instance' is a CommissionApiResponseDto");
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
