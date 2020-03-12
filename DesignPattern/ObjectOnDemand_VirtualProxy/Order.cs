using System;

namespace ObjectOnDemand_VirtualProxy
{
    public class Order : IOrder
    {
        public int OrderID { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? ShipmentDate { get; set; }

        //Constructor
        public Order()
        {
            LoadOrder();
        }

        public void LoadOrder()
        {
            Console.WriteLine("Loading order from database...");
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Displaying order \n" +
                              "Description: {0}\n" +
                              "SubmissionDate: {1}\n" +
                              "ShipmentDate: {2}\n", Description, SubmissionDate, ShipmentDate);
        }
    }
}
