using System.Collections.Generic;

namespace ObjectOnDemand_VirtualProxy
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public IEnumerable<IOrder> Orders
        {
            get { return ProxyOrders; }
        }

        protected IEnumerable<OrderVirtualProxy> ProxyOrders
        {
            get { return OrdersDatabase.GetProxyOrders(CustomerID); }
        }

        public Customer(int id, string name)
        {
            CustomerID = id;
            Name = name;
        }
    }
}
