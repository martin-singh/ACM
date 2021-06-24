using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        // CONSTRUCTORS
        public Product() {}
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // FIELDS & PROPERTIES
        public int ProductId { get; private set; }
        private string productName;
        public string ProductName 
        {
            get
            {
                return StringHandler.InsertSpaces(productName);
            }
            set
            {
                productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; } // Nullable type

        // METHODS
        public override string ToString() => ProductName;

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

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
