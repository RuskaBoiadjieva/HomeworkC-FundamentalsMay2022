using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //that receives a single integer and calculates is it a strong or not
            //if the sum of the Factorial of each digit is equal to the number
            //Print "yes" if the number is strong or "no" if the number is not strong.

            int num = int.Parse(Console.ReadLine());
            int chislo = num;
            int factoriel=1;
            int sum = 0;
            while (chislo>0)
            {

                int m = chislo % 10;

                for (int i = 1; i <= m; i++)
                {
                    
                     factoriel *= i;

                }

                sum += factoriel;
                factoriel = 1;
                chislo /= 10;
            }

            if (sum==num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }







        }
    }
}
