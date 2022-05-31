using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countLetters = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < countLetters; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                sum += symbols;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
