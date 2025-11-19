/*********************************************
* Name: Samantha Riser
* Date: 11/18/2025
* Assignment: SDC320L - WK 1 - 1.5 Project
*
* Stores contact information and demonstrates composition.
*/

namespace BankProject
{
   public class ContactInfo
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

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
