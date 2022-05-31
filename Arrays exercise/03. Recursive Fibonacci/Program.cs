using System;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];


            //1, 1, 2, 3, 5, 8, 13, 21, 34…
            if (numbers == 1)
            {
                array[0] = 1;
            }

            if (numbers >= 2)
            {

                array[0] = 1;
                array[1] = 1;
                for (int i = 2; i < numbers; i++)
                {
                    array[i] = array[i - 2] + array[i - 1];
                }
            }
            Console.WriteLine(array[numbers-1]);
        }
    }
}
