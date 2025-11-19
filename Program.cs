/*********************************************
* Name: Samantha Riser
* Date: 11/18/2025
* Assignment: SDC320L - WK 1 - 1.5 Project
*
* Main application; shows welcome message and shows
* inheritance, composition and class instantiation.
*/

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANK ACCOUNT MANAGEMENT SYSTEM");
            Console.WriteLine("Samantha Riser");
            Console.WriteLine("Welcome! This Week 1 demo shows inheritance,");
            Console.WriteLine("composition, and basic object output.\n");

            // Composition demonstration:
            // Account contains a ContactInfo object.
            ContactInfo contact = new ContactInfo("457 Elm St", "555-1234", "customer@email.com");

            // Inheritance demonstration:
            // CheckingAccount and SavingsAccount inherit from Account.
            CheckingAccount checking = new CheckingAccount("Franklin Turls", contact, 1500.00m);

            SavingsAccount savings = new SavingsAccount("Franklin Turls", contact, 8200.00m);

            Console.WriteLine("Account Information:\n");
            Console.WriteLine(checking);
            Console.WriteLine(savings);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
