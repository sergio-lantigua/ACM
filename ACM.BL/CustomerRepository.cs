using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
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
