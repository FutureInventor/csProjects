﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressID)
        {
            AddressID = addressID;
        }
        public int AddressID { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == 0) isValid = false;
            return isValid;
        }

    }
}