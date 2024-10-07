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
    ///  Class for testing BalanceResponseDto
    /// </summary>
    [TestFixture]
    public class BalanceResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for BalanceResponseDto
        //private BalanceResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BalanceResponseDto
            //instance = new BalanceResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BalanceResponseDto
        /// </summary>
        [Test]
        public void BalanceResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BalanceResponseDto
            //Assert.IsInstanceOfType<BalanceResponseDto> (instance, "variable 'instance' is a BalanceResponseDto");
        }


        /// <summary>
        /// Test the property 'PsysCid'
        /// </summary>
        [Test]
        public void PsysCidTest()
        {
            // TODO unit test for the property 'PsysCid'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Test]
        public void BalanceTest()
        {
            // TODO unit test for the property 'Balance'
        }

    }

}
