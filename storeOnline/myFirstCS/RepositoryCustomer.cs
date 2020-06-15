using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class RepositoryCustomer
    {
        public  RepositoryCustomer()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrive(int customerID)
        {
            Customer customer = new Customer(customerID);
            if (customerID == 1)
            {
                customer.Email = "bilboB@gmail.com";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetriveByCostumerID(customerID).
                        ToList();  
            }
            Console.WriteLine(customer.ToString());
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
