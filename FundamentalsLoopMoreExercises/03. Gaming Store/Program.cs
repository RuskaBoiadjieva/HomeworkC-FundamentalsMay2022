using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double currentBalance = double.Parse(Console.ReadLine());
            double price1 = 39.99;
            double price2 = 15.99;
            double price3 = 19.99;
            double price4 = 59.99;
            double price5 = 29.99;
            double price6 = 39.99;
            double currentPrice = 0;
            double totalSpent = 0;
            string inputGame = Console.ReadLine();
            //If a game- is not present in the table above, print "Not Found" and read the next line.
            //the user has $0 left, print "Out of money!" and end the program.
            //to buy a game that they can’t afford, print "Too Expensive" and read the next line.
            //•	If the game exists and the player has the money for it, print "Bought {nameOfGame}"

            //Until you receive the command "Game Time", you have to keep buying games
            //When a game is bought, the user’s balance decreases by the price of the game
            //When you receive "Game Time", print the user’s remaining money and total spent on games, rounded to the 2nd decimal place.
            while (inputGame!= "Game Time")
            {
                switch (inputGame)
                {
                    case "OutFall 4":
                        currentPrice = price1;
                        break;
                    case "CS: OG":
                        currentPrice= price2;
                        break;
                    case "Zplinter Zell":
                        currentPrice= price3;
                        break;
                    case "Honored 2":
                        currentPrice= price4;
                        break;
                    case "RoverWatch":
                        currentPrice= price5;
                        break;
                    case "RoverWatch Origins Edition":
                        currentPrice= price6;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        inputGame = Console.ReadLine();
                        continue;
                        break;
                }
                if (currentPrice>currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    inputGame = Console.ReadLine();
                    continue;

                }
                else
                {
                    Console.WriteLine($"Bought {inputGame}");
                    currentBalance -= currentPrice;
                    totalSpent += currentPrice;
                    inputGame = Console.ReadLine();
                }
                if (currentBalance<=0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}
