using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give your weight:");
            string w = Console.Readline
            float weight = float.Parse(w); // this is a comment
            float height = 1.8f;
            float bmi = (weight / (height * height));
            // Console.WriteLine print something to the console
            Console.WriteLine($"BMI is: {bmi}");
            Console.Read();
        }
    }
}
