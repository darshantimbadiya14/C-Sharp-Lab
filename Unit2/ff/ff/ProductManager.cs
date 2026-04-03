using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ElectroMart
{
    public class ProductManager
    {
        private const string ProductsFile = "products.txt";
        private const string StockFile = "stock_history.txt";

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            if (!File.Exists(ProductsFile)) return products;

            var lines = File.ReadAllLines(ProductsFile);
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    products.Add(Product.FromString(line));
            }
            return products;
        }

        public void SaveAllProducts(List<Product> products)
        {
            var lines = products.Select(p => p.ToString());
            File.WriteAllLines(ProductsFile, lines);
        }

        public void LogStock(int productId, int qtyChange)
        {
            string log = $"{productId}|{qtyChange}|{DateTime.Now:yyyy-MM-dd HH:mm:ss}\n";
            File.AppendAllText(StockFile, log);
        }

        public void AdminMenu()
        {
            while (true)
            {
                UIManager.PrintHeader("ADMIN DASHBOARD");
                UIManager.PrintMenu(new[] { "Add Product", "Update Product", "Delete Product", "View Products", "Logout" });
                string choice = UIManager.GetInput("Select an option");

                switch (choice)
                {
                    case "1": AddProduct(); break;
                    case "2": UpdateProduct(); break;
                    case "3": DeleteProduct(); break;
                    case "4": ViewProducts(); break;
                    case "5": return;
                    default: UIManager.ShowWarning("Invalid option."); break;
                }
            }
        }

        private void AddProduct()
        {
            UIManager.PrintHeader("ADD NEW PRODUCT");
            try
            {
                var products = GetAllProducts();
                int newId = products.Any() ? products.Max(p => p.Id) + 1 : 1;

                Product p = new Product
                {
                    Id = newId,
                    Name = UIManager.GetInput("Product Name"),
                    Category = UIManager.GetInput("Category (Mobile/Laptop/Headphones/Charger/Keyboard)"),
                    Brand = UIManager.GetInput("Brand"),
                    Price = decimal.Parse(UIManager.GetInput("Price")),
                    Quantity = int.Parse(UIManager.GetInput("Quantity")),
                    Warranty = UIManager.GetInput("Warranty (e.g., 1 Year)")
                };

                products.Add(p);
                SaveAllProducts(products);
                LogStock(p.Id, p.Quantity);
                UIManager.ShowSuccess("Product added successfully!");
            }
            catch (Exception ex)
            {
                UIManager.ShowError("Invalid input: " + ex.Message);
            }
        }

        private void UpdateProduct()
        {
            UIManager.PrintHeader("UPDATE PRODUCT");
            var products = GetAllProducts();
            ViewProducts(false);

            if (int.TryParse(UIManager.GetInput("\nEnter Product ID to update"), out int id))
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    product.Price = decimal.Parse(UIManager.GetInput($"New Price (Current: {product.Price})"));
                    int newQty = int.Parse(UIManager.GetInput($"New Quantity (Current: {product.Quantity})"));
                    int diff = newQty - product.Quantity;
                    product.Quantity = newQty;

                    SaveAllProducts(products);
                    if (diff != 0) LogStock(product.Id, diff);
                    UIManager.ShowSuccess("Product updated successfully!");
                }
                else UIManager.ShowError("Product not found!");
            }
        }

        private void DeleteProduct()
        {
            UIManager.PrintHeader("DELETE PRODUCT");
            var products = GetAllProducts();
            ViewProducts(false);

            if (int.TryParse(UIManager.GetInput("\nEnter Product ID to delete"), out int id))
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    SaveAllProducts(products);
                    LogStock(id, -product.Quantity);
                    UIManager.ShowSuccess("Product deleted successfully!");
                }
                else UIManager.ShowError("Product not found!");
            }
        }

        public void ViewProducts(bool pause = true)
        {
            UIManager.PrintHeader("PRODUCT LIST");
            var products = GetAllProducts();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",-5} | {"Name",-20} | {"Category",-15} | {"Brand",-10} | {"Price",-10} | {"Qty",-5} | {"Warranty"}");
            Console.WriteLine(new string('-', 85));
            Console.ResetColor();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id,-5} | {p.Name,-20} | {p.Category,-15} | {p.Brand,-10} | {p.Price,-10:C} | {p.Quantity,-5} | {p.Warranty}");
            }
            if (pause) UIManager.Pause();
        }
    }
}