using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC_2_AddNewContact
    {
        public void NewDetailed()
        {
            string firstName;
            string lastName;
            string address;
            string city;
            string state;
            int pinCode;
            long phoneNumber;
            string email;

            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            city = Console.ReadLine();
            Console.WriteLine("Enter your state:");
            state = Console.ReadLine();
            Console.WriteLine("Enter zip code:");
            pinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phone number:");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email:");
            email = Console.ReadLine();

            Console.WriteLine("Hello" + firstName + " " + lastName + " your data has been saved");
        }
    }
}
