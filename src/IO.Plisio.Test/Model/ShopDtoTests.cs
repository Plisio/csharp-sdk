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
    ///  Class for testing ShopDto
    /// </summary>
    [TestFixture]
    public class ShopDtoTests
    {
        // TODO uncomment below to declare an instance variable for ShopDto
        //private ShopDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShopDto
            //instance = new ShopDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShopDto
        /// </summary>
        [Test]
        public void ShopDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ShopDto
            //Assert.IsInstanceOfType<ShopDto> (instance, "variable 'instance' is a ShopDto");
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
        /// Test the property 'CommissionPayment'
        /// </summary>
        [Test]
        public void CommissionPaymentTest()
        {
            // TODO unit test for the property 'CommissionPayment'
        }
        /// <summary>
        /// Test the property 'WhiteLabel'
        /// </summary>
        [Test]
        public void WhiteLabelTest()
        {
            // TODO unit test for the property 'WhiteLabel'
        }
        /// <summary>
        /// Test the property 'ExtraCommission'
        /// </summary>
        [Test]
        public void ExtraCommissionTest()
        {
            // TODO unit test for the property 'ExtraCommission'
        }
        /// <summary>
        /// Test the property 'Verified'
        /// </summary>
        [Test]
        public void VerifiedTest()
        {
            // TODO unit test for the property 'Verified'
        }

    }

}
