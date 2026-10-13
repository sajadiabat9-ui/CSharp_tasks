using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class student
    {
        
        public string Name;
        public int Age;
        public int Grade;

        // Constructor
        public student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine();
        }
    }
}

