/*********************************************
* Name: Samantha Riser
* Date: 11/23/2025
* Assignment: SDC320L - WK 2 - 2.2 Project
*
* Class for savings accounts.
*/

namespace BankProject
{
    public class SavingsAccount : Account, ITransaction
    {
        public SavingsAccount(string ownerName, ContactInfo contact, decimal balance)
            : base(ownerName, contact, balance) { }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
        }
    }
}
