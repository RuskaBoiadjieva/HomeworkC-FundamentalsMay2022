using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int finalChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= finalChar; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
