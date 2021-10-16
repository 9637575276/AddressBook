using System;
using System.Collections.Generic;


namespace AddressBook
{
    class Helper
    {
        List<Person> p = new ArrayList<Person>();

        public void addRecord()
        {

            String fname, lname, address, city, state, phone, zip;
            Console.WriteLine("Enter First Name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            Console.WriteLine("Enter State");
            state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            zip = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            phone = Console.ReadLine();
            p.Add(new Person(fname, lname, address, city, state, phone, zip));
        }
        public void displayRecord()
        {
            for (int i = 0; i <= p.Count; i++)
            {
                Console.WriteLine(p);
            }

        }

    }


}