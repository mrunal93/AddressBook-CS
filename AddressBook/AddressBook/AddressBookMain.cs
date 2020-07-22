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
                Console.WriteLine("choice 1: Add Person Details ");
                Console.WriteLine("choice 2: Editing Person Details ");
                Console.WriteLine("choice 3: Delete  Person Details ");
                Console.WriteLine("choice 4: Short Person By name");
                Console.WriteLine("choice 5: Short Person By State");
                Console.WriteLine("choice 6: Short Persion By City");
                Console.WriteLine("choice 7: Short Persion By Zip");
                Console.WriteLine("choice 8: View person by city");
                Console.WriteLine("choice 9: view Person by state");
                Console.WriteLine("choice 10: Exit From here");

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
                    case 5:
                        personTo.ShortState();
                        break;
                    case 6:
                        personTo.ShortCity();
                        break;
                    case 7:
                        personTo.ShortZip();
                        break;
                    case 8:
                        personTo.ViewCity();
                        break;
                    case 9:
                        personTo.ViewState();
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
