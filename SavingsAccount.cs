/*********************************************
* Name: Samantha Riser
* Date: 11/18/2025
* Assignment: SDC320L - WK 1 - 1.5 Project
*
* Class for savings accounts.
*/

namespace BankProject
{
    // Inheritance: SavingsAccount derives from Account.
    public class SavingsAccount : Account
    {
        public SavingsAccount(string ownerName, ContactInfo contact, decimal balance)
            : base(ownerName, contact, balance) { }
    }
}
