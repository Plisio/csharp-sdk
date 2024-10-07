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
    ///  Class for testing InvoicePaysysContractsGroupDto
    /// </summary>
    [TestFixture]
    public class InvoicePaysysContractsGroupDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoicePaysysContractsGroupDto
        //private InvoicePaysysContractsGroupDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoicePaysysContractsGroupDto
            //instance = new InvoicePaysysContractsGroupDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoicePaysysContractsGroupDto
        /// </summary>
        [Test]
        public void InvoicePaysysContractsGroupDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoicePaysysContractsGroupDto
            //Assert.IsInstanceOfType<InvoicePaysysContractsGroupDto> (instance, "variable 'instance' is a InvoicePaysysContractsGroupDto");
        }


        /// <summary>
        /// Test the property 'ContractGroupCid'
        /// </summary>
        [Test]
        public void ContractGroupCidTest()
        {
            // TODO unit test for the property 'ContractGroupCid'
        }
        /// <summary>
        /// Test the property 'ContractGroupIcon'
        /// </summary>
        [Test]
        public void ContractGroupIconTest()
        {
            // TODO unit test for the property 'ContractGroupIcon'
        }
        /// <summary>
        /// Test the property 'ContractGroupName'
        /// </summary>
        [Test]
        public void ContractGroupNameTest()
        {
            // TODO unit test for the property 'ContractGroupName'
        }

    }

}
