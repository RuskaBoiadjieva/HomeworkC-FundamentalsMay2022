using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countLetter = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a'+countLetter; i++)
            {
                for (char j = 'a'; j < 'a' + countLetter; j++)
                {
                    for (char k = 'a'; k < 'a' + countLetter; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
