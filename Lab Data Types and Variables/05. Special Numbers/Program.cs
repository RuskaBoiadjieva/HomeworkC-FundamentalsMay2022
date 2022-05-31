using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    int lastNum = num % 10;
                    sum += lastNum;
                    num /= 10;
                }
                bool isTrue = sum == 5 || sum == 7 || sum == 11;
                
                    Console.WriteLine($"{i} -> {isTrue}");
                
            }
        }
    }
}
