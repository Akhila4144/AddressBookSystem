using System;

namespace AddressBookUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Address Book Program ************\n");

            PersonsDetails.AddContact();
            PersonsDetails.Display();
             PersonsDetails.Delete();
           
        }
    }

    }

