using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int countDays = 0;
            int totalSpice = 0;
            int perDay = startingYield;

            while (startingYield>=100)
            {
                countDays++;
                perDay -= 26;
                startingYield -= 10;
                totalSpice += perDay;
                perDay = startingYield;

            }
            if (countDays>0)
            {
            totalSpice -= 26;

            }
            Console.WriteLine(countDays);
            Console.WriteLine(totalSpice);

        }
    }
}
