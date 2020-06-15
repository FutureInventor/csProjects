using storeOnlineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class Customer : EntityBase, ILoggable
    {
		public Customer(): this(0)
		{
			
		}
		public Customer(int customerID)
		{
			CustomerID = customerID;
			AddressList = new List<Address>();
		}

		//public string Log()
		//{
		//	var logString = CustomerID + ": " +
		//					FullName + ": " +
		//					"Email: " + Email + ": " +
		//					"Status: " + EnityState.ToString();
		//	return logString;
		//}
		//same with lambda operator:
		public string Log() =>
			$"{CustomerID}: {FullName} Email: {Email} Status: {EnityState.ToString()}";

		private string _LastName;

		public Address WorkAdress { get; set; }
		public Address HomeAdress { get; set; } // public Address WorkAdress { get; set; } public Address HomeAdress { get; set; }
		public List<Address> AddressList { get; set; }

		public override string ToString() => FullName;
		public string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}
		public string FirstName { get; set; }

		public string FullName
		{
			get
			{
				string fullName = FirstName;
				if (!string.IsNullOrWhiteSpace(LastName))
				{
					if (!string.IsNullOrWhiteSpace(fullName))
					{
						fullName += ", ";
					}
					return fullName += LastName;
				}
				return fullName;
			}
		}
		public static int InstanceCount { get; set; }
		public int CustomerID { get; private set; }
		public string Email { get; set; }

		public override bool Validate()
		{
			var isValid = true;
			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			return isValid;
		}


	}
}
