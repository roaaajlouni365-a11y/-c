using System;

namespace task5
{
    public class Person
    {
        private string _internalCode; //cannot access from any external class except Person Class
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }
        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age:  " + Age);
        }
    
     public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}

