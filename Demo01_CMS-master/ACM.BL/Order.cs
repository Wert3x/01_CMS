using System;
using System.Collections.Generic;

namespace CMS.BL
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; }

        public Order() { }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}