using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }
        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (0 >= ProductID) isValid = false;
            if (0 >= Quantity) isValid = false;
            if (null == PurchasePrice) isValid = false;
            return isValid;
        }
        public OrderItem Retrive(int odrerItemID)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrive()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
