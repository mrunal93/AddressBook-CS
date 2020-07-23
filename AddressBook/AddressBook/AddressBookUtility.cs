using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookUtility
    {
        string name, address, city, state, phoneNumber, zip;
        static ArrayList personDetails = new ArrayList();
        Dictionary<string, Person> personCity = new Dictionary<string, Person>();
        Dictionary<string, Person> personState = new Dictionary<string, Person>();
        Dictionary<string, Person> personZip = new Dictionary<string, Person>();

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
            Person personAdd = new Person(name, address, city, state, zip, phoneNumber);
            Person dupilicate = SearchPerson(name);
            if (personAdd.Equals(dupilicate))
            {
                Console.WriteLine("Person already in the List");
            }
            personDetails.Add(personAdd);
            personDetails.Add(personAdd);
            personCity.Add(city, personAdd);
            personState.Add(state, personAdd);
            personZip.Add(zip, personAdd);
        }
        public void EditPerson()
        {
            Person personEdit = new Person(name, address, city, state, zip, phoneNumber);
            Console.WriteLine("Enter the name of person");
            string nameCheck = Console.ReadLine();
            foreach (Person person in personDetails)
            {
                if (person.GetName().Equals(nameCheck))
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
                personDetails.Add(personEdit);

            }   
        }
   
        public Person SearchPerson(string name)
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

        

        public void DeletePerson()
        {
            Console.WriteLine("Enter the Person Name:");
            string name = Console.ReadLine();
            Person personDelet = SearchPerson(name);
            if (personDelet != null)
            {
                personDetails.Remove(personDelet);
            }
        }
        public void DisplayAddressBook()
        {
            foreach (Person person in personDetails)
            {
                Console.WriteLine("{0} :: {1} :: {2} :: {3} :: {4} :: {5}",person.GetName(), person.GetPhoneNumber(), person.GetState(), person.GetCity(), person.Getzip(), person.GetAddress());
              
            }
        }

        public void ShortCity()
        {
            foreach (KeyValuePair<string, Person> sortCity in personCity.OrderBy(keyCity => keyCity.Key))
            {

                Console.WriteLine("City name: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortCity.Key, sortCity.Value.GetName(), sortCity.Value.GetState(), sortCity.Value.Getzip(), sortCity.Value.GetPhoneNumber());
            }

        }
        public void ShortState()
        {
            foreach (KeyValuePair<string, Person> sortState in personState.OrderBy(keyState => keyState.Key))
            {

                Console.WriteLine("State name: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortState.Key, sortState.Value.GetName(), sortState.Value.GetCity(), sortState.Value.Getzip(), sortState.Value.GetPhoneNumber());

            }
        }
        public void ShortZip()
        {
            foreach (KeyValuePair<string, Person> sortZip in personZip.OrderBy(keyZip => keyZip.Key))
            {
                Console.WriteLine("ZIP: {0}, Details: {1} ::: {2} ::: {3} ::: {4}", sortZip.Key, sortZip.Value.GetName(), sortZip.Value.GetCity(), sortZip.Value.GetState(), sortZip.Value.GetPhoneNumber());
            }
        }
        public void ShortPersion()
        {
            personDetails.Sort();
            foreach (Person sort in personDetails)
            {
                Console.WriteLine(sort.GetName());
            }
        }

        public void ViewCity()
        {
            Console.WriteLine("Enter the city name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, Person> cityView in personCity)
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
    }
}
