using System;
using System.Collections.Generic;

namespace ObjectOnDemand_ValueHolder
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        protected ValueHolder<IEnumerable<Order>> Orders;

        // Constructor
        public Customer(int id, string name)
        {
            CustomerID = id;
            Name = name;            
        }

        public void SetValueHolder(ValueHolder<IEnumerable<Order>> orders)
        {
            Orders = orders;
        }

        public IEnumerable<Order> GetOrders()
        {
            return Orders.GetValue(CustomerID);
        }
    }
}
