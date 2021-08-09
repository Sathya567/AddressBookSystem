using System;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            //AddressBook.AddContact();
            //AddressBook.ContactsDisplay();  uc2

            //AddressBook.EditContact();       uc3
            //AddressBook.ContactsDisplay();

            //AddressBook.AddContact();
            //Console.WriteLine("\n");
            //AddressBook.ContactsDisplay();
            //Console.WriteLine("\n");
            //AddressBook.EditContact();
            //Console.WriteLine("\n");
            //AddressBook.ContactsDisplay();    UC4,5
            //Console.WriteLine("\n");
            //AddressBook.DeleteContact();
            //AddressBook.ContactsDisplay();

            //AddressBook.addAddressBook();
            //Console.WriteLine("\n");
            //AddressBook.ContactsDisplay();
            //Console.WriteLine("\n");
            //AddressBook.EditContact();
            //Console.WriteLine("\n");           Uc6,7,8
            //AddressBook.ContactsDisplay();
            //Console.WriteLine("\n");
            //AddressBook.ContactsDisplay();
            //AddressBook.ContactsDisplay();
            //AddressBook.ContactsDisplay();
            //AddressBook.ContactsDisplay();

            AddressBook.addAddressBook();
            AddressBook.PersonSearch();
            AddressBook.AddressBookSorting();




        }
    }
}
