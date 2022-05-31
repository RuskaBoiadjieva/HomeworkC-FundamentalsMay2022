using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //            1 2  3 4 5 6  7 8      5 5 13 13   2  1  8  7 +
            //                                               3  4  5  6 =
            //                                               5  5 13 13


            int[] array1 = new int[initialArr.Length / 4];
            int[] arrayMidles = new int[initialArr.Length / 2];
            int[] array2 = new int[initialArr.Length / 4];
            int[] newArray = new int[initialArr.Length / 2];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = initialArr[initialArr.Length / 4 -i-1];
            }
            //Console.WriteLine(String.Join(" ", array1));
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = initialArr[initialArr.Length - 1 - i];
            }
            //Console.WriteLine(String.Join(" ", array2));
            for (int i = 0; i < arrayMidles.Length; i++)
            {
                arrayMidles[i] = initialArr[initialArr.Length/4+i];
            }
            //Console.WriteLine(String.Join(" ", arrayMidles));

            for (int i = 0; i < arrayMidles.Length/2; i++)
            {
                newArray[i] = array1[i] + arrayMidles[i];
            }
            for (int i = arrayMidles.Length/2; i < arrayMidles.Length; i++)
            {
                newArray[i] = array2[i-array2.Length] + arrayMidles[i];
            }
            Console.WriteLine(String.Join(" ", newArray));
        }
    }
}
