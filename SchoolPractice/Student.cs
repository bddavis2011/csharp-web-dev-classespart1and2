using System;
using System.Collections.Generic;

public class Student
{
    private static int nextStudentId = 1;
    public string Name { get; set; }
    public int StudentId { get; set; }
    public int NumberOfCredits { get; set; } = 0;
    public double Gpa { get; set; } = 0.0;

    public Student(string name, int studentId, int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public Student(string name, int studentId) : this(name, studentId, 0, 0) { }

    public Student(string name) : this(name, nextStudentId)
    {
        nextStudentId++;
    }
}

namespace SchoolPractice
{
    public class Student
    {
        private string Name;
        private int StudentId;
        private int NumberOfCredits;
        private double Gpa;
    }
}
