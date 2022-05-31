using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the given integer is divisible by 2, or 3,  or 6,  or 7, or 10 

            //•	If the number is divisible by both 2, 3, and 6, you should print only the division by 6 only.
            //•	If a number is divisible by 2 and 10, you should print the division by 10.

            //"Not divisible". Otherwise, print "The number is divisible by {number}".

            int num = int.Parse(Console.ReadLine());
            int div = 0;

            if (num%2==0)
            {
                div = 2;
            }
            if (num%3==0)
            {
                if (div<3)
                {
                    div = 3;
                }
            }
            if (num%6==0)
            {
                if (div < 6)
                {
                    div = 6;
                }
            }
            if (num % 7 == 0)
            {
                if (div < 7)
                {
                    div = 7;
                }
            }
            if (num % 10 == 0)
            {
                if (div < 10)
                {
                    div = 10;
                }
            }
            if (div==0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {div}");
            }

        }
    }
}
