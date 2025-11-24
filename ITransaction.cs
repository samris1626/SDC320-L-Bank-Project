/*********************************************
* Name: Samantha Riser
* Date: 11/23/2025
* Assignment: SDC320L - WK 2 - 2.2 Project
*
* Interface defining the basic banking transactions.
*/

namespace BankProject
{
    public interface ITransaction
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
