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
    ///  Class for testing CommissionResponseBoostDto
    /// </summary>
    [TestFixture]
    public class CommissionResponseBoostDtoTests
    {
        // TODO uncomment below to declare an instance variable for CommissionResponseBoostDto
        //private CommissionResponseBoostDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CommissionResponseBoostDto
            //instance = new CommissionResponseBoostDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommissionResponseBoostDto
        /// </summary>
        [Test]
        public void CommissionResponseBoostDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CommissionResponseBoostDto
            //Assert.IsInstanceOfType<CommissionResponseBoostDto> (instance, "variable 'instance' is a CommissionResponseBoostDto");
        }


        /// <summary>
        /// Test the property 'MinFeeRate'
        /// </summary>
        [Test]
        public void MinFeeRateTest()
        {
            // TODO unit test for the property 'MinFeeRate'
        }
        /// <summary>
        /// Test the property 'MaxFeeRate'
        /// </summary>
        [Test]
        public void MaxFeeRateTest()
        {
            // TODO unit test for the property 'MaxFeeRate'
        }

    }

}
