﻿using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // ARRANGE
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96m
            };

            // ACT
            var actual = productRepository.Retrieve(2);

            // ASSERT
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTest_Valid()
        {
            // ARRANGE
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 18m,
                HasChanged = true
            };

            // ACT
            var actual = productRepository.Save(updatedProduct);

            // ASSERT
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTest_MissingPrice()
        {
            // ARRANGE
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = null,
                HasChanged = true
            };

            // ACT
            var actual = productRepository.Save(updatedProduct);

            // ASSERT
            Assert.AreEqual(false, actual);
        }
    }
}
