using System;
using System.Linq;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a username
            //The user’s password is username reversed

            string userName = Console.ReadLine();
            string passWord = "";
            int incorectPass = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                passWord += userName[i];
            }

            string passEnter = Console.ReadLine();

            while (passEnter!=passWord)
            {
                incorectPass++;
                if (incorectPass==4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                passEnter=Console.ReadLine();
            }
            Console.WriteLine($"User {userName} logged in.");

            //•	If the password is incorrect print "Incorrect password. Try again."
            //•	If the password is correct print: "User {username} logged in." and stop thwhilee program
            //on the fourth attempt if the password is still not correct print: "User {username} blocked!" ,Then the program stops.



        }
    }
}
