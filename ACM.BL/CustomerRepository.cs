﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
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
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the definied customer.
            return true;
        }
    }
}