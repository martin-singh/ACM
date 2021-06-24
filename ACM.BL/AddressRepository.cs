using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class and pass in the requested id.
            Address address = new Address(addressId);

            // Code that retrieves the definied address.
            // Temporary hard-coded value to return a populated address.
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.PostalCode = "144";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
            }
            return address;
        }

        /// <summary>
        /// Retrieves multible addresses.
        /// </summary>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the definied addresses for the customer.

            // Temporary hard-coded values to return a set of addresses for a customer.
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                PostalCode = "144",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                PostalCode = "146",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        public bool Save(Address address)
        {
            bool success = true;
            if (address.HasChanged)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
