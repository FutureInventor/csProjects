using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storeOnline;

namespace CustomerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arange
            Customer c1 = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            Customer.InstanceCount += 1;
            Customer c2 = new Customer
            {
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            Customer.InstanceCount += 1;
            Customer c3 = new Customer
            {
                FirstName = "Orion",
                LastName = "Baggins"
            };
            Customer.InstanceCount += 1;

            //Act
            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void FullNameTestNoLastName()
        {
            // Arange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValiateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins"
            };
            var expected = true;
            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotValidateValid()
        {
            var customer = new Customer
            {
                LastName = ""
            };
            var expected = false;
            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }
    }
}
