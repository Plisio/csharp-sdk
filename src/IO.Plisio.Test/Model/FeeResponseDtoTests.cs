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
    ///  Class for testing FeeResponseDto
    /// </summary>
    [TestFixture]
    public class FeeResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for FeeResponseDto
        //private FeeResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeeResponseDto
            //instance = new FeeResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeeResponseDto
        /// </summary>
        [Test]
        public void FeeResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeeResponseDto
            //Assert.IsInstanceOfType<FeeResponseDto> (instance, "variable 'instance' is a FeeResponseDto");
        }


        /// <summary>
        /// Test the property 'Fee'
        /// </summary>
        [Test]
        public void FeeTest()
        {
            // TODO unit test for the property 'Fee'
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
        /// Test the property 'Plan'
        /// </summary>
        [Test]
        public void PlanTest()
        {
            // TODO unit test for the property 'Plan'
        }

    }

}
