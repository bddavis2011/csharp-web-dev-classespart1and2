using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student brittany = new Student("Brittany", 1, 1, 4.0);
            Console.WriteLine("The student class works!" + brittany.Name + "is a student!");
        }
    }
}
