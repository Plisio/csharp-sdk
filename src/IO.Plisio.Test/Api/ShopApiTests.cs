/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 * Contact: lead@plisio.net
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Plisio.Client;
using IO.Plisio.Api;
using IO.Plisio.Model;

namespace IO.Plisio.Test
{
    /// <summary>
    ///  Class for testing ShopApi
    /// </summary>
    [TestFixture]
    public class ShopApiTests
    {
        private ShopApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShopApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShopApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ShopApi
            //Assert.IsInstanceOfType(typeof(ShopApi), instance, "instance is a ShopApi");
        }

        /// <summary>
        /// Test ShopsGet
        /// </summary>
        [Test]
        public void ShopsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ShopsGet();
            //Assert.IsInstanceOf<ShopResponseDto> (response, "response is ShopResponseDto");
        }
    }

}
