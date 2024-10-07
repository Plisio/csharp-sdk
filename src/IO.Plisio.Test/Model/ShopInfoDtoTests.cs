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
    ///  Class for testing ShopInfoDto
    /// </summary>
    [TestFixture]
    public class ShopInfoDtoTests
    {
        // TODO uncomment below to declare an instance variable for ShopInfoDto
        //private ShopInfoDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShopInfoDto
            //instance = new ShopInfoDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShopInfoDto
        /// </summary>
        [Test]
        public void ShopInfoDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ShopInfoDto
            //Assert.IsInstanceOfType<ShopInfoDto> (instance, "variable 'instance' is a ShopInfoDto");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Test]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }
        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Test]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }
        /// <summary>
        /// Test the property 'SuccessUrl'
        /// </summary>
        [Test]
        public void SuccessUrlTest()
        {
            // TODO unit test for the property 'SuccessUrl'
        }
        /// <summary>
        /// Test the property 'FailedUrl'
        /// </summary>
        [Test]
        public void FailedUrlTest()
        {
            // TODO unit test for the property 'FailedUrl'
        }
        /// <summary>
        /// Test the property 'AllowRenew'
        /// </summary>
        [Test]
        public void AllowRenewTest()
        {
            // TODO unit test for the property 'AllowRenew'
        }

    }

}
