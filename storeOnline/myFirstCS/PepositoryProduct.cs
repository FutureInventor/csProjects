using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class PepositoryProduct
    {
        public Product Retrive(int productID)
        {
            Product product = new Product(productID);
            if (productID == 1)
            {
                product.ProductName = "Rose";
                product.CurrentPrice = 50;
                product.ProductDescription = "Red";
            }
            Console.WriteLine(product.ToString());
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        Object myObject = new Object();
        
    }
}
