using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        ///<summary>
        /// Retrieve one customer.
        ///</summary>
        ///<returns></returns>
        public Customer Retrieve(int customerId)
        {
            //hard-code values for now

            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "pepe@gmail.com";
                customer.FirstName = "Sergio";
                customer.LastName = "lantigua";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        ///<summary>
        /// Save the current customer.
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
