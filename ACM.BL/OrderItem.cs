using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() {}
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the definied order item.
            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        public bool Save()
        {
            // Code that saves the current order item.
            return true;
        }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        public bool Validate()
        {
            bool isValid = true;

            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

    }
}
