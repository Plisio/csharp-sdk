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
    ///  Class for testing InvoicePaysysDto
    /// </summary>
    [TestFixture]
    public class InvoicePaysysDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoicePaysysDto
        //private InvoicePaysysDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoicePaysysDto
            //instance = new InvoicePaysysDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoicePaysysDto
        /// </summary>
        [Test]
        public void InvoicePaysysDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoicePaysysDto
            //Assert.IsInstanceOfType<InvoicePaysysDto> (instance, "variable 'instance' is a InvoicePaysysDto");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }

    }

}
