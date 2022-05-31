using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
           
            int countOpen = 0;
            
            int countClose = 0;

            for (int i = 0; i < nLines; i++)
            {
                string input = Console.ReadLine();
                if (input=="(")
                {
                    countOpen++;
                }
                if (input==")")
                {
                    countClose++;
                if (countOpen-countClose!=0)
                {
                    break;
                }
                
                }
            }
            if (countOpen==countClose)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
