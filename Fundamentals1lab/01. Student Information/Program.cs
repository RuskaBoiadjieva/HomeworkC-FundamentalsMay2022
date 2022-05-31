using System;

namespace _01._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student name, age and average grade
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
