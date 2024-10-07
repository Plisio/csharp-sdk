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
    ///  Class for testing HateoasLinksDto
    /// </summary>
    [TestFixture]
    public class HateoasLinksDtoTests
    {
        // TODO uncomment below to declare an instance variable for HateoasLinksDto
        //private HateoasLinksDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HateoasLinksDto
            //instance = new HateoasLinksDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HateoasLinksDto
        /// </summary>
        [Test]
        public void HateoasLinksDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HateoasLinksDto
            //Assert.IsInstanceOfType<HateoasLinksDto> (instance, "variable 'instance' is a HateoasLinksDto");
        }


        /// <summary>
        /// Test the property 'Self'
        /// </summary>
        [Test]
        public void SelfTest()
        {
            // TODO unit test for the property 'Self'
        }
        /// <summary>
        /// Test the property 'Next'
        /// </summary>
        [Test]
        public void NextTest()
        {
            // TODO unit test for the property 'Next'
        }
        /// <summary>
        /// Test the property 'Last'
        /// </summary>
        [Test]
        public void LastTest()
        {
            // TODO unit test for the property 'Last'
        }

    }

}
