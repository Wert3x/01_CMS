using System;

namespace CMS.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 0, 0, TimeSpan.FromHours(3));
            }
            return order;
        }

        public bool Save(Order order)
        {
            if (order.Validate())
            {
                return true;
            }
            return false;
        }
    }
}