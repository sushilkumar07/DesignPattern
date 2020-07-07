using ObjectOnDemand_LazyInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand
{
    public static class OrdersDatabase
    {
        public static IEnumerable<Order> GetOrders(object customerID)
        {
            return GetOrders((int)customerID);
        }

        public static IEnumerable<Order> GetOrders(int customerID)
        {
            return new List<Order>();
        }
    }
}
