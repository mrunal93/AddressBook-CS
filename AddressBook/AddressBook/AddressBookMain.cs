using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace AddressBook
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            int checkOut = 0;
            Console.WriteLine("Welcome To address Book");
            Person person1 = new Person();
            do
            {
                Console.WriteLine("Enter Your choice 1: Add Person Details ");
                Console.WriteLine("Enter Your choice 2: Editing Person Details ");
                Console.WriteLine("Enter Your choice 3: Delete  Person Details ");
                Console.WriteLine("Enter Your choice 4: To exist ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        person1.AddPerson();
                        person1.DisplayAddressBook();
                        break;
                    case 2:
                        person1.EditPerson();
                        person1.DisplayAddressBook();
                        break;
                    case 3:
                        person1.DeletPerson();
                        person1.DisplayAddressBook();
                        break;
                    default:
                        checkOut = 1;
                        break;
                }
           } while(checkOut == 0) ;
            //person1.DisplayAddressBook();

        }
    }
}
