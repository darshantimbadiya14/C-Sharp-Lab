using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ElectroMart
{
    public class ShopManager
    {
        private List<CartItem> cart = new List<CartItem>();
        private ProductManager productManager = new ProductManager();

        public void UserMenu()
        {
            while (true)
            {
                UIManager.PrintHeader("USER DASHBOARD");
                UIManager.PrintMenu(new[] { "View Products", "Add to Cart", "View/Edit Cart", "Checkout & Bill", "Logout" });
                string choice = UIManager.GetInput("Select an option");

                switch (choice)
                {
                    case "1": productManager.ViewProducts(); break;
                    case "2": AddToCart(); break;
                    case "3": ViewCart(); break;
                    case "4": Checkout(); return; // Logout after checkout
                    case "5": return;
                    default: UIManager.ShowWarning("Invalid option."); break;
                }
            }
        }

        private void AddToCart()
        {
            UIManager.PrintHeader("ADD TO CART");
            productManager.ViewProducts(false);
            var products = productManager.GetAllProducts();

            if (int.TryParse(UIManager.GetInput("\nEnter Product ID"), out int id))
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null && product.Quantity > 0)
                {
                    int qty = int.Parse(UIManager.GetInput($"Enter Quantity (Available: {product.Quantity})"));
                    if (qty > 0 && qty <= product.Quantity)
                    {
                        var existing = cart.FirstOrDefault(c => c.Product.Id == id);
                        if (existing != null) existing.Quantity += qty;
                        else cart.Add(new CartItem { Product = product, Quantity = qty });

                        UIManager.ShowSuccess("Added to cart!");
                    }
                    else UIManager.ShowError("Invalid quantity.");
                }
                else UIManager.ShowError("Product not found or out of stock.");
            }
        }

        private void ViewCart()
        {
            UIManager.PrintHeader("YOUR CART");
            if (!cart.Any())
            {
                UIManager.ShowWarning("Cart is empty.");
                return;
            }

            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cart[i].Product.Name} - Qty: {cart[i].Quantity} - Total: {cart[i].Product.Price * cart[i].Quantity:C}");
            }

            string opt = UIManager.GetInput("\nOptions: [R]emove item, [E]dit quantity, [B]ack");
            if (opt.ToUpper() == "R")
            {
                int idx = int.Parse(UIManager.GetInput("Enter Item Number to remove")) - 1;
                if (idx >= 0 && idx < cart.Count) cart.RemoveAt(idx);
            }
            else if (opt.ToUpper() == "E")
            {
                int idx = int.Parse(UIManager.GetInput("Enter Item Number to edit")) - 1;
                if (idx >= 0 && idx < cart.Count)
                {
                    cart[idx].Quantity = int.Parse(UIManager.GetInput("New Quantity"));
                }
            }
        }

        private void Checkout()
        {
            if (!cart.Any())
            {
                UIManager.ShowWarning("Cannot checkout an empty cart.");
                return;
            }

            UIManager.PrintHeader("CHECKOUT");
            string name = UIManager.GetInput("Customer Name");
            string contact = UIManager.GetInput("Contact Number");
            string address = UIManager.GetInput("Address");
            bool festivalDiscount = UIManager.GetInput("Apply 10% Festival Discount? (Y/N)").ToUpper() == "Y";

            GenerateBill(name, contact, address, festivalDiscount);
            UpdateInventory();
            cart.Clear();
            UIManager.ShowSuccess("Thank you for shopping! Bill generated in 'bill.txt'.");
        }

        private void GenerateBill(string name, string contact, string address, bool applyDiscount)
        {
            Console.Clear();
            string billOutput = "";
            string border = new string('-', 60);

            billOutput += $"{border}\n";
            billOutput += $"{"ELECTROMART",35}\n";
            billOutput += $"{"123 Tech Street, Silicon City | Contact: 1800-123-456",50}\n\n";
            billOutput += $"Date & Time: {DateTime.Now}\n";
            billOutput += $"Customer Details:\nName: {name}\nContact: {contact}\nAddress: {address}\n";
            billOutput += $"{border}\n";
            billOutput += $"{"Product",-25} | {"Qty",-5} | {"Price",-10} | {"Total",-10}\n";
            billOutput += $"{border}\n";

            decimal subtotal = 0;
            foreach (var item in cart)
            {
                decimal total = item.Product.Price * item.Quantity;
                subtotal += total;
                billOutput += $"{item.Product.Name,-25} | {item.Quantity,-5} | {item.Product.Price,-10} | {total,-10}\n";
            }

            billOutput += $"{border}\n";
            decimal gst = subtotal * 0.18m;
            decimal discount = applyDiscount ? subtotal * 0.10m : 0;
            decimal final = subtotal + gst - discount;

            billOutput += $"Subtotal: {subtotal:C}\n";
            billOutput += $"GST (18%): {gst:C}\n";
            if (applyDiscount) billOutput += $"Festival Discount (10%): -{discount:C}\n";
            billOutput += $"Final Amount: {final:C}\n";
            billOutput += $"{border}\n";

            // Print styled to Console
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(billOutput);
            Console.ResetColor();

            // Save to File
            File.AppendAllText("bill.txt", billOutput + "\n\n");
            UIManager.Pause();
        }

        private void UpdateInventory()
        {
            var products = productManager.GetAllProducts();
            foreach (var item in cart)
            {
                var p = products.First(prod => prod.Id == item.Product.Id);
                p.Quantity -= item.Quantity;
                productManager.LogStock(p.Id, -item.Quantity);
            }
            productManager.SaveAllProducts(products);
        }
    }
}