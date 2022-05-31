using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());
            int newNumber = 0;
            string message = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                newNumber = keyNumber + letter;
                message += (char)newNumber;
            }
            Console.WriteLine(message);

        }
    }
}
