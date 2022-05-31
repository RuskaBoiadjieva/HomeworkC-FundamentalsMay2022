using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 7 6 2 19 23
            //8

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (i != j)
                    {

                        if (n == array[i] + array[j])
                        {
                            Console.WriteLine($"{array[i]} {array[j]}");
                        }
                    }

                }
            }

        }
    }
}
