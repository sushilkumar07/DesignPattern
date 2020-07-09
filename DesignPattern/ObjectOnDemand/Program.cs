using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand_LazyInitialization
{
    /*Object on Demand is also called Lazy loading pattern, Lazy loading delays the initialization 
     of object. This is a new feature of C# 4.0 and can be used when we are working with large 
     objects when it is not in use. */
//    There are four main ways through which you can implement the Lazy Loading pattern:

//Lazy Initialization
//Virtual Proxies
//Value Holders
//Ghost Objects
    

    class Program
    {
        static void Main(string[] args)
        {
            LazyCustomer lazyCustomer = new LazyCustomer(1, "MyLazyCustomer");
           // lazyCustomer.SetOrdersRetrieval(OrdersDatabase.GetOrders);

            foreach (Order order in lazyCustomer.Orders)
            {
                // Do Something With Orders
            }
        }
    }
}
