using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUC_2
{
    class ContactPerson
    {
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
            Console.WriteLine("FirstName:" + this.FirstName + "LastName:" + this.LastName + "Address:" + this.Address + "City:" + this.City + "State:" + this.State + "ZipCode:" + this.ZipCode + "PhoneNumber:" + this.PhoneNumber + "Email:" + this.Email);
        }
        public void AddContact()
        {
            Console.WriteLine("Enter FirstName,LastName,AddressBookSystem,City,State,ZipCode,PhoneNumber,Email\n");

            ContactPerson objcontact = new ContactPerson();
            {

                FirstName = Console.ReadLine();
                LastName = Console.ReadLine();
                Address = Console.ReadLine();
                City = Console.ReadLine();
                State = Console.ReadLine();
                ZipCode = Convert.ToInt32(Console.ReadLine());
                PhoneNumber = Convert.ToDouble(Console.ReadLine());
                Email = Console.ReadLine();

            };
            List<ContactPerson> objList = new List<ContactPerson>();
            objList.Add(objcontact);
            objcontact.displayContact();
        }
    }
}