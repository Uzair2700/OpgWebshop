using System;
namespace WebshopOOP
{
    enum ProductType { Hoodie, Jeans, Bag, Jacket }
    internal class Product
	{
        private double price;

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }



        public Product() { }
        public Product(string name, double price, int stock, ProductType productType)
        {
            Name = name;
            Price = price;
            Stock = stock;
            ProductType = productType;
        }
        public override string ToString()
        {
            return $"{Name} {Price} {ProductType} {Stock}";
        }
    }
}

