using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storeOnline;

namespace CustomerTest
{
    [TestClass]
    public class RepositoryCustomerTest
    {
        [TestMethod]
        public void RetrevieValid()
        {
            var repositoryCustomer = new RepositoryCustomer();
            var expected = new Customer(1)
            {
                Email = "bilboB@gmail.com",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "os. 700-lecia",
                        StreetLine2 = "44/22",
                        City = "Zywiec",
                        State = "Slaskie",
                        Country = "Poland",
                        PostalCode = 34300
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "os. 1000-lecia",
                        StreetLine2 = "12/45",
                        City = "Zywiec",
                        State = "Slaskie",
                        Country = "Poland",
                    PostalCode = 34300
                    }
                }
            };

            var actual = repositoryCustomer.Retrive(1);

            Assert.AreEqual(expected.Email, actual.Email);
            for (int i = 0; i <= 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            }
        }
    }
}
