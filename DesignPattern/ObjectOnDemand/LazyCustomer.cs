using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand_LazyInitialization
{
    public class LazyCustomer // Using Lazy<T>
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        private Lazy<IEnumerable<Order>> _orders;

        public IEnumerable<Order> Orders
        {
            get
            {
                return _orders.Value;
            }
        }

        //Constructor
        public LazyCustomer(int id, string name)
        {
            CustomerID = id;
            Name = name;
        }

        public void SetOrdersRetrieval(Func<int, IEnumerable<Order>> ordersRetrieval)
        {
            _orders = new Lazy<IEnumerable<Order>>(() => ordersRetrieval(CustomerID));
        }
    }
}
