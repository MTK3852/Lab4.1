using System;

namespace Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.Rating = 75;
            student2.Rating = 35;
            student3.Rating = 100;
            student2.Adress = "HEllo";
            Console.Write("Student 1:");
            Console.WriteLine(student1.StudentRating(student1.Rating));
            Console.Write("Student 2:");
            Console.WriteLine(student2.StudentRating(student2.Rating));
            Console.Write("Student 3:");
            Console.WriteLine(student3.StudentRating(student3.Rating));

            Console.ReadKey();

        }
    }
}
