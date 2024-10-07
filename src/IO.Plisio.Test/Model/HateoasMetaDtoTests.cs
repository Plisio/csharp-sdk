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
    ///  Class for testing HateoasMetaDto
    /// </summary>
    [TestFixture]
    public class HateoasMetaDtoTests
    {
        // TODO uncomment below to declare an instance variable for HateoasMetaDto
        //private HateoasMetaDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HateoasMetaDto
            //instance = new HateoasMetaDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HateoasMetaDto
        /// </summary>
        [Test]
        public void HateoasMetaDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HateoasMetaDto
            //Assert.IsInstanceOfType<HateoasMetaDto> (instance, "variable 'instance' is a HateoasMetaDto");
        }


        /// <summary>
        /// Test the property 'TotalCount'
        /// </summary>
        [Test]
        public void TotalCountTest()
        {
            // TODO unit test for the property 'TotalCount'
        }
        /// <summary>
        /// Test the property 'PageCount'
        /// </summary>
        [Test]
        public void PageCountTest()
        {
            // TODO unit test for the property 'PageCount'
        }
        /// <summary>
        /// Test the property 'CurrentPage'
        /// </summary>
        [Test]
        public void CurrentPageTest()
        {
            // TODO unit test for the property 'CurrentPage'
        }
        /// <summary>
        /// Test the property 'PerPage'
        /// </summary>
        [Test]
        public void PerPageTest()
        {
            // TODO unit test for the property 'PerPage'
        }

    }

}
