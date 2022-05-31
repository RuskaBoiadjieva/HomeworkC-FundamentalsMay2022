using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastdigit = 0;
            bool isTrue = false;
            for (int i = 1; i <= number; i++)
            {
                lastdigit = i;
                while (lastdigit > 0)
                {
                    sum += lastdigit % 10;
                    lastdigit = lastdigit / 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isTrue);
                sum = 0;
                lastdigit=0;
            }

        }
    }
}
