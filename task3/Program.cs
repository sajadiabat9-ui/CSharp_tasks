using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(50, 76);

            int guess = 0;
            int attempts = 0;
            int points = 0;

            Console.WriteLine("Guessing Game ");

            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations!");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Try a lower number.");
                }
            }

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);


            //school system 
            Console.WriteLine("school system");
            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };

            int[] grades = { 85, 92, 68, 75, 90 };

            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nStudents:");

                        for (int s = 0; s< students.Length; s++)
                        {
                            Console.WriteLine(students[s]);
                        }

                        Console.WriteLine("\nGrades:");

                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);
                        }

                        break;


                    case 2:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        int i = 0;
                        bool found = false;

                        while (i < students.Length)
                        {
                            if (students[i] == name)
                            {
                                Console.WriteLine("Student Found!");
                                found = true;
                                break;
                            }

                            i++;
                        }

                        if (found == false)
                        {
                            Console.WriteLine("Student Not Found.");
                        }

                        break;


                    case 3:
                        Console.Write("Enter student grade: ");
                        int gradeInput =
                            Convert.ToInt32(Console.ReadLine());

                        if (gradeInput >= 90 && gradeInput <= 100)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (gradeInput >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (gradeInput >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (gradeInput >= 60)
                        {
                            Console.WriteLine("Pass");
                        }
                        else if (gradeInput >= 0)
                        {
                            Console.WriteLine("Fail");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Grade");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
            
