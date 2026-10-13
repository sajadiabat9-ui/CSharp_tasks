using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        // Public properties: can be accessed from Main()
        public string Name { get; set; }
        public int Age { get; set; }

        // Protected property: accessible inside Person and derived classes
        protected string SchoolName { get; set; }

        // Private field: can only be accessed inside Person
        private string _internalCode;

        // Constructor of Person
        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
            _internalCode = "P001";
        }

        // Public method to display name and age
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
