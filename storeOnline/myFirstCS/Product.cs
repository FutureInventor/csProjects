using storeOnlineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOnline
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }
        public string Log() =>
            $"{ProductID}: {ProductName} Detail: {ProductDescription} Status: {EnityState.ToString()}";

        public override string ToString() => ProductName;
        public int ProductID { get; private set; }
        private string productName;

        public string ProductName
        {
            get 
            {
                return productName.InsertSpaces();
            }
            set { productName = value; }
        }

        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (null == CurrentPrice) isValid = false;
            return isValid;
        }
       

    }
}
