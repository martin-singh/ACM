using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // ARRANGE
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            // ACT
            var actual = customerRepository.Retrieve(1);

            // ASSERT
            //Assert.AreEqual(expected, actual); // This will fail since a new instance of customer is created. 
            Assert.AreEqual(expected.CustomerId, actual.CustomerId); // We need to compare each property instead.
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
