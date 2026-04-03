using System;

namespace ElectroMart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ElectroMart Inventory & Billing System";
            AuthManager authManager = new AuthManager();
            ProductManager productManager = new ProductManager();

            while (true)
            {
                UIManager.PrintHeader("ELECTROMART SYSTEM");
                UIManager.PrintMenu(new[] { "Login", "Register", "Exit" });
                string choice = UIManager.GetInput("Select an option");

                switch (choice)
                {
                    case "1":
                        string role = authManager.Login();
                        if (role == "Admin")
                        {
                            productManager.AdminMenu();
                        }
                        else if (role == "User")
                        {
                            ShopManager shop = new ShopManager();
                            shop.UserMenu();
                        }
                        break;

                    case "2":
                        authManager.Register();
                        break;

                    case "3":
                        UIManager.PrintHeader("GOODBYE!");
                        Environment.Exit(0);
                        break;

                    default:
                        UIManager.ShowWarning("Invalid choice. Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}