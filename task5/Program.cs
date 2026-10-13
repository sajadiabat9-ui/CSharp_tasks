using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create first Student object
            Student student1 = new Student(
                "Ahmad", 16, "Al Noor School", 10, 101);

            // Create second Student object
            Student student2 = new Student(
                "Sara", 17, "Al Noor School", 11, 102);

            // Display first student's information
            Console.WriteLine("=== Student 1 ===");
            student1.DisplayStudentInfo();

            // Display second student's information
            Console.WriteLine("\n=== Student 2 ===");
            student2.DisplayStudentInfo();

            // DisplayInfo() can also be called directly
            Console.WriteLine("\n=== Student Name and Age ===");
            student1.DisplayInfo();

            // Create Teacher object
            Teacher teacher1 = new Teacher(
                "Mr. Khaled", 35, "Al Noor School", "Math");

            // Display teacher information
            Console.WriteLine("\n=== Teacher ===");
            teacher1.DisplayTeacherInfo();



            // This line causes an error because SchoolName is protected.
            //Console.WriteLine(student1.SchoolName);

            // This line causes an error because _internalCode is private
            // and can only be accessed inside the Person class.
            //Console.WriteLine(student1._internalCode);

            // sealed prevents other classes from inheriting from SchoolReport.
            // For example, class SpecialReport : SchoolReport is not allowed.

            // Create SchoolReport object
            SchoolReport report = new SchoolReport("Final School Report");

            // Display report title
            Console.WriteLine("\n=== School Report ===");
            report.DisplayReportTitle();
        }
    }
    }

