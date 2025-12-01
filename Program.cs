/*********************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320L - WK 3
*
* Main application demonstrating abstraction,
* constructors, inheritance, access specifiers,
* and object instantiation.
*********************************************/

using System;
using System.Collections.Generic;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===========================");
            Console.WriteLine("     WEEK 3 – Phase 3");
            Console.WriteLine("     Bank Account System");
            Console.WriteLine("     By: Samantha Riser");
            Console.WriteLine("===========================\n");

            Console.WriteLine("Welcome!");
            Console.WriteLine("This program demonstrates:");
            Console.WriteLine("• Abstraction (abstract class + interface)");
            Console.WriteLine("• Constructors (default + parameterized)");
            Console.WriteLine("• Access specifiers (public/protected/private)");
            Console.WriteLine("• Inheritance & polymorphism\n");

            // Create contact info
            ContactInfo contact = new ContactInfo(
                "457 Elm St",
                "555-1234",
                "customer@email.com"
            );

            // Instantiate accounts
            CheckingAccount checking = new CheckingAccount("Franklin Turls", contact, 1500.00m);
            SavingsAccount savings = new SavingsAccount("Franklin Turls", contact, 8200.00m);

            List<ITransaction> accounts = new List<ITransaction>() { checking, savings };

            Console.WriteLine("\nPerforming Transactions...\n");

            foreach (var account in accounts)
            {
                account.Deposit(200.00m);
                account.Withdraw(50.00m);
            }

            Console.WriteLine("\nAccount Details After Transactions:\n");
            Console.WriteLine(checking.GetAccountDetails());
            Console.WriteLine(savings.GetAccountDetails());

            Console.WriteLine("\nFull Object Printout (ToString):");
            Console.WriteLine(checking);
            Console.WriteLine(savings);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
