using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double result = Math.Ceiling((double)numberPeople / capacity);

            //int result = numberPeople / capacity;
            //int ostatak = numberPeople % capacity;
            //if (ostatak>0)
            //{
            //    result++;
            //}
            Console.WriteLine(result);
        }
    }
}
