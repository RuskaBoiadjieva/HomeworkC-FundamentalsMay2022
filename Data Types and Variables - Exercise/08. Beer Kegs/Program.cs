using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCen = int.Parse(Console.ReadLine());
            string biggestCen = string.Empty;
            double maxVolume = 0;

            for (int i = 0; i < numCen; i++)
            {
            string mogelCen = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine()); ;
            int height = int.Parse(Console.ReadLine());

            double volume=Math.PI*Math.Pow(radius,2)*height;

                if (volume>maxVolume)
                {
                    biggestCen = mogelCen;
                    maxVolume = volume;
                }

            }
            Console.WriteLine(biggestCen);

        }
    }
}
