using System;
using System.Collections.Generic;


namespace AddressBook
{
    class Helper
    {
        List<Person> PERSON = new ArrayList<Person>();

        String fname = null;
        static String lname, address, city, state, phone, zip;

        public void addRecord()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Enter First Name");
                fname = Console.ReadLine();
                if (CheckExist(fname))
                {
                    Console.WriteLine("Record with name " + fname + " already exist!!\nPlease enter another name");
                    i = 1;
                }
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
        }
        public void displayRecord()
        {

            foreach (Person person in PERSON)
            {
                Console.WriteLine(person);
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
                        String option = Console.ReadLine();
                        int choice = Convert.ToInt32(option);
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
                        Console.WriteLine(PERSON);
                    }
                } //end of edit() method
            }
        }
        public void deleteRecord()
        {
            int id;
            foreach (Person p in PERSON)
            {
                Console.WriteLine("ID: #" + PERSON.IndexOf(p) + " : " + p);

            }
            id = Console.Read();
            Console.WriteLine("\nEnter #ID to delete Contact : ");
            PERSON.RemoveAt(id);
        }


        public bool CheckExist(string fname)
        {
            int flag = 0;
            foreach (Person person in PERSON)
            {
                if (person.getFname().Equals(fname))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            return false;
        }
    }

}