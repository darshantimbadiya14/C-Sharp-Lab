using System;
using System.IO;

namespace ElectroMart
{
    public class AuthManager
    {
        private const string UsersFile = "users.txt";

        public string Login()
        {
            UIManager.PrintHeader("LOGIN SYSTEM");
            string username = UIManager.GetInput("Enter Username");
            string password = UIManager.GetInput("Enter Password");

            if (username == "admin" && password == "admin123")
            {
                UIManager.ShowSuccess("Admin logged in successfully!");
                return "Admin";
            }

            if (File.Exists(UsersFile))
            {
                string[] users = File.ReadAllLines(UsersFile);
                foreach (string u in users)
                {
                    var parts = u.Split('|');
                    if (parts[0] == username && parts[1] == password)
                    {
                        UIManager.ShowSuccess($"Welcome back, {username}!");
                        return "User";
                    }
                }
            }

            UIManager.ShowError("Invalid credentials. Please try again or register.");
            return null;
        }

        public void Register()
        {
            UIManager.PrintHeader("USER REGISTRATION");
            string username = UIManager.GetInput("Choose a Username");

            if (File.Exists(UsersFile))
            {
                string[] users = File.ReadAllLines(UsersFile);
                foreach (string u in users)
                {
                    if (u.Split('|')[0] == username)
                    {
                        UIManager.ShowError("Username already exists!");
                        return;
                    }
                }
            }

            string password = UIManager.GetInput("Choose a Password");
            File.AppendAllText(UsersFile, $"{username}|{password}\n");
            UIManager.ShowSuccess("Registration successful! You can now log in.");
        }
    }
}