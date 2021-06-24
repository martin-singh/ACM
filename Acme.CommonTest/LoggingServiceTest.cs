using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // ARRANGE
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6m
            };
            changedItems.Add(product);

            // ACT
            LoggingService.WriteToFile(changedItems);

            // ASSERT
            // Nothing here to assert.
        }

    }
}
