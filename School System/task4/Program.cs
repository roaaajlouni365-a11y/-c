using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student( "Roaa", 21 ,90);
            Student s2 = new Student("Lubna", 27 ,85);
            Student s3 = new Student("Sura", 25  ,92);

            s1.DisplayInfo();

            Console.WriteLine("----------");

            s2.DisplayInfo();

            Console.WriteLine("----------");

            s3.DisplayInfo();

            Console.ReadKey();
        }
    }
}
