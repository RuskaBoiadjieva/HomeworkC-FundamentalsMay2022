using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
      
       

           
            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum=0;
                int leftSum=0;
                for (int right = i+1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];

                }
                if (rightSum==leftSum)
                {
               
                    Console.WriteLine(i);
                    return;
                }
            }
           
                Console.WriteLine("no");
            

        }
    }
}
