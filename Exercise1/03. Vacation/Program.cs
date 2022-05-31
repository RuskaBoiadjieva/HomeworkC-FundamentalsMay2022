using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	A count of people, which are going on vacation.
            //•	Type of the group(Students, Business, or Regular).
            //•	 The day of the week which the group will stay(Friday, Saturday, or Sunday).

            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;


            //The price for a single person is as follows:
            //             Friday  Saturday    Sunday
            //    Students    8.45    9.80         10.46
            //    Business    10.90   15.60           16
            //    Regular     15      20           22.50

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            
                            break;
                        case "Saturday":
                            pricePerPerson = 9.8;
                           
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                           
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.9;
                        
                            break;
                        case "Saturday":
                            pricePerPerson = 15.6;
                        
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                         
                            break;
                    }
                    break;
                   
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                          
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                          
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                           
                            break;
                    }
                    break;


            }
            totalPrice = pricePerPerson * people;

                    if (typeOfGroup == "Students" && people>=30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    if (typeOfGroup == "Business" && people >= 100)
                    {
                        totalPrice = pricePerPerson * (people - 10);
                    }
                    if (typeOfGroup == "Regular" && people >= 10 && people<=20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }

            Console.WriteLine($"Total price: {totalPrice:f2}");

            //•	For Students, if the group is 30 or more people, you should reduce the total price by 15 %
            //•	For Business, if the group is 100 or more people, 10 of the people stay for free.
            //•	For Regular, if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %

            //"Total price: {price}" 
            //The price should be formatted to the second decimal point.
        }
    }
}
