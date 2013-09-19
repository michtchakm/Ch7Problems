using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            Friend[] friend = new Friend[8];
            int x;
            string Name;
            string PhoneNumber;
            string BirthdayYear;
            string 
                BirthdayMonth;
            string BirthdayDay;

            for (x = 0; x < friend.Length; x++ )
            {
                //GetData(out Name, out PhoneNumber, out BirthdayDay, out BirthdayMonth, out BirthdayYear);
                Console.WriteLine("\nFriend #{0}", x);

                Console.Write("Enter Name: ");
                Name = Console.ReadLine();

                Console.Write("Phone Number (000) 000-0000: ");
                PhoneNumber = Console.ReadLine();

                Console.Write("Birthday Year 0000: ");
                BirthdayYear = Console.ReadLine();

                Console.Write("Birthday Month 00: ");
                BirthdayMonth = Console.ReadLine();

                Console.Write("Birthday Day 00: ");
                BirthdayDay = Console.ReadLine();


                //friend[x] = new Friend(PhoneNumber, BirthdayDay, BirthdayMonth, BirthdayYear, Name);
            }
        }
    }
}

