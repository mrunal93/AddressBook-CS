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
            AddressBookUtility personTo = new AddressBookUtility();
            do
            {
                Console.WriteLine("choice 1: Add Person Details \nchoice 2: Editing Person Details \nchoice 3: Delete  Person Details \nchoice 4: Short Person By name \nchoice 5: Short Person By State \nchoice 6: Short Persion By City \nchoice 7: Short Persion By Zip \nchoice 8: View person by city \nchoice 9: view Person by state \nchoice 10: Exit From here");
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
                        personTo.DeletePerson();
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
