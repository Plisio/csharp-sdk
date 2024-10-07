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
    ///  Class for testing BalanceApiResponseDto
    /// </summary>
    [TestFixture]
    public class BalanceApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for BalanceApiResponseDto
        //private BalanceApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BalanceApiResponseDto
            //instance = new BalanceApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BalanceApiResponseDto
        /// </summary>
        [Test]
        public void BalanceApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BalanceApiResponseDto
            //Assert.IsInstanceOfType<BalanceApiResponseDto> (instance, "variable 'instance' is a BalanceApiResponseDto");
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
