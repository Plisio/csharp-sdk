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
    ///  Class for testing FeePlanEthDto
    /// </summary>
    [TestFixture]
    public class FeePlanEthDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeePlanEthDto
        //private FeePlanEthDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeePlanEthDto
            //instance = new FeePlanEthDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeePlanEthDto
        /// </summary>
        [Test]
        public void FeePlanEthDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeePlanEthDto
            //Assert.IsInstanceOfType<FeePlanEthDto> (instance, "variable 'instance' is a FeePlanEthDto");
        }


        /// <summary>
        /// Test the property 'GasLimit'
        /// </summary>
        [Test]
        public void GasLimitTest()
        {
            // TODO unit test for the property 'GasLimit'
        }
        /// <summary>
        /// Test the property 'GasPrice'
        /// </summary>
        [Test]
        public void GasPriceTest()
        {
            // TODO unit test for the property 'GasPrice'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'FeeUnit'
        /// </summary>
        [Test]
        public void FeeUnitTest()
        {
            // TODO unit test for the property 'FeeUnit'
        }
        /// <summary>
        /// Test the property 'Nonce'
        /// </summary>
        [Test]
        public void NonceTest()
        {
            // TODO unit test for the property 'Nonce'
        }

    }

}
