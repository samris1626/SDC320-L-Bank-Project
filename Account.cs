/*********************************************
* Name: Samantha Riser
* Date: 11/23/2025
* Assignment: SDC320L - WK 2 - 2.2 Project
*
* Base class for all account types.
*/

namespace BankProject
{
     public abstract class Account
    {
        public string OwnerName { get; set; }
        public ContactInfo Contact { get; set; }   // Composition
        public decimal Balance { get; protected set; }

        public Account(string ownerName, ContactInfo contact, decimal balance)
        {
            OwnerName = ownerName;
            Contact = contact;  // Composition
            Balance = balance;
        }

        public override string ToString()
        {
            return $"{OwnerName} | {GetType().Name} | Balance: {Balance:C}";
        }
    }
}
