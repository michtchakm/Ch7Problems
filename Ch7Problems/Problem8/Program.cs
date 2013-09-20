using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            School[] school = new School[5];

            for (int i = 0; i < school.Length; i++)
            {
                school[i] = new School();

                Console.WriteLine("Enter School Name");
                input = Console.ReadLine();
                school[i].SchoolName = input;

                Console.WriteLine("Enter school enrollment number");
                input = Console.ReadLine();
                school[i].EnrollmentNumber = Convert.ToInt32(input);

                Console.WriteLine("enter next school name");
                input = Console.ReadLine();
                school[i].SchoolName = input;

                Console.WriteLine("Enter next school enrollment number");
                Console.ReadLine();
                school[i].EnrollmentNumber = Convert.ToInt32(input);
            }
        }
    }
}
