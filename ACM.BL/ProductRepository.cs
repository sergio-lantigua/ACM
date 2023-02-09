using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<summary>
        /// Retrieve one product.
        ///</summary>
        ///<returns></returns>
        public Product Retrieve(int productId)
        {
            //hard-code values for now

            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName= "Creatina";
                product.Description = "Enhance the strength of the muscle";
                product.CurrentPrice = 20.25M;
            }

            return product;
        }

        ///<summary>
        /// Save the current product.
        ///</summary>
        ///<returns></returns>
        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call insert stored procedure
                    }
                    else
                    {
                       //call update stored procedure
                    }

                }
                else
                {
                    success = false;
                }

            }
            return success;
        }
    }
}
