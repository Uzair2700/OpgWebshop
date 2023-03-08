using System;
namespace WebshopOOP
{
	internal class ProductOrder
	{
        public Product Product { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{Product} {Amount}";
        }

    }
}

