using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand_ValueHolder
{
    /*Adopting a Value Holder, instead, you basically set up a sort of surrogate for the real object.
     When the user needs to access it, they simply ask the value holder for its value by calling the
     GetValue method. At that time (and only then), the value gets loaded from a database or from a 
     service.

     The main drawback of this approach is that the user has to know that a value holder is expected.*/
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(50314, "MyCustomer");
            var holder = new ValueHolder<IEnumerable<Order>>(OrdersDatabase.GetOrders);
            customer.SetValueHolder(holder);

            foreach (Order order in customer.GetOrders())
            {
                // Do Something With Orders
            }
        }
    }
}
