using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTest_Valid()
        {
            // ARRANGE
            string source = "SonicScrewdriver";
            
            string expected = "Sonic Screwdriver";

            // ACT
            var actual = StringHandler.InsertSpaces(source);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTest_WithExistingSpace()
        {
            // ARRANGE
            string source = "Sonic Screwdriver";

            string expected = "Sonic Screwdriver";

            // ACT
            var actual = StringHandler.InsertSpaces(source);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

    }
}
