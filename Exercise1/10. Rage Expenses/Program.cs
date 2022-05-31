using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    totalSum+=headsetPrice;
                }
                if (i%3==0)
                {
                    totalSum += mousePrice;
                }
                if (i%6==0)
                {
                    totalSum += keyboardPrice;
                }
                if (i %12==0)
                {
                    totalSum += displayPrice;
                }
            }
            //Every second-trashes his headset.
            //Every third-trashes his mouse.
            //When Petar trashes both his mouse and headset- trashes his keyboard.
            //Every second time, when he trashes his keyboard-trashes his display.

            // As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."
            // Allowed working time / memory: 100ms / 16MB.

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");


        }
    }
}
