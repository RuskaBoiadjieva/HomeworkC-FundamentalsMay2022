using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] dna = new int[length];
            int bestSeqIndex = 0;
            int bestSeqSum = 0;
            int[] bestDna = new int[length];
            int countDna = 0;
            int leftIndex = 0;
            //6
            //1!1!0!1!1!1
            //1!0!0!1!0!0
            //Clone them!

            while (input != "Clone them!")
            {
                dna = input.Split("!").Select(int.Parse).ToArray();
                countDna++;
                int count = 0;
                int longestSeq = 0;
                int sum = 0;
                for (int i = 0; i < dna.Length; i++)
                {

                    if (dna[i] == 1)
                    {
                        count++;

                    }
                    else
                    {
                        count=0;
                    }
                    

                    if (count > longestSeq)
                    {
                        bestSeqSum = 0;
                        longestSeq = count;
                        bestSeqIndex=countDna;
                        bestDna = dna.ToArray();
                        for (int j = 0; j < dna.Length; j++)
                        {
                            if (dna[j] == 1)
                            {
                                bestSeqSum++;
                            }
                        }
                    }
                    else if (count == longestSeq && dna[i] == bestDna[i]) 
                    {
                        for (int l = 0; l < dna.Length; l++)
                        {
                            if (dna[l]==1)
                            {
                                sum++;
                            }
                        }
                            bestSeqSum = 0;
                        for (int m = 0; m < bestDna.Length; m++)
                        {
                            if (bestDna[m]==1)
                            {
                                bestSeqSum++;
                            }
                        }
                        if (sum>bestSeqSum)
                        {
                            bestSeqSum = sum;
                            longestSeq = count;
                            bestSeqIndex = countDna;
                            bestDna = dna.ToArray();

                        }
                    }







                input = Console.ReadLine();
            }
                }


            Console.WriteLine($"Best DNA sample {bestSeqIndex} with sum: {bestSeqSum}.");
            
            Console.Write(String.Join(" ", bestDna));

        }
    }
}
