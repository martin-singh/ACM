using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        // METHODS
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class and pass in the requested id.
            Order order = new Order(orderId);

            // Code that retrieves the definied order.
            // Temporary hard-coded values to return a populated order
            if (orderId == 10)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 24, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        public bool Save(Order order)
        {
            bool success = true;
            if (order.HasChanged)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
