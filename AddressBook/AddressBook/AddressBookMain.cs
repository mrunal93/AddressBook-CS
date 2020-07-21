using System;
using System.Security.Cryptography.X509Certificates;

namespace AddressBook
{
    public class AddressBookMain
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To address Book");
            Person person = new Person();
            person.addPerson();
        }
    }
}
