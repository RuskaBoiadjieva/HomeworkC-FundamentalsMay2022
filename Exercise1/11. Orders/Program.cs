using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            //We are placing N orders-((daysInMonth * capsulesCount) * pricePerCapsule)

            for (int i = 1; i <= orders; i++)
            {

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());
                Console.WriteLine($"The price for the coffee is: ${days * countCapsules * pricePerCapsule:f2}");
                totalPrice += days * countCapsules * pricePerCapsule;

                

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

            //For each order •	"The price for the coffee is: ${price}"
            //"Total: ${totalPrice}"
        }
    }
}
