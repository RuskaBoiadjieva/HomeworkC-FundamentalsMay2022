using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //2 1 1 2 3 3 2 2 2 1
            int longestSeq = 0;
            int seqNumber=0;
            int count = 1;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] ==numbers[i+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                
                if (count>longestSeq)
                {
                    longestSeq = count;
                    seqNumber = numbers[i];
                }
               
            }
            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write(seqNumber + " ");
            }
        }
    }
}
