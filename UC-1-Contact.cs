using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC_1_Contact
    {
        
            string firstName;
            string lastName;
            string address;
            string city;
            string state;
            string pinCode;
            string phone_number;
            string email;
            public void AddressBook()
            {
                firstName = "Vishal";
                lastName = "Dute";
                address = "1168/MainRoad";
                city = "Jalamb";
                state = "Maharastra";
                pinCode = "444303";
                phone_number = "9146508505";
                email = "dute0987@gmail.com";

                Console.WriteLine("FirstName: " + firstName + "\nLastName: " + lastName + "\nAdress: " + address + "\nCity: " + city + "\nState: " + state + "\nPinCode: " + pinCode + "\nPhoneNUmber: " + phone_number + "\nEmailId: " + email);
            }
            public void Address(string Firstname, string lastName, string address, string city, string state, string pinCode, string contact, string email)
            {
                firstName = Firstname;
                lastName = lastName;
                address = address;
                city = city;
                state = state;
                pinCode = pinCode;
                phone_number = contact;
                email = email;
            Console.WriteLine("FirstName: " + firstName + "\nLastName: " + lastName + "\nAdress: " + address + "\nCity: " + city + "\nState: " + state + "\nPinCode: " + pinCode + "\nPhoneNUmber: " + phone_number + "\nEmailId: " + email);
    
            Console.WriteLine("Hi " + firstName + " " + lastName + " your data has saved");
            }
    }
}
