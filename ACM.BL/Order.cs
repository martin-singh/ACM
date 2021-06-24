using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        // CONSTRUCTORS
        public Order() : this(0) {}
        public Order(int orderId)
        {
            this.OrderId = orderId;
            OrderItemsList = new List<OrderItem>();
        }

        // PROPERTIES
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItemsList { get; set; }

        // METHODS
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public string Log() =>
            $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public override bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
