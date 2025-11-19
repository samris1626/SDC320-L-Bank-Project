/*********************************************
* Name: Samantha Riser
* Date: 11/18/2025
* Assignment: SDC320L - WK 1 - 1.5 Project
*
* Class for checking accounts.
*/

namespace BankProject
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string ownerName, ContactInfo contact, decimal balance)
            : base(ownerName, contact, balance) { }
    }
}
