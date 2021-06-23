using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullName_Valid()
        {
            // ARRANGE
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            // ACT
            string actual = customer.FullName;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_FirstNameEmpty()
        {
            // ARRANGE
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            // ACT
            string actual = customer.FullName;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullName_LastNameEmpty()
        {
            // ARRANGE
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            // ACT
            string actual = customer.FullName;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // ARRANGE
            Customer cust1 = new Customer();
            cust1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            Customer cust2 = new Customer();
            cust2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            Customer cust3 = new Customer();
            cust3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            int expected = 3;

            // ACT
            int actual = Customer.InstanceCount;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
