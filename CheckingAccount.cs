/*********************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320L - WK 3
*
* Checking account class.
* Demonstrates inheritance, abstraction, constructors,
* and proper access specifiers.
*********************************************/

namespace BankProject
{
    public class CheckingAccount : Account, ITransaction
    {
        // Default constructor
        public CheckingAccount() : base() 
        {
        }

        // Parameterized constructor
        public CheckingAccount(string ownerName, ContactInfo contact, decimal balance)
            : base(ownerName, contact, balance)
        {
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= _balance)
                _balance -= amount;
        }

        // Required abstract method implementation
        public override string GetAccountDetails()
        {
            return $"Checking Account for {OwnerName}. Current Balance: {_balance:C}";
        }
    }
}
