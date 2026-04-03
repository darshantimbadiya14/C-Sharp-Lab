using System;

namespace ElectroMart
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // Mobile, Laptop, Headphones, Charger, Keyboard
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Warranty { get; set; }

        public override string ToString()
        {
            return $"{Id}|{Name}|{Category}|{Brand}|{Price}|{Quantity}|{Warranty}";
        }

        public static Product FromString(string line)
        {
            var parts = line.Split('|');
            return new Product
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Category = parts[2],
                Brand = parts[3],
                Price = decimal.Parse(parts[4]),
                Quantity = int.Parse(parts[5]),
                Warranty = parts[6]
            };
        }
    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}