using System.Collections.Generic;

namespace ObjectOnDemand_VirtualProxy
{
    public static class OrdersDatabase
    {
        public static IOrder GetOrder()
        {
            return new Order();
        }

        public static IEnumerable<Order> GetOrders(object customerID)
        {
            return GetOrders((int) customerID);
        }

        public static IEnumerable<Order> GetOrders(int customerID)
        {
            return new List<Order>();
        }

        public static IEnumerable<OrderVirtualProxy> GetProxyOrders(int customerID)
        {
            return new List<OrderVirtualProxy>();
        }
    }
}
