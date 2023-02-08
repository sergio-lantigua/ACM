using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;  
        }

        public int ProductId { get; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = String.Empty;
        public Decimal? CurrentPrice { get; set; } 

        ///<summary>
        /// Validates the product data
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
