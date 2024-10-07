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
    ///  Class for testing HateoasLinkDto
    /// </summary>
    [TestFixture]
    public class HateoasLinkDtoTests
    {
        // TODO uncomment below to declare an instance variable for HateoasLinkDto
        //private HateoasLinkDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HateoasLinkDto
            //instance = new HateoasLinkDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HateoasLinkDto
        /// </summary>
        [Test]
        public void HateoasLinkDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HateoasLinkDto
            //Assert.IsInstanceOfType<HateoasLinkDto> (instance, "variable 'instance' is a HateoasLinkDto");
        }


        /// <summary>
        /// Test the property 'Href'
        /// </summary>
        [Test]
        public void HrefTest()
        {
            // TODO unit test for the property 'Href'
        }

    }

}
