using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookSystem
{
    public class AddressBook
    {
        /// Creates a list to store contact
        List<Contact> contactList;
        private int zipcode;

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
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city name");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();
            Console.WriteLine("Enteryour zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email-Id");
            string email = Console.ReadLine();

            ///Creates a reference of Contact class
            Contact contact = new Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            contactList.Add(contact);
            Console.WriteLine(contact);
        }

        /// <summary>
        /// Displays the menu.
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("****MAIN MENU*** : Enter your choice");
            Console.WriteLine("For Adding contact - please press 1");
            Console.WriteLine("To Edit contact - please press 2");
            Console.WriteLine("To Exit - please press 3");
        }

        /// <summary>
        /// This method shows the menu for editing the contact
        /// </summary>
        public void EditMenu()
        {
            Console.WriteLine("Enter 1 to Edit FirstName");
            Console.WriteLine("Enter 2 to Edit LastName");
            Console.WriteLine("Enter 3 to Edit Address");
            Console.WriteLine("Enter 4 to Edit City");
            Console.WriteLine("Enter 5 to Edit State");
            Console.WriteLine("Enter 6 to Edit PhoneNumber");
            Console.WriteLine("Enter 7 to Edit ZipCode");
            Console.WriteLine("Enter 8 to Edit Email");
        }
        /// <summary>
        /// This method is used to edit the contact
        /// </summary>
        public void EditContact()
        {
            Console.WriteLine("Enter your first name of the contact you want to edit");
            string userName = Console.ReadLine();

            for (int index = 0; index < contactList.Count; index++)
            {
                if (contactList[index].GetFirstName().Equals(userName))
                {
                    EditMenu();
                    EditContactList(contactList[index]);
                }
                else
                {
                    Console.WriteLine("First Name does not exist");
                }
            }
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContactList(Contact contact)
        {
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first name");
                    string name = Console.ReadLine();
                    contact.SetFirstName(name);
                    break;
                case 2:
                    Console.WriteLine("Enter the last name");
                    string lastName = Console.ReadLine();
                    contact.SetLastName(lastName);
                    break;
                case 3:
                    Console.WriteLine("Enter address");
                    string address = Console.ReadLine();
                    contact.SetAddress(address);
                    break;
                case 4:
                    Console.WriteLine("Enter city");
                    string city = Console.ReadLine();
                    contact.SetCity(city);
                    break;
                case 5:
                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.SetState(state);
                    break;
                case 6:
                    Console.WriteLine("Enter Phone Number");
                    string phoneNumber = Console.ReadLine();
                    contact.SetPhoneNumber(phoneNumber);
                    break;
                case 7:
                    Console.WriteLine("Enter Zip code");
                    string zipCode = Console.ReadLine();
                    contact.SetZipCode(zipCode);
                    break;
                case 8:
                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.SetEmail(email);
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }

        public void AddressBookMenu()
        {
            bool flag = true;
            while (flag)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        EditContact();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
