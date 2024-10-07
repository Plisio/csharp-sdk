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
    ///  Class for testing CryptocurrencyApiResponseDto
    /// </summary>
    [TestFixture]
    public class CryptocurrencyApiResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for CryptocurrencyApiResponseDto
        //private CryptocurrencyApiResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CryptocurrencyApiResponseDto
            //instance = new CryptocurrencyApiResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CryptocurrencyApiResponseDto
        /// </summary>
        [Test]
        public void CryptocurrencyApiResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CryptocurrencyApiResponseDto
            //Assert.IsInstanceOfType<CryptocurrencyApiResponseDto> (instance, "variable 'instance' is a CryptocurrencyApiResponseDto");
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
