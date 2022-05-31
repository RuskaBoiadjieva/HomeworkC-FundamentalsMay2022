using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int num1 = input[0];
                int num2 = input[1];
                if (i%2==0)
                {
                    array1[i] = num1;
                    array2[i] = num2;
                }
                else
                {
                    array1[i] = num2;
                    array2[i] = num1;
                }


            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
