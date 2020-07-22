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
            Person personTo = new Person();
            do
            {
                Console.WriteLine("Enter Your choice 1: Add Person Details ");
                Console.WriteLine("Enter Your choice 2: Editing Person Details ");
                Console.WriteLine("Enter Your choice 3: Delete  Person Details ");
                Console.WriteLine("Enter Your choice 4: Short Persion By name");
                Console.WriteLine("Enter Your choice 5: To exist");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        personTo.AddPerson();
                        personTo.DisplayAddressBook();
                        break;
                    case 2:
                        personTo.EditPerson();
                        personTo.DisplayAddressBook();
                        break;
                    case 3:
                        personTo.DeletPerson();
                        personTo.DisplayAddressBook();
                        break;
                    case 4:
                        personTo.ShortPersion();
                        personTo.DisplayAddressBook();
                        break;
                    default:
                        checkOut = 1;
                        break;
                }
           } while(checkOut == 0) ;
            personTo.DisplayAddressBook();

        }
    }
}
