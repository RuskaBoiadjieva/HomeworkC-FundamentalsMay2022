using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pokPower = int.Parse(Console.ReadLine());
            int distPokTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double halfPokPower = pokPower / 2;
            int countOfPokes = 0;

            while (pokPower >= distPokTargets)
            {
                pokPower -= distPokTargets;
                countOfPokes++;
                if (pokPower == halfPokPower && exhaustionFactor>0)
                {
                    pokPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokPower);
            Console.WriteLine(countOfPokes);
        }
    }
}
