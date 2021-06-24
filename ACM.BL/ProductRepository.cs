using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class and pass in the requested id.
            Product product = new Product(productId);

            // Code that retrieves the definied product.
            // Temporary hard-coded values to return a populated product.
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96m;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        public bool Save(Product product)
        {
            bool success = true;
            if (product.HasChanged)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
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
