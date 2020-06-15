using System;
using System.Collections.Generic;
using storeOnlineLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storeOnline;

namespace storeOnlineLibraryTest
{
    [TestClass]
    public class LoggableTest
    {
        [TestMethod]
        public void WriteToFile()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                Email = "bilboB@gmail.com",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                CurrentPrice = 20,
                ProductName = "Sunflower",
                ProductDescription = "Yellow"
            };
            changedItems.Add(product);
            LoggingService.WriteToFile(changedItems);
        }
    }
}
