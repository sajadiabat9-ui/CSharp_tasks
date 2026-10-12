using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("===== Student Information =====");
                Console.WriteLine();

                // Create 3 objects using the constructor
                student student1 = new student("Ahmad", 20, 85);
                student student2 = new student("Sara", 21, 92);
                student student3 = new student("Omar", 19, 78);

                // Display information
                student1.DisplayInfo();
                student2.DisplayInfo();
                student3.DisplayInfo();
            }
        }
    }
}
