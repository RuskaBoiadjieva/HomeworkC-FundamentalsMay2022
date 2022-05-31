using System;

namespace _3._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diff = Math.Abs(a - b);
            bool isEqual = true;

            if (a==b|| diff<eps)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
    }
}
