using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lineOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                lineOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lineOfNumbers.Length/2; i++)
            {
                int temp = lineOfNumbers[i];
                lineOfNumbers[i] = lineOfNumbers[lineOfNumbers.Length - 1 - i];
                lineOfNumbers[lineOfNumbers.Length - 1 - i] = temp;
            }

            //int[] newLine = new int[lineOfNumbers.Length];

            //for (int i = 0; i < lineOfNumbers.Length; i++)
            //{
            //    newLine[i] = lineOfNumbers[lineOfNumbers.Length - 1 - i];
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    lineOfNumbers[lineOfNumbers.Length-1-i] = int.Parse(Console.ReadLine());

            //}
            for (int i =0; i < lineOfNumbers.Length; i++)
            {
                Console.Write(lineOfNumbers[i] + " ");
            }

        }
    }
}
