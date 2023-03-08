using System;
using System.Text.Json;

namespace WebshopOOP
{
	internal class Data
	{
        private string jsonAddress = "[{\"StreetName\":\"Mimbi\",\"StreetNumber\":112,\"City\":\"Meldivs\",\"PostalCode\":4562,\"Country\":\"Columbia\"},\r\n{\"StreetName\":\"Beverly Hill st\",\"StreetNumber\":23,\"City\":\"Los Angeles\",\"PostalCode\":8982,\"Country\":\"United States\"}]";
        private string jsonCustomer = "[{\"Id\":797,\"Name\":\"Carlos Pena\",\"Email\":\"Caarlos@g123.com\",\"TelephoneNumber\":\"7892678712\"},\r\n{\"Id\":999,\"Name\":\"Elon Musk\",\"Email\":\"ElonM@teska.com\",\"TelephoneNumber\":\"7382014141\"}]";
        public List<Product> Products = new();
        public List<Address> AddressList = new();
        public List<Customer> Customers = new();
        public List<Order> Orders = new();

        public Data()
        {
            AddProducts();
            AddressList = JsonSerializer.Deserialize<List<Address>>(jsonAddress);
            Customers = JsonSerializer.Deserialize<List<Customer>>(jsonCustomer);
            int i = 0;
            foreach (var item in Customers)
            {
                item.HomeAddress = AddressList[i++];
            }
            CreateFakeOrders();
        }
        public void AddProducts()
        {
            Products.Add(new Product("Moncler", 12000.00, 100, ProductType.Jacket));
            Products.Add(new Product("Desquared2", 4800.00, 50, ProductType.Jeans));
            Products.Add(new Product("Louis Vouitton", 7800.00, 25, ProductType.Bag));
            Products.Add(new Product("OFF-White", 3600.00, 150, ProductType.Hoodie));
        }

        public List<string> GetProductList()
        {
            List<string> prod = new();
            foreach (var item in Products)
                prod.Add(item.ToString());
            return prod;
        }

        public List<string> GetCustomers()
        {
            List<string> cust = new();
            foreach (var item in Customers)
                cust.Add(item.ToString());
            return cust;
        }

        public void CreateFakeOrders()
        {
            for (int i = 0; i < 100; i++)
            {
                Order o = new Order();
                o.Id = i;
                o.Customers = Customers[new Random().Next(Customers.Count)];
                o.ProductOrders = new List<ProductOrder>()
                {
                    new ProductOrder() { Product = Products[1], Amount = 1 }
                };
                Orders.Add(o);
            }

        }

        internal List<string> GetOrders()
        {
            List<string> orders = new();
            foreach (var item in Orders)
                orders.Add(item.ToString());
            return orders;
        }
    }
}

