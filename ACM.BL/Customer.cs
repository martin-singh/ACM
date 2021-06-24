using System;
using System.Collections.Generic;

// ACM - Business Logic (Layer) Component
namespace ACM.BL
{
    public class Customer
    {
        public Customer() {} // Default constructor
        public Customer(int customerId) // Overloaded constructor
        {
            this.CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { // Read-only Property
            get
            {
                string fullName = LastName;
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (String.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
