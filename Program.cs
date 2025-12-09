/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Main application demonstrating database CRUD
* operations with SQLite while preserving OOP concepts
* (abstraction, inheritance, constructors, access specifiers).
*/

using System;
using System.Collections.Generic;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize database
            DatabaseHelper.InitializeDatabase();

            Console.WriteLine("\n===========================");
            Console.WriteLine("     WEEK 4 – Database Demo");
            Console.WriteLine("     Bank Account System with SQLite");
            Console.WriteLine("     By: Samantha Riser");
            Console.WriteLine("===========================\n");

            Console.WriteLine("Welcome!");
            Console.WriteLine("This program demonstrates:");
            Console.WriteLine("• Database CRUD operations with SQLite");
            Console.WriteLine("• Abstraction, inheritance, constructors, access specifiers\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1 - Add Account");
                Console.WriteLine("2 - View All Accounts");
                Console.WriteLine("3 - Update Account Balance");
                Console.WriteLine("4 - Delete Account");
                Console.WriteLine("5 - Exit");

                Console.Write("\nEnter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAccountMenu();
                        break;
                    case "2":
                        ViewAccounts();
                        break;
                    case "3":
                        UpdateAccountMenu();
                        break;
                    case "4":
                        DeleteAccountMenu();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Bank Account System!");
        }

        // ---- Add Account ----
        static void AddAccountMenu()
        {
            Console.Write("Enter Owner Name: ");
            string owner = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Select Account Type (1 = Checking, 2 = Savings): ");
            string typeChoice = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal balance))
            {
                Console.WriteLine("Invalid balance. Operation canceled.");
                return;
            }

            ContactInfo contact = new ContactInfo(address, phone, email);
            Account account = typeChoice switch
            {
                "1" => new CheckingAccount(owner, contact, balance),
                "2" => new SavingsAccount(owner, contact, balance),
                _ => null
            };

            if (account != null)
            {
                DatabaseHelper.AddAccount(account);
                Console.WriteLine($"{account.GetType().Name} for {owner} added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid account type. Operation canceled.");
            }
        }

        // ---- View Accounts ----
        static void ViewAccounts()
        {
            List<Account> accounts = DatabaseHelper.GetAllAccounts();

            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts found in the database.");
                return;
            }

            Console.WriteLine("\nAccounts in Database:");
            int index = 1;
            foreach (var acc in accounts)
            {
                Console.WriteLine($"{index++}. {acc.GetAccountDetails()}");
            }
        }

        // ---- Update Account Balance ----
        static void UpdateAccountMenu()
        {
            List<Account> accounts = DatabaseHelper.GetAllAccounts();
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts to update.");
                return;
            }

            ViewAccounts();
            Console.Write("\nEnter the number of the account to update: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > accounts.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Account selected = accounts[index - 1];
            Console.Write($"Current Balance: {selected.Balance:C}. Enter new balance: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal newBalance))
            {
                Console.WriteLine("Invalid balance.");
                return;
            }

            DatabaseHelper.UpdateAccountBalance(index, newBalance);
            Console.WriteLine("Balance updated successfully!");
        }

        // ---- Delete Account ----
        static void DeleteAccountMenu()
        {
            List<Account> accounts = DatabaseHelper.GetAllAccounts();
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts to delete.");
                return;
            }

            ViewAccounts();
            Console.Write("\nEnter the number of the account to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > accounts.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            DatabaseHelper.DeleteAccount(index);
            Console.WriteLine("Account deleted successfully!");
        }
    }
}
