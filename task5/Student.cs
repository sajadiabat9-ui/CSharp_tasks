using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        // Public auto-implemented property
        public int Grade { get; set; }

        // Public property
        public int StudentId { get; set; }

        // Constructor calls Person constructor using base
        public Student(string name, int age, string schoolName,
                       int grade, int studentId)
            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        // Uses protected SchoolName inside the derived class
        public void DisplayStudentInfo()
        {
            DisplayInfo();

            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("School: " + SchoolName);
        }
    }
}
