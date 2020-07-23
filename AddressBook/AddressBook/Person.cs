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

