using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                
                if (doubleNumbers[i]==0)
                {
                    doubleNumbers[i] = 0;
                }
                int roundedNumbers =(int) Math.Round(doubleNumbers[i], MidpointRounding.AwayFromZero);
               
                Console.WriteLine($"{doubleNumbers[i]} => {roundedNumbers}");

              
            }
        }
    }
}
