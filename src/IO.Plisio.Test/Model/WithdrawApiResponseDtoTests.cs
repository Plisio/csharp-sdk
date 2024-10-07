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
    ///  Class for testing WithdrawApiResponseDto
    /// </summary>
    [TestFixture]
    public class WithdrawApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for WithdrawApiResponseDto
        //private WithdrawApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WithdrawApiResponseDto
            //instance = new WithdrawApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WithdrawApiResponseDto
        /// </summary>
        [Test]
        public void WithdrawApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WithdrawApiResponseDto
            //Assert.IsInstanceOfType<WithdrawApiResponseDto> (instance, "variable 'instance' is a WithdrawApiResponseDto");
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
