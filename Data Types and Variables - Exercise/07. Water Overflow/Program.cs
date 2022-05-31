using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int volume = 0;
            int litters = 0;
            for (int i = 0; i < n; i++)
            {
                litters = int.Parse(Console.ReadLine());
                if (litters + volume <= 255)
                {
                    volume += litters;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(volume);
        }
    }
}
