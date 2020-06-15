using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class RepositoryOrder
    {
        public Order Retrive(int orderID)
        {
            Order order = new Order(orderID);
            if (orderID == 10)
            {
                order.ShippingDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            int number = 42;
            Console.WriteLine(order.ToString());
            Console.WriteLine(number.ToString());
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
