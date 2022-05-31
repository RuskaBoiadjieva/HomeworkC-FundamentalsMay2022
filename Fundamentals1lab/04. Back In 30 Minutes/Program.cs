using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = minutes + 30;

            if (sum>59)
            {
                sum -= 60;
                hours++;
            }
            if (hours>23)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{sum:d2}");
        }
    }
}
