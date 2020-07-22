using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace AddressBook
{



    public class Person 
    {
        string name, address, city, state, phoneNumber, zip;
        ArrayList personDetails = new ArrayList() ;
        Dictionary<string,Person> personCity = new Dictionary<string, Person>();
        Dictionary<string, Person> personState = new Dictionary<string, Person>();
        Dictionary<string, Person> personZip = new Dictionary<string, Person>();


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
            personCity.Add(city, personAdd);
            personState.Add(state, personAdd);
            personZip.Add(zip, personAdd);
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

                Person personDupli = new Person(name, address, city, state, zip, phoneNumber);
                Person dupilicate = DetectPerson(name);
                if (personDupli.Equals(dupilicate))
                {
                    Console.WriteLine("Person already in the List");
                }
                personDetails.Add(personDupli);
            }

        }

        public Person DetectPerson(string name)
        {
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
            Console.WriteLine("Enter the Person Name:");
            string name = Console.ReadLine();
            Person personDelet = DetectPerson(name);
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
        }

        public void ShortCity()
        {
            foreach(KeyValuePair<string,Person> sortCity in personCity.OrderBy(keyCity => keyCity.Key))
            {
             
                Console.WriteLine("City name: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortCity.Key, sortCity.Value.GetName(),sortCity.Value.GetState(),sortCity.Value.Getzip(),sortCity.Value.GetPhoneNumber());
             
                
            }
           
        }
        public void ShortState()
        {
            foreach (KeyValuePair<string, Person> sortState in personState.OrderBy(keyState => keyState.Key))
            {
               
               Console.WriteLine("State name: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortState.Key, sortState.Value.GetName(),sortState.Value.GetCity(),sortState.Value.Getzip(),sortState.Value.GetPhoneNumber());
               
            }
        }
        public void ShortZip()
        {
            foreach (KeyValuePair<string, Person> sortZip in personZip.OrderBy(keyZip => keyZip.Key))
            {
                Console.WriteLine("ZIP: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortZip.Key, sortZip.Value.GetName(),sortZip.Value.GetCity(),sortZip.Value.GetState(),sortZip.Value.GetPhoneNumber());
            }
        }
        public void ShortPersion()
        {
            personDetails.Sort();
            foreach(Person sort in personDetails)
            {
                Console.WriteLine(sort.GetName());
            }
        }

        public void ViewCity()
        {
            Console.WriteLine("Enter the city name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string,Person> cityView in personCity)
            {
                if (cityView.Key == city)
                {
                    Console.WriteLine("City: {0} Person name: {1}", cityView.Key, cityView.Value.GetName());
                }
            }
        }

        public void ViewState()
        {
            Console.WriteLine("Enter the State name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, Person> stateView in personCity)
            {
                if (stateView.Key == city)
                {
                    Console.WriteLine("City: {0} Person name: {1}", stateView.Key, stateView.Value.GetName());
                }
            }
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

