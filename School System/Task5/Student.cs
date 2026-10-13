
using System;

namespace task5
{
    public class Student : Person
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int age, string schoolName, int grade, int studentId)
       : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"StudentId: {StudentId}, Grade: {Grade}, School: {SchoolName}");
        }
    }
}
