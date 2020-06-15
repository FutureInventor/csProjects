using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    class AddressRepository
    {
        public Address Retrive(int addressID)
        {
            Address address = new Address(addressID);

            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "osiedle";
                address.StreetLine2 = "Mlodych";
                address.City = "Zywiec";
                address.State = "Slask";
                address.Country = "Poland";
                address.PostalCode = 34300;
            }
            return address;
        }
        public IEnumerable<Address> RetriveByCostumerID(int customerID)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "os. 700-lecia",
                StreetLine2 = "44/22",
                City = "Zywiec",
                State = "Slaskie",
                Country = "Poland",
                PostalCode = 34300
            };
            addressList.Add(address);

            address = new Address(1)
            {
                AddressType = 2,
                StreetLine1 = "os. 1000-lecia",
                StreetLine2 = "12/45",
                City = "Zywiec",
                State = "Slaskie",
                Country = "Poland",
                PostalCode = 34300
            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
