using System;
using System.Linq;

namespace forTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SPLIT
            //string[] rowSplit = "1, 2, 3, age, name, adress".Split(", ");
            //for (int i = 0; i < rowSplit.Length; i++)
            //{
            //    Console.WriteLine(rowSplit[i]);
            //}

            //string[] rowOfNumbers = Console.ReadLine().Split();
            //int[] numbers = new int[rowOfNumbers.Length];
            //for (int i = 0; i < rowOfNumbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(rowOfNumbers[i]);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"[{i}]={numbers[i]}");
            //}

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[{i}]={numbers[i]}");
            }
        }
    }
}
