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
    ///  Class for testing CommissionResponseSimpleErrorDto
    /// </summary>
    [TestFixture]
    public class CommissionResponseSimpleErrorDtoTests
    {
        // TODO uncomment below to declare an instance variable for CommissionResponseSimpleErrorDto
        //private CommissionResponseSimpleErrorDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CommissionResponseSimpleErrorDto
            //instance = new CommissionResponseSimpleErrorDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommissionResponseSimpleErrorDto
        /// </summary>
        [Test]
        public void CommissionResponseSimpleErrorDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CommissionResponseSimpleErrorDto
            //Assert.IsInstanceOfType<CommissionResponseSimpleErrorDto> (instance, "variable 'instance' is a CommissionResponseSimpleErrorDto");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }
        /// <summary>
        /// Test the property 'Balance'
        /// </summary>
        [Test]
        public void BalanceTest()
        {
            // TODO unit test for the property 'Balance'
        }
        /// <summary>
        /// Test the property 'Cid'
        /// </summary>
        [Test]
        public void CidTest()
        {
            // TODO unit test for the property 'Cid'
        }

    }

}
