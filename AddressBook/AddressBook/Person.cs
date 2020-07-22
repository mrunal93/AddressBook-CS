using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;

namespace AddressBook
{

    

    public class Person
    {
        string name, address, city, state, phoneNumber, zip;
        ArrayList personDetails = new ArrayList() ;        
        public Person(string name,string address, string city, string state, string zip, string phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.address = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }

        public Person()
        {
        }

        public void AddPerson()
        {
            Console.WriteLine("Enter the Name of person:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            String phoneNumber = Console.ReadLine();
            Person personAdd = new Person(name,address, city, state, zip, phoneNumber);
            personDetails.Add(personAdd);
            }

      
        
        public void EditPerson()
        {
            Person personEdit = new Person(name,address,city,state,zip,phoneNumber);
            Console.WriteLine("Enter the name of person");
            name = Console.ReadLine();
            foreach(Person person in personDetails)
            {
                if (person.GetName().Equals(name))
                {
                    personEdit = person;
                }
                    Console.WriteLine("Enter the address");
                    String address = Console.ReadLine();
                    personEdit.SetAddress(address);
                    Console.WriteLine("Enter the city");
                    String city = Console.ReadLine();
                    personEdit.SetCity(city);
                    Console.WriteLine("Enter the state");
                    String state = Console.ReadLine();
                    personEdit.SetState(state);
                    Console.WriteLine("Enter the zip");
                    String zip = Console.ReadLine();
                    personEdit.SetZip(zip);
                    Console.WriteLine("Enter the phone number");
                    String phoneNumber = Console.ReadLine();
                    personEdit.SetPhoneNumber(phoneNumber);
                    
            }

        }

        public Person DetectPerson()
        {
            Console.WriteLine("entername of person ");
            String name = Console.ReadLine();
            foreach (Person person in personDetails)
            {
                if (person.GetName().Equals(name))
                {
                    return person;
                }
            }
            return null;
        }

        public void DeletPerson()
        {
            Person personDelet = DetectPerson();
            personDetails.Remove(personDelet);
        }
        

        public void DisplayAddressBook()
        {
            foreach (Person person in personDetails) 
            {
                Console.WriteLine(person.GetName());
                Console.WriteLine(person.GetPhoneNumber());
                Console.WriteLine(person.GetState());
                Console.WriteLine(person.GetCity());
                Console.WriteLine(person.Getzip());
                Console.WriteLine(person.GetAddress());
            }
            //for (int index=0; index < personDetails.Count; index++)
            //{
            //    Person person = (Person)personDetails[index];
            //}
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetState()
        {
            return this.state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetCity()
        {
            return this.city;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public string Getzip()
        {
            return this.zip;
        }
        public void SetZip(string zip)
        {
            this.zip = zip;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}

