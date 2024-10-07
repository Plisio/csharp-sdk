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
    ///  Class for testing InvoiceDetailsResponseDto
    /// </summary>
    [TestFixture]
    public class InvoiceDetailsResponseDtoTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceDetailsResponseDto
        //private InvoiceDetailsResponseDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceDetailsResponseDto
            //instance = new InvoiceDetailsResponseDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceDetailsResponseDto
        /// </summary>
        [Test]
        public void InvoiceDetailsResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceDetailsResponseDto
            //Assert.IsInstanceOfType<InvoiceDetailsResponseDto> (instance, "variable 'instance' is a InvoiceDetailsResponseDto");
        }


        /// <summary>
        /// Test the property 'Invoice'
        /// </summary>
        [Test]
        public void InvoiceTest()
        {
            // TODO unit test for the property 'Invoice'
        }
        /// <summary>
        /// Test the property 'ActiveInvoiceId'
        /// </summary>
        [Test]
        public void ActiveInvoiceIdTest()
        {
            // TODO unit test for the property 'ActiveInvoiceId'
        }
        /// <summary>
        /// Test the property 'Shop'
        /// </summary>
        [Test]
        public void ShopTest()
        {
            // TODO unit test for the property 'Shop'
        }
        /// <summary>
        /// Test the property 'Paysys'
        /// </summary>
        [Test]
        public void PaysysTest()
        {
            // TODO unit test for the property 'Paysys'
        }
        /// <summary>
        /// Test the property 'AllowedPsysCids'
        /// </summary>
        [Test]
        public void AllowedPsysCidsTest()
        {
            // TODO unit test for the property 'AllowedPsysCids'
        }

    }

}
