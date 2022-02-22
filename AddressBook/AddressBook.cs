using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookSystem
{
    public class AddressBook
    {
        ///This list is created to store contacts
        List<Contact> contactList;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        public AddressBook()
        {
            contactList = new List<Contact>();
        }

        /// Adds the contact  
        public void AddContact()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email-Id");
            string email = Console.ReadLine();


            ///Creates a reference of Contact class
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            contactList.Add(contact);
            Console.WriteLine(contact);
        }

    }
}
