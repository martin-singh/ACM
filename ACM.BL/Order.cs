using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order() {}
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the definied order.
            return new Order();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the current order.
            return true;
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
