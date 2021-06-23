using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product() {}
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; } // Nullable type

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the definied product.
            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the current product.
            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
