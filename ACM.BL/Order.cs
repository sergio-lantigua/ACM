using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; }


        ///<summary>
        /// Retrieve one order.
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        ///<summary>
        /// Save the current order .
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            return true;
        }


        ///<summary>
        /// Validates the order data
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
