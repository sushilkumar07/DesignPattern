using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand_VirtualProxy
{
    /*A Virtual Proxy represents an object that is quite similar to the one that we wish to lazily 
     initialize (they implement the same interface), yet substantially different. The proxy object,
     indeed, is actually empty. When the user tries to access the proxy object for the first time,
     the Virtual Proxy creates a new instance of the real object and properly fills it (this can be 
     seen as an On Demand initialization).
     One of the disadvantages of this approach is that you may need to create lots of virtual 
     proxies if you're going to proxy a large number of objects.

    Note: The user is obviously unaware that they're dealing with the "proxy" object instead of with the "real" one.*/
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer(1, "MyCustomer");

            foreach (var order in cust.Orders)
            {
                // Do Something With Orders
            }
        }
    }
}
