using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storeOnline;

namespace CustomerTest
{
    [TestClass]
    public class RepositoryOrderTest
    {
        [TestMethod]
        public void RetrevieValid()
        {
            var repositoryOrder = new RepositoryOrder();
            var expected = new Order(10)
            {
                ShippingDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
        };

            var actual = repositoryOrder.Retrive(10);

            Assert.AreEqual(expected.ShippingDate, actual.ShippingDate);
        }
    }
}
