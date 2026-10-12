using System;

namespace task4
{
    class Student
    { //part 1
        public string name;
        public int age;
        public double grade;
        //part 5
        public Student(string studentName, int studentAge, double studentGrade)
        {
            name = studentName;
            age = studentAge;
            grade = studentGrade;
        }
        //part2
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade" + grade);
        }
    }
}