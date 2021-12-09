using System;
using System.Collections.Generic;
using System.Text;

namespace BookSysForUpdate
{
    class ContactPerson
    {
        List<ContactPerson> objList = new List<ContactPerson>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }

        public void displayContact()
        {
            foreach (var item in objList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Address + " " + item.City + " " + item.State + " " + item.ZipCode + " " + item.PhoneNumber + " " + item.Email);
            }
        }

        public void updateContact(string name)
        {
            foreach (var item in objList)
            {
                if (item.FirstName == name)
                {
                    Console.WriteLine("Do you Want to Update zip(y/n):");
                    char ch = char.Parse(Console.ReadLine());
                    if (ch == 'y')
                    {
                        int update_zip = int.Parse(Console.ReadLine());
                        item.ZipCode = update_zip;
                    }

                    Console.WriteLine("Do you Want to Update phone:");
                    char ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'y')
                    {
                        double updateNum = Convert.ToDouble(Console.ReadLine());
                        item.PhoneNumber = updateNum;
                    }
                    Console.WriteLine("Do you Want to Update City:");
                    var ch2 = char.Parse(Console.ReadLine());
                    if (ch2 == 'y')
                    {
                        string updateCity = Convert.ToString(Console.ReadLine());
                        item.City = updateCity;
                    }
                    Console.WriteLine("Do you Want to Update State:");
                    char ch3 = char.Parse(Console.ReadLine());
                    if (ch3 == 'y')
                    {
                        string updateState = Convert.ToString(Console.ReadLine());
                        item.State = updateState;
                    }
                    Console.WriteLine("Do you want to update Email(y/n):");
                    char ch4 = char.Parse(Console.ReadLine());
                    if (ch4 == 'y')
                    {
                        string updatedEmail = Console.ReadLine();
                        item.Email = updatedEmail;
                    }

                    Console.WriteLine("Do you want to update Address(y/n):");
                    char ch5 = char.Parse(Console.ReadLine());
                    if (ch5 == 'y')
                    {
                        string updatedAddress = Console.ReadLine();
                        item.Address = updatedAddress;
                    }

                    Console.WriteLine("Do you want to update Lastname(y/n):");
                    char ch6 = char.Parse(Console.ReadLine());
                    if (ch6 == 'y')
                    {
                        string updatedLName = Console.ReadLine();
                        item.LastName = updatedLName;
                    }

                    Console.WriteLine("Do you want to update Firstname(y/n):");
                    char ch7 = char.Parse(Console.ReadLine());
                    if (ch7 == 'y')
                    {
                        string updatedFName = Console.ReadLine();
                        item.FirstName = updatedFName;
                    }

                    return;
                }
            }
        }
                public void deleteContact(string s)
                {

                    foreach (var item in objList)
                    {
                        if (item.FirstName == s)
                        {


                            objList.Remove(item);
                            return;
                        }
                    }
                }
                public void AddContact()
                {

                    Console.WriteLine("Enter Firstname,LastName,Address,City,State,Zipcode,Phone,Email\n");
                    
                    ContactPerson contact = new ContactPerson()//object initializer
                    {
                        FirstName = Console.ReadLine(),
                        LastName = Console.ReadLine(),
                        Address = Console.ReadLine(),
                        City = Console.ReadLine(),
                        State = Console.ReadLine(),
                        ZipCode = Convert.ToInt32(Console.ReadLine()),
                        PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                        Email = Console.ReadLine(),

                    };

                    objList.Add(contact);
                    Console.ReadKey();

                }
            }
        }
    


            
        

