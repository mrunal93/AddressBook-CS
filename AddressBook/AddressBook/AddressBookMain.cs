using System;

namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To address Book");
            Person person = new Person();
            person.getSetFirstName = "Mrunal";
            Console.WriteLine(person.getSetFirstName);
        
        }
    }
}
