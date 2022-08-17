using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public double YearsTeaching { get; set; } = 0;

        public Teacher(string FirstName, string LastName, string Subject, double YearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
