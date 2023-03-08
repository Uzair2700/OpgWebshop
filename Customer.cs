using System;
namespace WebshopOOP
{
	internal class Customer
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }

        public Address DeliveryAddress { get; set; }
        public Address HomeAddress { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Email} {TelephoneNumber}";
        }
    }
}

