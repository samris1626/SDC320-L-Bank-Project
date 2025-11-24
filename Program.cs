/*********************************************
* Name: Samantha Riser
* Date: 11/23/2025
* Assignment: SDC320L - WK 2 - 2.2 Project
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
            Console.WriteLine("\nWEEK 2 – OOP Demonstration\n");
            Console.WriteLine("\nBank Account Application\n");
            Console.WriteLine("\nBy: Samantha Riser\n");

            Console.WriteLine("Instructions:");
            Console.WriteLine("1. The system will create accounts.");
            Console.WriteLine("2. It will perform deposits and withdrawals.");
            Console.WriteLine("3. You will see polymorphism in action.\n");

            ContactInfo contact = new ContactInfo(
                "457 Elm St",
                "555-1234",
                "customer@email.com"
            );

            CheckingAccount checking = new CheckingAccount("Franklin Turls", contact, 1500.00m);
            SavingsAccount savings = new SavingsAccount("Franklin Turls", contact, 8200.00m);

            List<ITransaction> transactionAccounts = new List<ITransaction>();
            transactionAccounts.Add(checking);
            transactionAccounts.Add(savings);

            Console.WriteLine("Performing Transactions...\n");

            foreach (var account in transactionAccounts)
            {
                account.Deposit(200.00m);
                account.Withdraw(50.00m);
            }

            Console.WriteLine("Updated Account Information:\n");
            Console.WriteLine(checking);
            Console.WriteLine(savings);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
