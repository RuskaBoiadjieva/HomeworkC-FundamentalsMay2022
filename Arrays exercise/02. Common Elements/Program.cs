using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();
            string commonElements = string.Empty;
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i]==array1[j])
                    {
                        commonElements += array2[i] + " ";
                    }
                }
            }
            Console.WriteLine(commonElements);
            //2ri nachin
            //string[] result = array2.Intersect(array1).ToArray();
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
