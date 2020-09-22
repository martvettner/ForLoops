using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int userInput = Int32.Parse(Console.ReadLine());

            int result;
            int i = 10;
            for (i = 10; i > 1; i--)
            {
                result = userInput * i;
                Console.WriteLine($"{userInput} * {i} = {result}");
            }
        }
    }
}