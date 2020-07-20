using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;

namespace AddressBook
{
    public class Person
    {
        private String firstName, lastName, address, city, state, phoneNumber;
        private int zip;


        // public Person(String firstName,String lastName,String address,String city,String state,int zip,String phoneNumber)
        //{
        //  this.firstName = firstName;
        //this.lastName = lastName;
        // this.address = address;
        // this.city = city;
        //this.state = state;
        //this.zip = zip;
        //this.phoneNumber = phoneNumber;

        //}

        public String getSetFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String getSetLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String getsetaddress
        {
            get { return address; }
            set { address = value; }
        }
        public String getSetCity
        {
            get { return city; }
            set { city = value; }
        }
        public String getSetState
        {
            get { return state; }
            set { state = value; }

        }
        public String getSetPhoneNo
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int getSetZip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}