using System;
namespace WebshopOOP
{
	internal class Order
	{
        public int Id { get; set; }
        public Customer Customers { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public bool IsPaid { get; set; }

        public override string ToString()
        {
            string sb = $"{Id} {Customers}\n {Created}";
            foreach (var item in ProductOrders)
            {
                sb += item;
            }

            return sb;
        }
    }
}

