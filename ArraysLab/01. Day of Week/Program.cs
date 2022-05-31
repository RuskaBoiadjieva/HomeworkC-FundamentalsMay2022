using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());

            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (numberOfDay>7 || numberOfDay<1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {

                Console.WriteLine(dayOfWeek[numberOfDay-1]);
            }
        }
    }
}
