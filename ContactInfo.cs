/*********************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320L - WK 3
*
* Stores contact information (composition).
* Demonstrates constructors and encapsulation.
*********************************************/

namespace BankProject
{
    public class ContactInfo
    {
        // Public auto-properties
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        // Default constructor
        public ContactInfo()
        {
            Address = "N/A";
            Phone = "N/A";
            Email = "N/A";
        }

        // Parameterized constructor
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
