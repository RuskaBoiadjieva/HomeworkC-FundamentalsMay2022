using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            •	Add first to the second.
            //•	Divide(integer) the result of the first operation by the third number.
            //•	Multiply the result of the second operation by the fourth number.

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int result = (num1 + num2) / num3 * num4;
            Console.WriteLine(result);

        }
    }
}
