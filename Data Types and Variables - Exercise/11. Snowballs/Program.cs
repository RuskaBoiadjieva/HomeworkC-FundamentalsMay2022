using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfSnowball = int.Parse(Console.ReadLine());
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;
            BigInteger maxValue = 0;

            for (int i = 0; i < countOfSnowball; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snow / time, quality);
                if (snowballValue > maxValue)
                {
                    biggestSnow = snow;
                    biggestTime = time;
                    biggestQuality = quality;
                    maxValue = snowballValue;
                }

            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {maxValue} ({biggestQuality})");

        }


    }

}







