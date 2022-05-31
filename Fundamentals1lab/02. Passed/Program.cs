using System;

namespace _02._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //takes as an input a grade 
            //prints "Passed!" if the grade is equal or more than 3.00

            double grade = double.Parse(Console.ReadLine());
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
