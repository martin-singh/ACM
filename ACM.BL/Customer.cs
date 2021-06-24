using Acme.Common;
using System;
using System.Collections.Generic;

// ACM - Business Logic Layer
namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // CONSTRUCTORS
        public Customer() : this(0) {} // Default constructor. By using ": this(0)" the both constructors are chained.
        public Customer(int customerId) // Overloaded constructor
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        // PROPERTIES
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
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
        public List<Address> AddressList { get; set; }

        // METHODS
        public override string ToString() => FullName;

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        public override bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (String.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
