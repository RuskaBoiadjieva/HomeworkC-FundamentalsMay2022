using System;
using System.Linq;
using System.Text;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //•	The code of each vowel multiplied by the string length
            //•	The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it on the console.


            int numOfSeq = int.Parse(Console.ReadLine());
            int[] arrayOfSum = new int[numOfSeq];

            for (int i = 0; i < numOfSeq; i++)
            {
                string input = Console.ReadLine();
               
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {

                    if (input[j] == 'a' || input[j] == 'e' || input[j] == 'o' || input[j] == 'i' || input[j] == 'u'
                        || input[j] == 'A' || input[j] == 'E' || input[j] == 'O' || input[j] == 'I' || input[j] == 'U')
                    {
                        sum += input[j] * input.Length;
                    }
                    else
                    {
                        sum += input[j] / input.Length;
                    }

                }

                arrayOfSum[i]= sum;

            }

            Array.Sort(arrayOfSum);
            for (int i = 0; i < numOfSeq; i++)
            {
                Console.WriteLine(arrayOfSum[i]);
            }
        }
    }
}
