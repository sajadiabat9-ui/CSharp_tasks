using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student Information
            string studentName = "Sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool isStudentActive = true;


            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + studentAge);
            Console.WriteLine("Student Grade: " + studentGrade);
            Console.WriteLine("Student Average: " + studentAverage);
            Console.WriteLine("Student Gender: " + studentGender);
            Console.WriteLine("Is Student Active: " + isStudentActive);




            string[] students = { "Saja", "Yasmeen", "Deyaa", "Lina" };

            Console.WriteLine("Students Before Changes");
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("Number Of Students : " + students.Length);



            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("Students After Changes");
            students[0] = "Rahaf";
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
        }
    }
}
