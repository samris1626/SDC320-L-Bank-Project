/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Stores contact information (composition).
* Demonstrates constructors and encapsulation.
*/

namespace BankProject
{
    public class ContactInfo
    {
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        public ContactInfo()
        {
            Address = "N/A";
            Phone = "N/A";
            Email = "N/A";
        }

        public ContactInfo(string address, string phone, string email)
        {
            Address = address;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Address} | {Phone} | {Email}";
        }
    }
}
