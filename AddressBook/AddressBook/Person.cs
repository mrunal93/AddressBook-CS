using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;

namespace AddressBook
{

   // interface IPerson
    //{
      //  void addPerson();
    //}

    public class Person
    {
        private string firstName, lastName, address, city, state, phoneNumber, zip;

        public void addPerson()
        {
            Person person = new Person();
            Console.WriteLine("Enter the first name");
            person.getSetFirstName = Console.ReadLine();
            //Console.WriteLine(person.getSetFirstName);
            Console.WriteLine("Enter the Laste Name");
            person.getSetLastName = Console.ReadLine();
            Console.WriteLine("Enter The Address:");
            person.getsetaddress = Console.ReadLine();
            Console.WriteLine("Enter the city name");
            person.getSetCity = Console.ReadLine();
            Console.WriteLine("Enter the State");
            person.getSetState = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            person.getSetPhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the zip Code for the area");
            person.getSetZip = Console.ReadLine();
            
        }



        public string getSetFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string getSetLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string getsetaddress
        {
            get { return address; }
            set { address = value; }
        }
        public string getSetCity
        {
            get { return city; }
            set { city = value; }
        }
        public string getSetState
        {
            get { return state; }
            set { state = value; }

        }
        public string getSetPhoneNo
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string getSetZip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}