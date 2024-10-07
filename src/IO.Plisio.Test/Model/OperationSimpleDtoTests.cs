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
    ///  Class for testing OperationSimpleDto
    /// </summary>
    [TestFixture]
    public class OperationSimpleDtoTests
    {
        // TODO uncomment below to declare an instance variable for OperationSimpleDto
        //private OperationSimpleDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OperationSimpleDto
            //instance = new OperationSimpleDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationSimpleDto
        /// </summary>
        [Test]
        public void OperationSimpleDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OperationSimpleDto
            //Assert.IsInstanceOfType<OperationSimpleDto> (instance, "variable 'instance' is a OperationSimpleDto");
        }


        /// <summary>
        /// Test the property 'ShopId'
        /// </summary>
        [Test]
        public void ShopIdTest()
        {
            // TODO unit test for the property 'ShopId'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'TxUrl'
        /// </summary>
        [Test]
        public void TxUrlTest()
        {
            // TODO unit test for the property 'TxUrl'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
