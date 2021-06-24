using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // ARRANGE
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 24, 10, 00, 00, new TimeSpan(7, 0, 0))
        };

            // ACT
            var actual = orderRepository.Retrieve(10);

            // ASSERT
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
