using System;

namespace AddressbookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");

            Console.WriteLine("Add Contact details here");
            //reference to store values in addressbook
            Addressbook addressBook = new Addressbook();
            addressBook.AddContact();
        }
    }
}