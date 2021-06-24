using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
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

        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data.
        /// </summary>
        public override bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
