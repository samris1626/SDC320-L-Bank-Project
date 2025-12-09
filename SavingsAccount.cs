/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Savings account class.
* Demonstrates abstraction implementation,
* constructors, and access specifiers.
*/

namespace BankProject
{
    public class SavingsAccount : Account, ITransaction
    {
        public SavingsAccount() : base() { }

        public SavingsAccount(string ownerName, ContactInfo contact, decimal balance)
            : base(ownerName, contact, balance) { }

        public void Deposit(decimal amount) => _balance += amount;

        public void Withdraw(decimal amount)
        {
            if (amount <= _balance)
                _balance -= amount;
        }

        public override string GetAccountDetails()
        {
            return $"Savings Account for {OwnerName}. Current Balance: {_balance:C}";
        }
    }
}
