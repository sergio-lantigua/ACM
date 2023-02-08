using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        ///<summary>
        /// Retrieve one order.
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderId)
        {
            //hard-code values for now

            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        ///<summary>
        /// Save the current order.
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
