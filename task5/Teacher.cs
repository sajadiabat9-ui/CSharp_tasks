using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher:Person
    {
        // Public auto-implemented property
        public string Subject { get; set; }

        // Calls Person constructor using base
        public Teacher(string name, int age, string schoolName,
                       string subject)
            : base(name, age, schoolName)
        {
            Subject = subject;
        }

        // Displays teacher information
        public void DisplayTeacherInfo()
        {
            DisplayInfo();
            Console.WriteLine("Subject: " + Subject);
        }
    }

}

