using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storeOnline;

namespace CustomerTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RepositoryProductTest
    {
        [TestMethod]
        public void RetrevieValid()
        {
            var repositoryProduct = new PepositoryProduct();
            var expected = new Product(1)
            {
                ProductName = "Rose",
                CurrentPrice = 50
            };

            var actual = repositoryProduct.Retrive(1);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository = new PepositoryProduct();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 20,
                ProductName = "Sunflower",
                ProductDescription = "Yellow",
                HasChanges = true
            };
            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveMissPriceTest()
        {
            var productRepository = new PepositoryProduct();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Sunflower",
                ProductDescription = "Yellow",
                HasChanges = true
            };
            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(false, actual);
        }
    }
}
