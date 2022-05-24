using System;
using System.Collections.Generic;

namespace AddressListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomList = new List<string>();

            randomList.Add("123 Street");
            randomList.Add("222 Road");
            randomList.Add("112 Blvd");
            randomList.Add("Yo boy its a road");

            foreach (string el in randomList)
            {
                Console.WriteLine(el);
            }

            List<Address> listOfAddressClasses = new List<Address>();
            listOfAddressClasses.Add(new Address("123 Street"));
            listOfAddressClasses.Add(new Address("222 Road"));
            listOfAddressClasses.Add(new Address("112 Blvd"));
            listOfAddressClasses.Add(new Address("Yo boy its a road"));

            foreach (Address address in listOfAddressClasses)
            {
                address.printAddress();
            }
        }

    }

    public class Address
    {
        private string givenAddress;

        public Address(string input)
        {
            givenAddress = input;
        }

        public void printAddress()
        {
            Console.WriteLine($"You're in an Address Class! {givenAddress}");
        }
    }



}