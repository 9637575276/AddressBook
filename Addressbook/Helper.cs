using System;
using System.Collections.Generic;


namespace AddressBook
{
    class Helper
    {
        List<Person> PERSON = new ArrayList<Person>();
        public static int id { get; set; }
        static String fname, lname, address, city, state, phone, zip;

        public void addRecord()
        {

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
            PERSON.Add(new Person(fname, lname, address, city, state, phone, zip));
        }
        public void displayRecord()
        {
            for (int i = 0; i <= PERSON.Count; i++)
            {
                Console.WriteLine(PERSON);
            }

        }
        public void editRecord(String fname)
        {
            for (int k = 0; k < PERSON.Count; k++)
            {
                Console.WriteLine(PERSON);
                if (PERSON[k].getFname().Equals(fname))
                {
                    Person person = PERSON[k];
                    Console.WriteLine(person);
                    while (k == 0)
                    {
                        Console.WriteLine("What You Want to edit...\n"
                                + "\t1: Address\n"
                                + "\t2: city\n"
                                + "\t3: State\n"
                                + "\t4: Phone\n"
                                + "\t5: Zip Code\n"
                                + "\t6. Save And Exit\n");
                        int choice = Console.Read();
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter new Street : ");
                                String address = Console.ReadLine();
                                person.setAddress(address);
                                break;
                            case 2:
                                Console.WriteLine("Enter new City : ");
                                String city = Console.ReadLine();
                                person.setCity(city);
                                break;
                            case 3:
                                Console.WriteLine("Enter new State : ");
                                String state = Console.ReadLine();
                                person.setState(state);
                                break;
                            case 4:
                                Console.WriteLine("Enter new Phone : ");
                                String phone = Console.ReadLine();
                                person.setPhone(phone);
                                break;
                            case 5:
                                Console.WriteLine("Enter new Zip Code : ");
                                String zip = Console.ReadLine();
                                person.setZip(zip);
                                break;
                            case 6:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        //Console.WriteLine(PERSON.Find(id));
                    }
                } //end of edit() method

            }

        }
    }
}