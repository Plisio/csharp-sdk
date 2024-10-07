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
    ///  Class for testing ShopResponseDto
    /// </summary>
    [TestFixture]
    public class ShopResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for ShopResponseDto
        //private ShopResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShopResponseDto
            //instance = new ShopResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShopResponseDto
        /// </summary>
        [Test]
        public void ShopResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ShopResponseDto
            //Assert.IsInstanceOfType<ShopResponseDto> (instance, "variable 'instance' is a ShopResponseDto");
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
