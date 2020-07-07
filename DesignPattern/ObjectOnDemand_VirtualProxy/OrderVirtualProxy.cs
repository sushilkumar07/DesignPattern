using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOnDemand_VirtualProxy
{
    public class OrderVirtualProxy : IOrder
    {
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ShipmentDate { get; set; }

        private IOrder _realOrder;

        public void DisplayOrder()
        {
            if (_realOrder == null)
            {
                _realOrder = new Order(); // The order gets filled
            }

            Console.WriteLine("Displaying order\n" +
                              "Description: {0}\n" +
                              "SubmissionDate: {1}\n" +
                              "ShipmentDate: {2}\n", Description, SubmissionDate, ShipmentDate);
        }
    }
}
