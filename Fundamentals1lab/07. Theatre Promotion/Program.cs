using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //the type of day
            //– the age 

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //does not fit one of the categories, you should print "Error!"

            //Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //Weekday         12$	            18$	                12$
            //Weekend         15$	            20$	                15$
            //Holiday         5$	            12$	                10$

            if ((day=="Weekday" && age>=0 && age<=18) ||(day=="Weekday" && age>64 && age<=122) || (day=="Holiday" && age<=64 && age>18))
            {
                Console.WriteLine("12$");
            }
            else if ((day=="Weekend" && age >= 0 && age <=18) || (day=="Weekend"&& age>64 && age <= 122))
            {
                Console.WriteLine("15$");
            }
            else if (day=="Holiday" && age>=0 && age<=18)
            {
                Console.WriteLine("5$");
            }
            else if (day == "Weekday" && age > 18 && age<=64)
            {
                Console.WriteLine("18$");
            }
            else if (day == "Weekend" && age > 18 && age <= 64)
            {
                Console.WriteLine("20$");
            }
            else if (day == "Holiday" && age > 64 && age <= 122)
            {
                Console.WriteLine("10$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            //Print the price of the ticket according to the table, or "Error!" 

        }
    }
}
