using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string coins = (Console.ReadLine());
            double sum = 0;
            double price = 0;
            double totalPrice = 0;

            while (coins != "Start")
            {
                double money = double.Parse(coins);

                if (money == 0.1 || money == 0.2 || money == 0.5
                    || money == 1 || money == 2)
                {
                    sum += money;

                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");

                }
                coins = (Console.ReadLine());
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                        break;
                }
                totalPrice += price;
                if (totalPrice <= sum)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    totalPrice -= price;
                }
                input = Console.ReadLine();

            }

            if (sum>=totalPrice)
            {
                    
            Console.WriteLine($"Change: {sum - totalPrice:f2}");
            }
        }
    }
}
