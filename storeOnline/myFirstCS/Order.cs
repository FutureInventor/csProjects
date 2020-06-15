using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class Order
    {
        public Order(): this(0)
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }
        public override string ToString() => ShippingDate.ToString();
        public int OrderID { get; private set; }
        public int CustomerID { get; set; }
        public int ShippingAdressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? ShippingDate { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (null == ShippingDate) isValid = false;
            return isValid;
        }
        
    }
}
