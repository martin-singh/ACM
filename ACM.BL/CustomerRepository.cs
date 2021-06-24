using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // CONSTRUCTOR
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        // PROPERTY
        public AddressRepository AddressRepository { get; set; }

        // METHODS
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class and pass in the requested id.
            Customer customer = new Customer(customerId);

            // Code that retrieves the definied customer.
            // Temporary hard-coded value to return a populated customer.
            if (customerId == 1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        public bool Save(Customer customer)
        {
            bool success = true;
            if (customer.HasChanged)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
