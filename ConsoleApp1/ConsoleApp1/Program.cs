﻿using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give your weight:");
            string w = Console.ReadLine();
            float weight = float.Parse(w); // this is a comment
            Console.Write("Please give your height:");
            string h = Console.ReadLine();
            float height = float.Parse(h);
            float bmi = (weight / (height * height));
            // Console.WriteLine print something to the console
            Console.WriteLine($"BMI is: {bmi}");
            Console.Read();
        }
    }
}
