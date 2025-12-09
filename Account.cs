/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Abstract base class for all bank account types.
* Demonstrates abstraction, constructors, and
* proper use of access specifiers.
*/

namespace BankProject
{
    public abstract class Account
    {
        private string _ownerName;
        private ContactInfo _contact;
        protected decimal _balance;

        public string OwnerName
        {
            get => _ownerName;
            protected set => _ownerName = value;
        }

        public ContactInfo Contact
        {
            get => _contact;
            protected set => _contact = value;
        }

        public decimal Balance => _balance;

        public Account()
        {
            _ownerName = "Unknown";
            _contact = new ContactInfo("N/A", "N/A", "N/A");
            _balance = 0m;
        }

        public Account(string ownerName, ContactInfo contact, decimal balance)
        {
            _ownerName = ownerName;
            _contact = contact;
            _balance = balance;
        }

        public abstract string GetAccountDetails();

        public override string ToString()
        {
            return $"{OwnerName} | {GetType().Name} | Balance: {_balance:C}";
        }
    }
}
