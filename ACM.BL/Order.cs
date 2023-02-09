﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems =  new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

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
