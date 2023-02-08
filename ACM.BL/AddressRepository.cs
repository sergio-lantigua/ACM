using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        ///<summary>
        /// Retrieve one address.
        ///</summary>
        ///<returns></returns>
        public Address Retrieve(int addressId)
        {
            //hard-code values for now

            Address address = new Address(addressId)  ;

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshot row";
                address.City = "La vega";
                address.State = "consepcio la vega";
                address.Country = "RD";
                address.PostalCode = "12345";
            }

            return address;
        }

        ///<summary>
        /// Retrieve customer addresses.
        ///</summary>
        ///<returns></returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //hard-code values for now
            List<Address> addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "La vega",
                State = "consepcio la vega",
                Country = "RD",
                PostalCode = "12345"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "Santiago",
                State = "Santiago",
                Country = "RD",
                PostalCode = "145"
            };

            addressList.Add(address);


            return addressList;
        }


        ///<summary>
        /// Save the current address.
        ///</summary>
        ///<returns></returns>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
