using System;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {     //part1 => Student Information
            string studentName = "Roaa";
            int studentAge = 21;
            int studentGrade = 95;
            double studentAverage = 85.5;
            char studentGender = 'A';
            bool studentActive = false;

            Console.WriteLine("Student Information:");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("Active:  " + studentActive);

            //part2 => Multiple Students
            string[] students = { "Sura", "Osama", "Lubna", "Basil" };

            Console.WriteLine(" List of Students : ");
            Console.WriteLine("Student1 :" + students[0]);
            Console.WriteLine("Student2 :" + students[1]);
            Console.WriteLine("Student3 :" + students[2]);
            Console.WriteLine("Student4 :" + students[3]);
            //Part 3 => Access and Change Array Elements
            Console.WriteLine("List of Students after Change  ");
            students[2] = "Rana";
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            
           
          
        }

    }
}
