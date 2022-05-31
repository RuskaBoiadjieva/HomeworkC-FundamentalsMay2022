using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int big1 = Math.Max(Math.Max(num1, num2), num3);
            //int big3 = Math.Min(Math.Min(num1,num2),num3);
            //int big2 = (num1+num2+num3)-(big1+big3);


            int first = 0;
            int second = 0;
            int third = 0;

            for (int i = 1; i <= 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    first = num;
                }
                else if (i == 2)
                {
                    if (num > first)
                    {
                        second = first;
                        first = num;
                    }
                    else
                    {
                        second = num;
                    }
                }
                else
                {
                    if (num > first)
                    {
                        third = second;
                        second = first;
                        first = num;
                    }
                    else if (num > second)
                    {
                        third = second;
                        second = num;
                    }
                    else
                    {
                        third = num;
                    }
                }
            }
           

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);





            //if (num1>num2)
            //{
            //    big1 = num1;
            //    if (num1>num3)
            //    {
            //        big1 = num1;
            //    }
            //    else
            //    {
            //        big1 = num3;
            //    }
            //}
            //else
            //{
            //    big1 = num2;
            //    if (num2 > num3)
            //    {
            //        big1 = num2;
            //    }
            //    else
            //    {
            //        big1 = num3;
            //    }

            //}
            //Console.WriteLine(big1);

            //if (big1==num1)
            //{
            //    if (num2>num3)
            //    {
            //        big2 = num2;
            //    }
            //    else
            //    {
            //        big2 = num3;
            //    }
            //}
            //else if (big1==num2)
            //{
            //    if (num1 > num3)
            //    {
            //        big2 = num1;
            //    }
            //    else
            //    {
            //        big2 = num3;
            //    }
            //}
            //else if (big1==num3)
            //{
            //    if (num1 > num2)
            //    {
            //        big2 = num1;
            //    }
            //    else
            //    {
            //        big2 = num2;
            //    }
            //}
            //Console.WriteLine(big2);
            //if (num1<num2)
            //{
            //    big3 = num1;
            //    if (num1<num3)
            //    {
            //        big3 = num1;
            //    }
            //    else
            //    {
            //        big3 = num3;
            //    }
            //}
            //else
            //{
            //    big3 = num2;
            //    if (num2 < num3)
            //    {
            //        big3 = num2;
            //    }
            //    else
            //    {
            //        big3 = num3;
            //    }
            //}
            //Console.WriteLine(big3);

        }
    }
}
