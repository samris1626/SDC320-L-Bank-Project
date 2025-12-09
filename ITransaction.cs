/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Interface defining basic banking transactions.
*/

namespace BankProject
{
    public interface ITransaction
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
