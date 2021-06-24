using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        public Order() : this(0) {}
        public Order(int orderId)
        {
            this.OrderId = orderId;
            OrderItemsList = new List<OrderItem>();
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItemsList { get; set; }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

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
