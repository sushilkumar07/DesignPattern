using System.Collections.Generic;

namespace ObjectOnDemand_ValueHolder
{
    public static class OrdersDatabase
    {
        public static IEnumerable<Order> GetOrders(object customerID)
        {
            return GetOrders((int) customerID);
        }

        public static IEnumerable<Order> GetOrders(int customerID)
        {
            return new List<Order>();
        }
    }
}
