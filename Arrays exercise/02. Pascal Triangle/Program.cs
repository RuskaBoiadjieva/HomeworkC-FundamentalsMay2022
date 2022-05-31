using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string currentRow = "1 1";
            if (num>=2)
            {
            Console.WriteLine(1);
            Console.WriteLine(currentRow);

            }
            else
            {
                if (num==1)
                {
                    Console.WriteLine(1);
                }
                
            }
            string newRow = string.Empty;
            for (int i = 3; i <= num; i++)
            {
                int[] array = currentRow.
                    Split(' ',StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();
                
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        newRow += 1 + " ";
                    }
                    else if (j == i - 1)
                    {
                        newRow += 1;
                    }
                    else
                    
                    {
                        int newElement = 0;
                        
                            newElement = array[j-1] + array[j];
                            newRow += newElement + " ";
                        
                    }
                }
                currentRow = newRow;
                newRow = string.Empty;
                Console.WriteLine(currentRow);
            }
        }
    }
}
