using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight = 80; // this is a comment
            float height = 1.8f;
            float bmi = (weight / (height * height));
            // Console.WriteLine print something to the console
            Console.WriteLine($"BMI is: {bmi}");
            Console.Read();
        }
    }
}
