
using System;

namespace task5
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string schoolName, string subject)
     : base(name, age, schoolName)
        {
            Subject = subject;
        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
