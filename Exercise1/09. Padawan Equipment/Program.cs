using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double sum = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceSaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double totalSum = priceSaber * (students + Math.Ceiling(students * 0.1)) +
                priceRobes * students + priceBelts * (students - students / 6);



            if (sum>=totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum-sum:f2}lv more.");
            }

           


        }
    }
}
