using System;

namespace AddressbookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            ///Creates a reference of AddressBook
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
        }
    }
}