﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers=meters/1000m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
