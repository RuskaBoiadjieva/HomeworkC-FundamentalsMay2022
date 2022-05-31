using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split();
            //string[] reversed = new string[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    reversed[i] = input[input.Length - 1 - i];
            //    Console.Write($"{reversed[i]} ");
            //}

            //for (int i = 0; i < input.Length; i++)
            //{
            //    reversed[reversed.Length - 1 - i] = input[i];

            //}
            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.Write($"{reversed[i]} ");
            //}

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.Write($"{reversed[reversed.Length-1-i]=input[i]} ");
            //}

            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Console.Write(String.Join(" ", input));

        }
    }
}
