using System;

namespace _13._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string numbers = string.Empty;
            string num1 = string.Empty;
            string num2 = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                numbers += Console.Read();
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[j]!=' ')
                    {
                        num1 += numbers[j];
                    }
                    else
                    {
                            
                    }
                }


            }
        }
    }
}
